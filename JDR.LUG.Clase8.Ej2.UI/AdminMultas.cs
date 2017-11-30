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
    public partial class AdminMultas : Form
    {
        MultaBLL mBll = new MultaBLL();
        TipoMultaBLL tipoBll = new TipoMultaBLL();
        public AdminMultas()
        {
            InitializeComponent();
        }

        private void btnGenerarMulta_Click(object sender, EventArgs e)
        {
            Multa m = new Multa();
            TipoMulta tipoMulta = ObtenerTipoMultaPorNombre(cbTiposMulta.Text);
            m.IDTipo = tipoMulta.ID;
            m.Lugar = txtLugar.Text;
            m.Patente = txtPatente.Text;
            m.Valor = Convert.ToInt32(txtMonto.Text);

            mBll.Insertar(m);
        }

        private TipoMulta ObtenerTipoMultaPorNombre(string nombre)
        {
            TipoMulta tipo = new TipoMulta();

            tipo = tipoBll.ObtenerTipoMultaPorNombre(nombre);

            return tipo;
        }

        private void AdminMultas_Load(object sender, EventArgs e)
        {
            ObtenerTiposMulta();
        }

        private void ObtenerTiposMulta()
        {
            List<TipoMulta> tiposMulta = new List<TipoMulta>();

            tiposMulta = tipoBll.ObtenerTiposMulta();

            List<string> tipos = new List<string>();

            foreach (TipoMulta tipo in tiposMulta)
            {
                tipos.Add(tipo.Tipo);
            }

            cbTiposMulta.DataSource = null;
            cbTiposMulta.DataSource = tipos;
        }

        private void cbTiposMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoMulta = cbTiposMulta.SelectedItem.ToString();
            TipoMulta tipo = ObtenerTipoMultaPorNombre(tipoMulta);

            txtMonto.Text = tipo.Precio.ToString();
        }
    }
}
