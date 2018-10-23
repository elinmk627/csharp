using System;
using System.Data.OleDb;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 오라클DB 클라이언트 안깔았을때 사용
            string str = @"Data Source=(DESCRIPTION =
                                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                                    (CONNECT_DATA =
                                                        (SERVER = DEDICATED)
                                                        (SERVICE_NAME = topcredu)
                                                    )
                                ) ; User Id = scott; Password = tiger ; Provider=OraOleDB.Oracle";

            // 콘솔프로그램에서 TNS 이름을 해석하지 못하는 오류가 발생한다면 위와 같이
            //  TNSNAMES.ORA 파일의 내용을 직접 기술하여 처리하자.

            // DB Connection / DB연결문
            //string str = "data source=topcredu;user id =scott; password=tiger";

            OleDbConnection Conn = new OleDbConnection(str);
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;

            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OleDbDataReader reader = Comm.ExecuteReader();  // ExecuteReader로 select문 실행하여 reader가 받음
                while (reader.Read())
                {                                                  // 읽을게 있는동안에
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
