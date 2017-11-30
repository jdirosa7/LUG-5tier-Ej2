using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej2.Entities;
using System.Collections;
using JDR.LUG.Clase8.Ej2.DAL;
using System.Data;

namespace JDR.LUG.Clase8.Ej2.Mapper
{
    public class TipoMultaMPP
    {
        Datos data = new Datos();

        public void InsertarActualizar(TipoMulta tipo)
        {
            Hashtable table = new Hashtable();
            string store = "s_InsertarTipoMulta";

            if (tipo.ID != 0)
            {
                store = "s_ActualizarTipoMulta";
                table.Add("@IDTipoMulta", tipo.ID);
            }

            table.Add("@Descripcion", tipo.Tipo);
            table.Add("@Precio", tipo.Precio);

            data.Escribir(store, table);
        }

        public void Eliminar(TipoMulta tipo)
        {
            Hashtable table = new Hashtable();
            string store = "s_EliminarTipoMulta";

            table.Add("@IDTipoMulta", tipo.ID);

            data.Escribir(store, table);
        }        

        public List<TipoMulta> ObtenerTiposMulta()
        {
            List<TipoMulta> tiposMulta = new List<TipoMulta>();
            DataTable dt = new DataTable();

            string store = "s_ObtenerTiposMulta";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TipoMulta tipo = new TipoMulta();
                    tipo.ID = Convert.ToInt32(row["IDTipoMulta"].ToString());
                    tipo.Tipo = row["Descripcion"].ToString();
                    tipo.Precio = Convert.ToInt32(row["Precio"].ToString());

                    tiposMulta.Add(tipo);
                }
            }

            return tiposMulta;
        }
    }
}
