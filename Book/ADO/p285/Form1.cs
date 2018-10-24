using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace p285
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form_Load OK~");
            MessageBox.Show("Form_Load OK~");
            try
            {
                // DataSet: 메모리에 있는 db
                ds = new DataSet("emp");
                string conStr = "Provider=OraOleDB.Oracle; data source=topcredu;" +
                    "User ID=scott; Password=tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp" +
                    "(empno, ename) values(8001,'Kwon')", conn);
                command.ExecuteNonQuery();
                adapter = new OleDbDataAdapter
                    ("select * from emp", conn);
                adapter.Fill(ds, "EMP");
                dataGridView1.DataSource = ds.Tables["EMP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
