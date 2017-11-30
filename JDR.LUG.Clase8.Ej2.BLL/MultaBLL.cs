using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej2.Entities;
using JDR.LUG.Clase8.Ej2.Mapper;

namespace JDR.LUG.Clase8.Ej2.BLL
{
    public class MultaBLL
    {
        MultaMPP multaMpp = new MultaMPP();
        public void Insertar(Multa m)
        {
            multaMpp.Insertar(m);
        }
        public List<Multa> ObtenerMultas()
        {
            List<Multa> multas = new List<Multa>();

            multas = multaMpp.ObtenerMultas();

            return multas;
        }        
    }
}
