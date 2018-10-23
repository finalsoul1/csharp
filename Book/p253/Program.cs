using System;
using System.Windows.Forms;


namespace p253
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            // 마우스 클릭시 필터링
            if(m.Msg == 0x201)
            {
                // 필터에서 처리했으니 응용프로그램에서 처리하지 않아도 된다는 의미
                Console.WriteLine("마우스 클릭 필터링됨..");
                return true;
            }
            return false;
        }
    }
    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Program p = new Program();
            p.Click += (object sender, EventArgs e) =>
            {
                Console.WriteLine("마우스 클릭 발생..");
                Application.Exit();
            };
            Application.Run(p);
        }
    }
}
