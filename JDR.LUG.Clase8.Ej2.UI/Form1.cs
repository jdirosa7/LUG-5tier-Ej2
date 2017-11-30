using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDR.LUG.Clase8.Ej2.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiposDeMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposMulta tm = new TiposMulta();
            tm.MdiParent = this;
            tm.Show();
        }

        private void administrarMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMultas am = new AdminMultas();
            am.MdiParent = this;
            am.Show();
        }

        private void verMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerMultas vm = new VerMultas();
            vm.MdiParent = this;
            vm.Show();
        }
    }
}
