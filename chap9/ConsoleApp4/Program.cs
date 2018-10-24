using System;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp4 {
    class Sample  {
        public static void Main() {           
            string str = @"Data Source=(DESCRIPTION =
                                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                                    (CONNECT_DATA =
                                                        (SERVER = DEDICATED)
                                                        (SERVICE_NAME = topcredu)
                                                    )
                                ) ; User Id = scott; Password = tiger";
            OracleConnection thisConnection = new OracleConnection(str);
            thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * from emp", thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            Console.WriteLine("SQL SELECT Command is:\n{0}\n", thisAdapter.SelectCommand.CommandText);

            OracleCommand updateCommand = thisBuilder.GetUpdateCommand();
            Console.WriteLine("SQL UPDATE Command is:\n{0}\n", updateCommand.CommandText);

            OracleCommand insertCommand = thisBuilder.GetInsertCommand();
            Console.WriteLine("SQL INSERT Command is:\n{0}\n", insertCommand.CommandText);

            OracleCommand deleteCommand = thisBuilder.GetDeleteCommand();
            Console.WriteLine("SQL DELETE Command is:\n{0}", deleteCommand.CommandText);
            thisConnection.Close();
        }
    }
}
