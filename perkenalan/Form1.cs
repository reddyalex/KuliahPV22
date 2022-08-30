using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perkenalan
{
    public partial class frmUtama : Form
    {
        public frmUtama()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("button1 Enter");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {

            }

            var k = "tipe string";

            List<int> arrlist = new List<int>();

            int x = Convert.ToInt32("32");

            int x1 = Int32.Parse("32");






            foreach (Control item in this.Controls)
            {
                MessageBox.Show(item.ToString());
                if (item.ToString().IndexOf("Button") >= 0)
                {
                    Button temp = (Button)item;
                    temp.Text = "text Button ganti";
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("hayooo");
        }
    }
}
