using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracFACTORYYY_lo_que_mando_joako
{
    public interface IFactory
    {
        public Disco CrearDiscosimple();

        public Disco CrearDiscodoble();
    }
}