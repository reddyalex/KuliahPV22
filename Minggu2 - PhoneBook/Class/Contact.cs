using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu2___PhoneBook.Class
{
    class Contact
    {

        public String Name { get; set; }
        public String Phone { get; set; }
        private Boolean emergency;

        public Boolean EmergencyContact
        {
            get { return emergency; }
            set { emergency = value; }
        }
        public Contact()
        {
            Name = "";
            Phone = "";
            emergency = false;
        }

        public Contact(string name, string phone, bool emergencyContact)
        {
            Name = name;
            Phone = phone;
            EmergencyContact = emergencyContact;
        }

        public override string ToString()
        {
            return "Name: " + Name + Environment.NewLine + 
                   "Phone: " + Phone + Environment.NewLine + 
                   "Emergency: " + emergency + Environment.NewLine;
        }

    }
}
