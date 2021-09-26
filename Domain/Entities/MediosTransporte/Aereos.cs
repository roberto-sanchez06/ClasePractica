using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aereos : MediosDeTransporte
    {
        //RELLENAR AEREOS
        public decimal AlturaMax { get; set; }
        public Aereos(decimal alturaMax)
        {
            AlturaMax = alturaMax;
        }
    }
}
