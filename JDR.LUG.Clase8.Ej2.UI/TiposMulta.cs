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
    public partial class TiposMulta : Form
    {
        TipoMultaBLL tipoBll = new BLL.TipoMultaBLL();
        public TiposMulta()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            TipoMulta tipo = new TipoMulta();
            tipo.Tipo = txtDesc.Text;
            tipo.Precio = Convert.ToInt32(txtMonto.Text);

            tipoBll.Insertar(tipo);

            ObtenerTiposMulta();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TipoMulta tipo = new TipoMulta();
            tipo.ID = Convert.ToInt32(txtID.Text);
            tipo.Tipo = txtDesc.Text;
            tipo.Precio = Convert.ToInt32(txtMonto.Text);

            tipoBll.Actualizar(tipo);

            ObtenerTiposMulta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TipoMulta tipo = new TipoMulta();
            tipo.ID = Convert.ToInt32(txtID.Text);

            tipoBll.Eliminar(tipo);

            ObtenerTiposMulta();
        }

        private void ObtenerTiposMulta()
        {
            List<TipoMulta> tiposMulta = new List<TipoMulta>();
            tiposMulta = tipoBll.ObtenerTiposMulta();

            dgvTiposMulta.DataSource = null;
            dgvTiposMulta.DataSource = tiposMulta;
        }

        private void TiposMulta_Load(object sender, EventArgs e)
        {
            ObtenerTiposMulta();
        }

        private void dgvTiposMulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TipoMulta tipo = new TipoMulta();
            tipo.ID = Convert.ToInt32(dgvTiposMulta.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            tipo.Tipo = dgvTiposMulta.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
            tipo.Precio = Convert.ToInt32(dgvTiposMulta.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

            txtID.Text = tipo.ID.ToString();
            txtDesc.Text = tipo.Tipo;
            txtMonto.Text = tipo.Precio.ToString();

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
