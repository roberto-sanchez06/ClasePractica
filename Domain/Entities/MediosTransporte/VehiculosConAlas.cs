using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class VehiculosConAlas : Aereos
    {
        public decimal TamanoAlas { get; set; }
        public VehiculosConAlas(decimal alturaMax,decimal tamanoAlas) : base(alturaMax)
        {
            TamanoAlas = tamanoAlas;
        }
    }
}
