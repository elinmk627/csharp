using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace ConsoleApp2 
{
    class CommandExam
    {
        static OleDbConnection cn;
        static void Main()
        {
            OleCn();
            Openning();

            Console.WriteLine("Added Table");       Adding();       Output();
            Console.WriteLine("Modified Table");       Modifying();       Output();
            Console.WriteLine("Deleted Table");       Deleting();       Output();
            Closing();
        }

        public static void OleCn()
        {
            string str = @"Data Source=(DESCRIPTION =
                                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                                    (CONNECT_DATA =
                                                        (SERVER = DEDICATED)
                                                        (SERVICE_NAME = topcredu)
                                                    )
                                ) ; User Id = scott; Password = tiger ; Provider=OraOleDB.Oracle";
            cn = new OleDbConnection(str);
        }

        public static void Openning()
        {
            cn.Open();
        }
        public static void Output()
        {
            string sql = "SELECT empno id, ename name FROM emp";
            OleDbCommand cmd;
            OleDbDataReader dr;
            cmd = new OleDbCommand(sql, cn);
            dr = cmd.ExecuteReader();

            Console.Write("\n");
            while(dr.Read())
            {
                Console.WriteLine("{0, -10}\t{1, -10}", dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }
            Console.Write("\n");
            dr.Close();
        }

        public static void Adding()
        {
            try
            {
                string sqladd = "INSERT INTO emp (empno, ename) VALUES (627,'JMK')";
                OleDbCommand cmdAdd = new OleDbCommand(sqladd, cn);

                int rowsadded = cmdAdd.ExecuteNonQuery();
                Console.WriteLine("Number of rows added: " + rowsadded);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Modifying()
        {
            try
            {
                string sqlmodify = "UPDATE emp SET ename = 'sAngel' WHERE empno = 627";
                OleDbCommand cmdupdate = new OleDbCommand(sqlmodify, cn);
                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine("Number of rows modified: " + rows);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        public static void Deleting()
        {
            try
            {
                string sqldelete = "DELETE FROM emp WHERE empno = 627";
                OleDbCommand cmddelete = new OleDbCommand(sqldelete, cn);
                int rows = cmddelete.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + rows);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Closing()
        {
            cn.Close();
        }
    }
}
