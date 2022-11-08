using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu11_Basic_Report
{
    public partial class Form1 : Form
    {
        public static MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            var rpt = new rptMasterCustomer();
            if (comboBox1.SelectedIndex > 0)
            {
                rpt.SetParameterValue("filtercountry", comboBox1.SelectedValue);

            }
            else
            {
                rpt.SetParameterValue("filtercountry", "*");
            }


            f.crystalReportViewer1.ReportSource = rpt;


            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            rptMasterSuppliers rpt = new rptMasterSuppliers();

            //rpt.SetDatabaseLogon()

            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            if (comboBox1.SelectedIndex == 0)
            {
                da = new MySqlDataAdapter("select * from suppliers", Form1.conn);
            }
            else
            {
                string a= $"select * from suppliers where country='{comboBox1.SelectedValue.ToString()}'";
                //MessageBox.Show(a);

                da = new MySqlDataAdapter(a, conn);

            }

            
            da.Fill(ds, "suppliers");


            rpt.SetDataSource(ds);


            f.crystalReportViewer1.ReportSource = rpt;



            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;user id=nw;password=12345;persistsecurityinfo=True;database=northwind");
            conn.Open();

            var dt = new dsNorthwind.negaraDataTable();
           
            dt.AddnegaraRow("All Country");

            MySqlDataAdapter da = new MySqlDataAdapter("select country from suppliers group by country order by country asc", conn);
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "country";
            comboBox1.ValueMember = "country";
           
        }
    }
}
