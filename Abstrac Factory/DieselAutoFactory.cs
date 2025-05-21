using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Factory
{
    public class DieselFactory : IVehiculoFactory
    {
        public IAuto CrearAuto()
        {
            return new AutoDiesel();
        }

        public ICamion CrearCamion()
        {
            return new CamionDiesel();
        }
    }
}