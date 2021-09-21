using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Programacion
{
    public class VehiculoPesado : Terrestre
    {
        public int NumeroLlantas { get; set; }
        public VehiculoPesado(string marca, string modelo, int numLlantas) : base(marca, modelo)
        {
            NumeroLlantas = numLlantas;
        }
    }
}
