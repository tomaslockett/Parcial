using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFACTORYYY_lo_que_mando_joako
{
    public class BluRayFactory : IFactory
    {
        public Disco CrearDiscodoble()
        {
            return new DiscoDoble("50 GB", "30.00");
        }

        public Disco CrearDiscosimple()
        {
            return new DiscoSimple("25 GB", "15.00");
        }
    }
}