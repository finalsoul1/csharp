using Oracle.ManagedDataAccess.Client;
using System;
namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //아래에서 data source의 onj는 tnsnames.ora 파일의 DB접속이름이다.
            /* string str = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
            (CONNECT_DATA =
            (SERVER = DEDICATED)
            (SERVICE_NAME = topcredu)
            )
            ) ; User Id = scott; Password = tiger";
            */
            //콘솔프로그램에서 TNS 이름을 해석하지 못하는 오류가 발생한다면 위와 같이
            // TNSNAMES.ORA 파일의 내용을 직접 기술하여 처리하자.
            string str = "data source=topcredu;user id=scott; password=tiger";

            OracleConnection Conn = new OracleConnection(str);

            OracleCommand Comm = new OracleCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OracleDataReader reader = Comm.ExecuteReader();
                // 쿼리를 OracleDataReader가 받음

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
