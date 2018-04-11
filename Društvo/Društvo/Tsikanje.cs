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

namespace Društvo
{
    public partial class Tsikanje : Form
    {
        private string pot=Resource1.datoteka;
        List<Darovi> vsi = new List<Darovi>();
        List<Darovi> spremembe = new List<Darovi>(); //filtrirani podatki
        public Tsikanje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void NaložiPodatke()
        {
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try
            {
                while (true)
                {
                    d = (Darovi)bf.Deserialize(fs);
                    vsi.Add(d);
                }
            }
            catch (SerializationException)
            {

            }
        }
    }
}
