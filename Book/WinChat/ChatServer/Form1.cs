using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ChatServer
{
    delegate void SetTextCallback(string s);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener lit_Listener = new TcpListener(IPAddress.Parse("192.168.0.31"), 5001);
        public static ArrayList soketArray = new ArrayList();
        public static int count = 0;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            lit_Listener.Stop();
        }

        private void cmd_Start_Click(object sender, EventArgs e)
        {
            if(Ibl_Message.Tag.ToString() == "Stop")
            {
                lit_Listener.Start();
                Thread trd_WaitSocket = new Thread(Wait_Socket);
                trd_WaitSocket.Start();
                Ibl_Message.Text = "연결대기중..";
                Ibl_Message.Tag = "Start";
                cmd_Start.Text = "Server Stop";
                Thread trd_join = new Thread(Join);
                trd_join.Start();
            }
            else
            {
                lit_Listener.Stop();
                foreach(Socket soc in Form1.soketArray)
                {
                    soc.Close();
                }
                Form1.soketArray.Clear();
                Ibl_Message.Text = "서버 닫힘";
                Ibl_Message.Tag = "Stop";
                cmd_Start.Text = "Server Start";
                label1.Text = "0명 참가중";
                count = 0;
            }
            
        }

        //텍스트박스 입력 메소드
        public void SetText(string text)
        {
            if (this.txt_Chat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txt_Chat.AppendText(text);
            }
        }

        private void Wait_Socket()
        {
            Socket skt = null;
            while (true)
            {
                try
                {
                    skt = lit_Listener.AcceptSocket();
                    Chat chat = new Chat();
                    chat.ChatSetup(this, skt, this.txt_Chat);
                    Thread trd_ChatProcess = new Thread(chat.ChatProcess);
                    trd_ChatProcess.Start();
                }
                catch (System.Exception)
                {
                    Form1.soketArray.Remove(skt); break;
                }
            }
        }
        public void Join()
        {
            while (true)
            {
                string str = count + "명 참가중";
                label1.Text = str;
            }
        }
    }

    public class Chat
    {
        private Encoding kor_encode = 
            Encoding.GetEncoding("KS_C_5601-1987");
        private System.Windows.Forms.TextBox ChatTxt;
        private Socket sktClient;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;

        public void ChatSetup(Form1 form1, Socket sktClient, 
            System.Windows.Forms.TextBox ChatTxt)
        {
            this.ChatTxt = ChatTxt;
            this.sktClient = sktClient;
            this.netStream = new NetworkStream(sktClient);
            Form1.soketArray.Add(sktClient);
            this.strReader = new StreamReader(netStream, kor_encode);
            this.form1 = form1;
        }
        public void ChatProcess()
        {
            Form1.count++;
            while (true)
            {
                try
                {
                    string lstMessage = strReader.ReadLine();
                    if(lstMessage != null && lstMessage != "")
                    {
                        form1.SetText(lstMessage + "\r\n");

                        byte[] bytSand_Data = 
                            Encoding.Default.GetBytes
                            (lstMessage + "\r\n");
                        ArrayList remove_soketArray = new ArrayList();
                        lock (Form1.soketArray)
                        {
                            foreach (Socket soc in Form1.soketArray)
                            {
                                NetworkStream stream = 
                                    new NetworkStream(soc);
                                stream.Write(
                                    bytSand_Data, 0, bytSand_Data.Length);
                            }
                            
                        }
                    }
                }
                catch (System.Exception e)
                {
                    Form1.count--;
                    MessageBox.Show(e.ToString());
                    Form1.soketArray.Remove(sktClient);
                    break;
                }
            } 
        }
    }
}
