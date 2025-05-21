using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Factory
{
    internal class AutoPetroleo : IAuto
    {
        public void Conducir()
        {
            Console.WriteLine("brbrbrbrbbr soy un auto a nafta :D 🚗");
        }
    }
}