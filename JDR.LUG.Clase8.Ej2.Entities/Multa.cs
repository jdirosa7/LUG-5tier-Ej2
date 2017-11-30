using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej2.Entities
{
    public class Multa
    {
        public int ID { get; set; }
        public string Lugar { get; set; }
        public int IDTipo { get; set; }
        public int Valor { get; set; }
        public string Patente { get; set;}
    }
}
