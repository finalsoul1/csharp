using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;


class ServerHandler
{
    StreamReader reader = null;

    public ServerHandler(StreamReader reader)
    {
        this.reader = reader;
    }

    public void read()
    {
        try
        {
            while (true)
            {
                string str = reader.ReadLine().Trim();
                Console.WriteLine(str);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}

class TcpClientTest
{
    static void Main(string[] args)
    {
        TcpClient client = null;
        try
        {

            client = new TcpClient();
            client.Connect("192.168.0.15", 5001);
            NetworkStream stream = client.GetStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

            StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };
            StreamReader reader = new StreamReader(stream, encode);

            ServerHandler serverHandler = new ServerHandler(reader);

            Thread t = new Thread(serverHandler.read);
            t.Start();

            string dataToSend = Console.ReadLine();

            while (true)
            {
                writer.WriteLine(dataToSend);

                if (dataToSend.IndexOf("<EOF>") > -1) break;
                dataToSend = Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            client.Close();
            client = null;
        }
    }
}