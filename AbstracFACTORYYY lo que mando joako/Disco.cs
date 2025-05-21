using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFACTORYYY_lo_que_mando_joako
{
    public abstract class Disco
    {
        public string Capacidad { get; }
        public string Precio { get; }

        public Disco(string capacidad, string precio)
        {
            Capacidad = capacidad;
            Precio = precio;
        }
    }
}