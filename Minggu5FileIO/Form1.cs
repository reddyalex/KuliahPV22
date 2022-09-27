using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using KelasLib;

namespace Minggu5FileIO
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                var f = File.Create(@"inidata2.txt");
                byte[] temp = Encoding.UTF8.GetBytes("halo".ToCharArray());
                f.Write(temp, 0, temp.Length);//halo
                f.WriteByte(13);
                f.Write(temp, 2, 2);//halo
                                    //lo

                f.Close();


                if (File.Exists(@"inidata.txt"))
                {
                    //textBox1.Text = File.ReadAllText(@"inidata.txt");

                    //var fo = File.Open(@"inidata.txt", FileMode.Open);

                    StreamReader sr = new StreamReader("inidata.txt");
                    String str = sr.ReadLine();
                    while (str !=null)
                    {
                        textBox1.AppendText(str+ Environment.NewLine);
                        str = sr.ReadLine();
                    }
                }


                StreamWriter sw = new StreamWriter("contoh.txt");
                sw.WriteLine("halo");
                sw.Close();

                BinaryWriter bw = new BinaryWriter(File.Open("data.dat", FileMode.Create));

                bw.Write(65);
                bw.Write("ini text");
                bw.Write(72.25);
                bw.Write('a');


                bw.Close();

                BinaryReader br = new BinaryReader(File.Open("data.dat", FileMode.Open));
                textBox1.Text = "Integer=" + br.ReadInt32() + Environment.NewLine;
                textBox1.AppendText("String= " + br.ReadString() + Environment.NewLine);
                
                textBox1.AppendText("char= " + br.ReadChar() + Environment.NewLine);
                textBox1.AppendText("double= " + br.ReadDouble() + Environment.NewLine);


                //XmlDocument xmlDocument = new XmlDocument();

                //XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                //xmlDocument.AppendChild(xmlDeclaration);
                //var el = xmlDocument.CreateElement("configuration");

                //xmlDocument.AppendChild(el);

                //var st = xmlDocument.CreateElement("Startup");
                //el.AppendChild(st);

                //var supportedRuntime = xmlDocument.CreateElement("supportedRuntime");

                //supportedRuntime.SetAttribute("version", "v4.0");
                //supportedRuntime.SetAttribute("sku", ".NETFramework,Version=v4.7.2");
                //st.AppendChild(supportedRuntime);


                //xmlDocument.Save(File.Open("test.xml", FileMode.Create));

                string path = "test.xml";

                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                var root = doc.DocumentElement;

                textBox1.Text = root.FirstChild.InnerText;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            List<mahasiswa> list = new List<mahasiswa>();

            mahasiswa mhs = new mahasiswa("rahasia","budi",123);

            list.Add(mhs);
            list.Add(new mahasiswa("123", "nama 2", 12));


            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, mhs);
            stream.Close();

            //XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(mahasiswa) } );
            XmlSerializer serializer = new XmlSerializer(typeof(List<mahasiswa>));
            TextWriter writer = new StreamWriter("serialize.xml");


            serializer.Serialize(writer, list);
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String path = @"W:\Pemrograman Aplikasi Desktop\Minggu1\";
            label1.Text = path;
            var filenames = Directory.GetDirectories(path);

            foreach (var item in filenames)
            {
                listBox1.Items.Add(item);
                
            }

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            XmlSerializer serializer = new XmlSerializer(typeof(mahasiswa));
            
            FileStream fs = new FileStream("serialize.xml", FileMode.Open);
            mahasiswa po;
            po = (mahasiswa)serializer.Deserialize(fs);
            Console.WriteLine("OrderDate: " + po.nama);
        }
    }

    

}
