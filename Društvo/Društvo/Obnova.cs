using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Društvo
{
    public partial class Obnova : Form
    {
        List<Darovi> vsi = new List<Darovi>();
        public Obnova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dateTimePicker1.Value.ToShortDateString();
                string imeD = @"D:\Pro2\Zascita" + a + ".xml";
                FileStream fs1 = new FileStream(imeD, FileMode.Open);
                XmlSerializer sr = new XmlSerializer(typeof(List<Darovi>));
                vsi = (List<Darovi>)sr.Deserialize(fs1);
                fs1.Close();

                string pot = Resource1.datoteka;
                FileInfo fi = new FileInfo(pot);
                fi.Delete();

                FileStream fs = new FileStream(pot, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                foreach (Darovi d in vsi)
                {
                    bf.Serialize(fs, d);
                }
                fs.Close();
                MessageBox.Show("Opravljeno");
            }
            catch (FileNotFoundException) {
                MessageBox.Show("Na ta dan ni bilo zaščite, poskusi z drugim datumom");
            }
        }
    }
}
