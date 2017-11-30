using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej2.Entities;
using JDR.LUG.Clase8.Ej2.DAL;
using System.Data;
using System.Collections;

namespace JDR.LUG.Clase8.Ej2.Mapper
{
    public class MultaMPP
    {
        Datos data = new Datos();

        public void Insertar(Multa m)
        {
            Hashtable table = new Hashtable();
            string store = "s_InsertarMulta";

            table.Add("@Lugar", m.Lugar);
            table.Add("@Patente", m.Patente);
            table.Add("@Valor", m.Valor);
            table.Add("@IDTipoMulta", m.IDTipo);

            data.Escribir(store, table);                     
        }

        public List<Multa> ObtenerMultas()
        {
            List<Multa> multas = new List<Multa>();
            DataTable dt = new DataTable();

            string store = "s_ObtenerMultas";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Multa m = new Multa();
                    m.ID = Convert.ToInt32(row["IDMulta"].ToString());
                    m.IDTipo = Convert.ToInt32(row["IDTipoMulta"].ToString());
                    m.Lugar = row["Lugar"].ToString();
                    m.Patente = row["Patente"].ToString();
                    m.Valor = Convert.ToInt32(row["Monto"].ToString());

                    multas.Add(m);
                }
            }

            return multas;
        }        
    }
}
