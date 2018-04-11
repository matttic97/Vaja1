using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Društvo
{
    public partial class GlavnoOkno : Form
    {
        public GlavnoOkno()
        {
            InitializeComponent();
        }

        private void vnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vnos a = new Vnos();
            a.MdiParent = this;
            a.Show();
        }

        private void prgeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled a = new Pregled();
            a.MdiParent = this;
            a.Show();
        }

        private void shraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaščita a = new Zaščita();
            a.MdiParent = this;
            a.Show();
        }

        private void obnoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obnova a = new Obnova();
            a.MdiParent = this;
            a.Show();
        }

        private void tiskanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tsikanje a = new Tsikanje();
            a.MdiParent = this;
            a.Show();
        }
    }
}
