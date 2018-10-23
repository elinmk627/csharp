using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleTest {
    public partial class Form1 : Form  {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                ds = new DataSet("emp");

                //아래 onj는 $ORACLE_HOME/network/admin에 있는 tnsnames.ora 파일에 정의된 이름!
                string conStr = @"Data Source=(DESCRIPTION =
                                         ( ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                             (CONNECT_DATA =
                                                 (SERVER = DEDICATED)
                                                 (SERVICE_NAME = topcredu)
                                             )
                                         ) ;User Id=scott;Password=tiger; Provider=OraOleDB.Oracle";

                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno, ename) values(8999, 'OJC')", conn);
                command.ExecuteNonQuery();
                adapter = new OleDbDataAdapter("select * from emp where ename='OJC'", conn);
                adapter.Fill(ds, "Emp");
                dataGridView1.DataSource = ds.Tables["Emp"];
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally {
                conn.Close();
            }
        }
    }
}
