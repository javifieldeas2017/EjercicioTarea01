using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarea01
{
    public class ClaseDatos
    {
        public string texto { get; set; }
        public int a { get; set; } 
        public int b { get; set; }

    }

    public class ClaseLogica
    {
        public string ConcatenarAtributos(ClaseDatos obj)
        {
            string cadena = obj.texto+ "-" + obj.a + "-" + obj.b;
            return cadena;
        }
    }
}
