using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class VehiculoLiviano : Terrestre
    {
        public int NumeroPuertas { get; set; }
        public VehiculoLiviano(string marca, String modelo, int numPuertas) : base(marca, modelo)
        {
            NumeroPuertas = numPuertas;
        }
        public VehiculoLiviano(string marca, string modelo, Transmision transmision) : base(marca, modelo)
        {
            Transmision = transmision;
        }
    }
}
