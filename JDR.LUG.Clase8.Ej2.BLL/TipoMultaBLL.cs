using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej2.Entities;
using JDR.LUG.Clase8.Ej2.Mapper;

namespace JDR.LUG.Clase8.Ej2.BLL
{
    public class TipoMultaBLL
    {
        TipoMultaMPP tipoMpp = new TipoMultaMPP();
        public void Insertar(TipoMulta tipo)
        {
            tipoMpp.InsertarActualizar(tipo);
        }

        public void Actualizar(TipoMulta tipo)
        {
            tipoMpp.InsertarActualizar(tipo);
        }

        public void Eliminar(TipoMulta tipo)
        {
            tipoMpp.Eliminar(tipo);
        }

        public List<TipoMulta> ObtenerTiposMulta()
        {
            List<TipoMulta> tiposMulta = new List<TipoMulta>();
            tiposMulta = tipoMpp.ObtenerTiposMulta();
            return tiposMulta;
        }

        public TipoMulta ObtenerTipoMultaPorNombre(string nombre)
        {
            TipoMulta tipo = new TipoMulta();
            List<TipoMulta> tipos = tipoMpp.ObtenerTiposMulta();

            if(tipos != null && tipos.Count > 0)
            {
                foreach (TipoMulta item in tipos)
                {
                    if (item.Tipo.Equals(nombre))
                    {
                        tipo = item;
                        break;
                    }
                }
            }

            return tipo;
        }
    }
}
