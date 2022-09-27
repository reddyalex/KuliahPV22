using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KelasLib
{
    [XmlRootAttribute("MHS"), Serializable]
    public class mahasiswa
    {

        private String ortu;
        //public String nama, nrp;
        //public int nilai;
        public String nama { get; set; }
        public String nrp { get; set; }
        public int nilai { get; set; }
        public mahasiswa()
        {
            ortu = "";
            nama = "";
            nrp = "";
            nilai = 0;
        }

        public mahasiswa(string nama, string nrp)
        {
            this.ortu = "";
            this.nama = nama;
            this.nrp = nrp;
            this.nilai = 90;
        }
        public mahasiswa(string nrp, string nama, int nilai)
        {
            this.ortu = "";
            this.nama = nama;
            this.nrp = nrp;
            this.nilai = nilai;
        }
    }
}
