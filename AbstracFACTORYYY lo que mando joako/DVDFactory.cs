using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFACTORYYY_lo_que_mando_joako
{
    public class DVDFactory : IFactory
    {
        public Disco CrearDiscodoble()
        {
            return new DiscoDoble("8.5 GB", "20.00");
        }

        public Disco CrearDiscosimple()
        {
            return new DiscoSimple("4.7 GB", "10.00");
        }
    }
}