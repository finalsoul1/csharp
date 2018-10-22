using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;

class ClientHadler
{
    Socket socket = null;
    NetworkStream stream = null;
    StreamReader reader = null;
    StreamWriter writer = null;

    public ClientHadler(Socket socket)
    {
        this.socket = socket;
        Server.list.Add(socket);
    }

    public void chat()
    {
        stream = new NetworkStream(socket);
        Encoding encode = Encoding.GetEncoding("utf-8");

        reader = new StreamReader(stream, encode);

        while (true)
        {
            string str = reader.ReadLine();
            Console.WriteLine(str);

            foreach(Socket sok in Server.list)
            {
                stream = new NetworkStream(sok);
                writer = new StreamWriter(stream, encode) { AutoFlush = true };
                writer.WriteLine(str);
            }
        }
    }
}

class Server
{
    public static List<Socket> list = new List<Socket>();

    public static void Main()
    {
        TcpListener tcpListener = null;
        Socket clientsocket = null;

        try
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");

            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();

            while (true)
            {
                clientsocket = tcpListener.AcceptSocket();

                ClientHadler cHandler = new ClientHadler(clientsocket);
                Thread t = new Thread(cHandler.chat);
                t.Start();
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
