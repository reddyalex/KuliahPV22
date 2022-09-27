using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KelasLib;

namespace Minggu6DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        int ctr = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            mahasiswa mhs = new mahasiswa(txtNrp.Text, txtNama.Text, Convert.ToInt32( txtNilai.Text));

            dataGridView1.Rows.Add(mhs.nrp,mhs.nama, mhs.nilai);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows[2].Cells[1].Value = textBox1.Text;
            int baris = dataGridView1.CurrentCell.RowIndex;
            int col = dataGridView1.CurrentCell.ColumnIndex;

            dataGridView1.Rows[baris].Cells[1].Value = textBox1.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex< dataGridView1.Rows.Count-1) { 
                int baris = dataGridView1.CurrentCell.RowIndex;
                MessageBox.Show(
                    dataGridView1.Rows[baris].Cells[0].Value + " " +
                    dataGridView1.Rows[baris].Cells[1].Value + " " +
                    dataGridView1.Rows[baris].Cells[2].Value + " ");
            }
        }

        //List<mahasiswa> mahasiswas = new List<mahasiswa>();
        BindingSource mahasiswas = new BindingSource();
        private void button3_Click(object sender, EventArgs e)
        {
            mahasiswa mhs = new mahasiswa(txtNrp.Text, txtNama.Text, Convert.ToInt32( txtNilai.Text));

            mahasiswas.Add(mhs);

            //dataGridView2.DataSource = null;
            //dataGridView2.DataSource = mahasiswas;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView2.Columns[0].DataPropertyName = "nrp";
            dataGridView2.Columns[1].DataPropertyName = "nama";
            dataGridView2.Columns[2].DataPropertyName = "nilai";
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSize = true;
            dataGridView2.DataSource = mahasiswas;
        }
    }


}
