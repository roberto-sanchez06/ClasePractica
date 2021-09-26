using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class VehiculoConHelices : Aereos
    {
        public int NumHelices { get; set; }
        public VehiculoConHelices(decimal alturaMax, int numHelices) : base(alturaMax)
        {
            NumHelices = numHelices;
        }
    }
}
