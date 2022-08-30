using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu2___PhoneBook.Class
{
    class PhoneBook
    {
        private List<Contact> contacts;
        private int numOfContacts;

        public PhoneBook(int numOfContacts)
        {
            this.numOfContacts = numOfContacts;
            contacts = new List<Contact>();            
        }

        public bool addContact(Contact contact)
        {
            if (contacts.Count >= numOfContacts) return false;
            contacts.Add(contact);
            return true;
        }
        public int getSize()
        {
            return contacts.Count;
        }

        public List<Contact> viewAllContacts()
        {
            return contacts;
        }

        public List<Contact> viewEmergencyContacts()
        {
            //List<Contact> temp = new List<Contact>();
            //foreach (var c in contacts)
            //{
            //    if (c.EmergencyContact == true)
            //    {
            //        temp.Add(c);
            //    }
            //}
            //return temp;

            return contacts.FindAll((x) => x.EmergencyContact == true);

        }

        public string searchContact(string name)
        {
            //contacts.IndexOf() // tidak cocok untuk kasus ini karena compare objek secara utuh bukan mencari bagian dari objek
            var x = contacts.Find((c) => c.Name == name);
            if (x is null) 
                return "Contact not found";
            else 
                return x.Name + " " + x.Phone;                   
        }

        public void delete(string name)
        {
            //var x = contacts.Find((c) => c.Name == name);
            //if (x != null)
            //    contacts.Remove(x);

            var jum = contacts.RemoveAll((x) => x.Name == name);
            MessageBox.Show(jum + " data deleted");

            
        }

        public void deleteAll()
        {
            contacts.Clear();
        }

        public bool isEmpty()
        {
            return contacts.Count == 0;
        }
        public bool isFull()
        {
            return contacts.Count == numOfContacts;
        }
    }
}
