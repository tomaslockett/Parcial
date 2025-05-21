using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Factory
{
    public class CamionDiesel : ICamion
    {
        public void Conducir()
        {
            Console.WriteLine("BRBRBRBRRBRBRRBRRRRRBR SOY UN CAMION A DIESEL, QUE RUIDO LA PUTA MADRE 🚚");
        }
    }
}