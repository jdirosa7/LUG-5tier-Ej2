using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JDR.LUG.Clase8.Ej2.Entities;
using JDR.LUG.Clase8.Ej2.BLL;

namespace JDR.LUG.Clase8.Ej2.UI
{
    public partial class VerMultas : Form
    {
        MultaBLL multaBll = new MultaBLL();
        public VerMultas()
        {
            InitializeComponent();
        }

        private void VerMultas_Load(object sender, EventArgs e)
        {
            ObtenerMultas();
        }

        private void ObtenerMultas()
        {
            List<Multa> multas = new List<Multa>();
            multas = multaBll.ObtenerMultas();

            dgvMultas.DataSource = null;
            dgvMultas.DataSource = multas;
        }
    }
}
