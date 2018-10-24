using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp3 {
    class CommandExam  {
        static void Main(string[] args) {
            string str = @"Data Source=(DESCRIPTION =
                                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                                    (CONNECT_DATA =
                                                        (SERVER = DEDICATED)
                                                        (SERVICE_NAME = topcredu)
                                                    )
                                ) ; User Id = scott; Password = tiger";
            OracleConnection Conn = new OracleConnection(str);
            Conn.Open();

            //갱신 및 기타 작업을 위한 Adapter를 하나 만든다.
            OracleDataAdapter adapter = new OracleDataAdapter("select * from emp", Conn);

            DataSet ds = new DataSet("myemp");
            adapter.Fill(ds, "사원");

            // 데이터 화면에 출력
            foreach(DataRow r in ds.Tables["사원"].Rows) {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"], r["sal"]);
            }

            // 데이터 변경
            ds.Tables["사원"].Rows[0]["ename"] = "홍길동";

            // Update Method를 호출 하기 위해 CommandBuilder를 만듬
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(adapter);

            // Rows 컬렉션안의 DataRow 개체에는 RowState 라는 속성이 있는데 
            // 이 속성은 그 행의 삭제, 추가, 수정 여부 상태를 의미
            adapter.Update(ds, "사원");

            //변경 후 DataTable 자료 출력
            Console.WriteLine();
            foreach(DataRow r in ds.Tables["사원"].Rows) {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"], r["sal"]);
            }
            DataRow row = ds.Tables["사원"].NewRow();
            row["empno"] = 1988;
            row["ename"] = "88홍길동"; 
            row["sal"] = 7777;
            ds.Tables["사원"].Rows.Add(row);

            adapter.Update(ds, "사원");

            //다시 DB에서 데이터 원본을 추출, 테이블의 내용이 바뀐 것을 확인
            adapter = new OracleDataAdapter("select * from emp", Conn);
            adapter.Fill(ds, "사원");

            //추가 후 자료 출력
            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows) {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
               r["sal"]);
            }
            Console.WriteLine(" 총 {0} 건 입니다.", ds.Tables["사원"].Rows.Count);
        }
    }
}
