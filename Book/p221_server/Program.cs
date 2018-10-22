using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    public static void Main()
    {
        NetworkStream stream = null;
        TcpListener tcpListener = null;
        Socket clientsocket = null;
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용할려고
            IPAddress ipAd = IPAddress.Parse("192.168.0.31");

            //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다. 
            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();

            //Client의 접속이 올때 까지 Block 되는 부분, 대개 이부분을 Thread로 만들어 보내 버린다.
             //백그라운드 Thread에 처리를 맡긴다.
            clientsocket = tcpListener.AcceptSocket();
            // 소켓을 만들어서 클라이언트 접속을 기다림

            //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다.
            stream = new NetworkStream(clientsocket);
            Encoding encode = Encoding.GetEncoding("utf-8");

            // 한 라인씩 읽어들이기 위한 클래스
            reader = new StreamReader(stream, encode);

            // 버퍼에 있는걸 확 부어버려라
            writer = new StreamWriter(stream) { AutoFlush = true };

            while (true)
            {
                string str = reader.ReadLine();
                // 클라이언트에서 보낸 데이터를 한줄씩 읽고 화면에 출력
                Console.WriteLine(str);

                writer.WriteLine(str);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            clientsocket.Close();
        }
    }
}