using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Factory
{
    public interface IVehiculoFactory
    {
        IAuto CrearAuto();
    }
}