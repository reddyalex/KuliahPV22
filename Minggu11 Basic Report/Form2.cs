using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Minggu11_Basic_Report
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int jenisReport)
        {
            InitializeComponent();
            reportnum = jenisReport;
        }
        int reportnum;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            


            if(reportnum == 1)
            {

                crystalReportViewer1.ReportSource = new rptMasterCustomer();

            }
            else if(reportnum == 2)
            {
                
            }
        }
    }
}
