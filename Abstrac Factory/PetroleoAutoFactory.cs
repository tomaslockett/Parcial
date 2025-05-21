using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Factory
{
    public class PetroleoFactory : IVehiculoFactory
    {
        public IAuto CrearAuto()
        {
            return new AutoPetroleo();
        }

        public ICamion CrearCamion()
        {
            return new CamionPetroleo();
        }
    }
}