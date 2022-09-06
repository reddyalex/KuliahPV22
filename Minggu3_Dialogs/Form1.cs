using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu3_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            allbtn = new List<Button>();

        }
        List<Button> allbtn;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("message di form load");
            //load database
            //mengisi kompononen-komponen seperti combo box, listbox

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = "10";
                btn.Left = button2.Left + i * 40;
                btn.Top = button2.Top + 40;
                btn.Width = 35;               
                btn.Click += new System.EventHandler(this.button2_Click);
                this.Controls.Add(btn);
                allbtn.Add(btn);
            }

            foreach (var item in this.Controls)
            {
                if( item is Button)
                {
                    Button btn = (Button) item;
                    if(btn.Text == "Tutup Form")
                    {
                        MessageBox.Show(btn.Name);
                    }
                }
            }

            foreach (var item in allbtn)
            {
                item.PerformClick();
            }


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
            //MessageBox.Show("message di form Shown");
            //digunakan untuk mengatur tampilan komponen

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr
            //MessageBox.Show(e.CloseReason.ToString());
            //var dr = MessageBox.Show("Apakah yakin mau di tutup?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //if (dr == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
                //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //DialogResult dr
            //var dr = MessageBox.Show("Apakah yakin mau di tutup?","Konfirmasi",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            //if (dr == DialogResult.OK)
                
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tempbtn = (Button)sender;
            tempbtn.Text = Convert.ToInt32(tempbtn.Text) - 1 +"";

            //button2.Text = Convert.ToInt32(button2.Text) - 1 + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Convert.ToInt32(button3.Text) - 1 + "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocument frm = new FrmDocument();

            frm.Show();
        }
    }
}
