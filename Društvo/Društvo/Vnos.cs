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
using System.Runtime.Serialization.Formatters.Binary;

namespace Društvo
{
    public partial class Vnos : Form
    {
        string pot = Resource1.datoteka;
        public Vnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();
            try
            {
                d.ZapŠt = int.Parse(txtZapŠt.Text);
            }
            catch
            {
                lblStatus.Text = "Zaporedna številka je napačna";
                txtZapŠt.Text = "";
                txtZapŠt.Focus();
            }
            d.Datum = dtpDatum.Value;
            d.Namen = txtNamen.Text;
            try
            {
                d.Znesek = double.Parse(txtZnesek.Text);
            }
            catch
            {
                lblStatus.Text = "Znesek je napačen";
                txtZnesek.Text = "";
                txtZnesek.Focus();
            }
            d.Opombe = txtOpombe.Text;
            if (d.ZapŠt != 0 && d.Znesek != 0)
            {
                FileStream fs = new FileStream(pot, FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, d);
                fs.Close();
                lblStatus.Text = "Vnos uspešen";
                txtNamen.Text = "";
                txtOpombe.Text = "";
                txtZapŠt.Text = "";
                txtZnesek.Text = "";
                txtZapŠt.Focus();
            }
        }

        private void txtZapŠt_Leave(object sender, EventArgs e)
        {
            lblStatus.Text = "Pripravljen";
        }
    }
}
