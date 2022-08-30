using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minggu2___PhoneBook.Class;

namespace Minggu2___PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneBook pb;
        public Form1()
        {
            InitializeComponent();
            pb = new PhoneBook(10);
            pb.addContact(new Contact("Reddy", "87135", true));
            pb.addContact(new Contact("budi", "2384", false));
            pb.addContact(new Contact("jono", "4768", true));
            pb.addContact(new Contact("alice", "5135", false));
            pb.addContact(new Contact("mana", "21135", true));

            updateList();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact temp = new Contact();
            temp.Name = txtNama.Text;
            temp.Phone = txtPhoneNumber.Text;
            temp.EmergencyContact = chxEmergency.Checked;

            if (pb.addContact(temp))
            {
                MessageBox.Show("Contact Saved");
            }
            else
            {
                MessageBox.Show("Phone book is full");
            }
            updateList();
        }

        private void lbxContacs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Contact temp = (Contact) lbxContacs.Items[lbxContacs.SelectedIndex];
            if (lbxContacs.SelectedIndex > 0)
            {

                Contact temp = (Contact)lbxContacs.SelectedItem;

                txtNama.Text = temp.Name;
                txtPhoneNumber.Text = temp.Phone;
                chxEmergency.Checked = temp.EmergencyContact;
            }

        }

        void updateList(bool showall=true)
        {
            lbxContacs.DataSource = null;

            if (showall)
                lbxContacs.DataSource = pb.viewAllContacts();
            else
                lbxContacs.DataSource = pb.viewEmergencyContacts();


            //lbxContacs.Items.Clear();
            //textBox1.Clear();
            //if (!showall)
            //{
            //    foreach (var item in pb.viewEmergencyContacts())
            //    {
            //        lbxContacs.Items.Add(item);
            //        textBox1.AppendText(item.ToString());
            //    }
            //}
            //else
            //{
            //    foreach (var item in pb.viewAllContacts())
            //    {
            //        lbxContacs.Items.Add(item);
            //        textBox1.AppendText(item.ToString());
            //    }
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pb.deleteAll();
            updateList();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact is Empty? " + pb.isEmpty());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact is Full? " + pb.isFull());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateList(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResult.Text = pb.searchContact(txtCariNama.Text);
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pb.delete(txtCariNama.Text);
            updateList();
        }

    }
}
