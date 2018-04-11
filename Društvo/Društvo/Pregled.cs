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
    public partial class Pregled : Form
    {
        string pot = Resource1.datoteka;
        List<Darovi> spremembe = new List<Darovi>();
        int štSprememb = 0;
        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try
            {
                while (true)
                {
                    d = (Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            }
            catch (SerializationException) {
              
            }
            dgwPodatki.DataSource = spremembe;
            fs.Close();
            //oblikuj datagridview
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "###.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            //foreach (DataGridViewRow vrstica in dgwPodatki.Rows)
            //{
            //    double tip = double.Parse(vrstica.Cells[3].Value.ToString());
            //    if (tip < 0)
            //        vrstica.DefaultCellStyle.BackColor = Color.LightPink;
            //    else
            //        vrstica.DefaultCellStyle.BackColor = Color.LightGray;
            //}
            //dgwPodatki.Refresh();
        }

        private void Pregled_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow vrstica in dgwPodatki.Rows)
            {
                double tip = double.Parse(vrstica.Cells[3].Value.ToString());
                if (tip < 0)
                    vrstica.DefaultCellStyle.BackColor = Color.LightPink;
                else
                    vrstica.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void dgwPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapŠt =int.Parse(dgwPodatki.Rows[vrstica].Cells["ZapŠt"].Value.ToString());
            d.Datum = DateTime.Parse(dgwPodatki.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgwPodatki.Rows[vrstica].Cells["Namen"].Value.ToString();
            d.Znesek = double.Parse(dgwPodatki.Rows[vrstica].Cells["Znesek"].Value.ToString());
            d.Opombe = dgwPodatki.Rows[vrstica].Cells["Opombe"].Value.ToString();
            spremembe[vrstica] = d;
            štSprememb++;
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            ShraniSpremembe();
        }

        private void Pregled_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (štSprememb != 0)
            {
                DialogResult a = MessageBox.Show("Imaš neshranjene spremebe "
                    + Environment.NewLine + "Shranim sedaj?", "Opozorilo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    ShraniSpremembe();
                }
            }
        }

        private void ShraniSpremembe()
        {
            FileInfo fi = new FileInfo(pot);
            fi.Delete();
            prgStatus.Value = 0;
            prgStatus.Maximum = spremembe.Count;
            FileStream fs = new FileStream(pot, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe)
            {
                bf.Serialize(fs, d);
                prgStatus.Increment(1);
            }
            fs.Close();
            štSprememb = 0;
        }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Resnično želiš bristo vrstico ?",
                "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                int b = dgwPodatki.CurrentRow.Index;
                BrišiVrstico(b);
            }
        }

        private void BrišiVrstico(int b)
        {
            spremembe.RemoveAt(b);
            štSprememb++;
            dgwPodatki.DataSource = null;
            dgwPodatki.Rows.Clear();
            dgwPodatki.DataSource = spremembe;
            //oblikovanje -- isto kot v Form load
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "###.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow vrstica in dgwPodatki.Rows)
            {
                double tip = double.Parse(vrstica.Cells[3].Value.ToString());
                if (tip < 0)
                    vrstica.DefaultCellStyle.BackColor = Color.LightPink;
                else
                    vrstica.DefaultCellStyle.BackColor = Color.LightGray;
            }
            dgwPodatki.Refresh();
        }
    }
}
