using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Društvo
{
    public partial class Zaščita : Form
    {
        string pot = Resource1.datoteka;
        List<Darovi> vsi = new List<Darovi>();
        public Zaščita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //beri iz binarne datoteke
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                while (true)
                {
                    Darovi d = (Darovi)bf.Deserialize(fs);
                    vsi.Add(d);
                }
            }
            catch (SerializationException) { }
            //piši v xml datoteko
            string imeD = @"D:\Pro2\Zascita" + DateTime.Now.ToShortDateString() + ".xml";
            FileStream fs1 = new FileStream(imeD, FileMode.Create);
            XmlSerializer sr = new XmlSerializer(typeof(List<Darovi>));
            sr.Serialize(fs1, vsi);
            fs1.Close();
            MessageBox.Show("Opravljeno");
        }
    }
}
