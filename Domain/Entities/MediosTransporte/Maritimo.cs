using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Maritimo : MediosDeTransporte
    {
        //RELLENAR MARITIMO
        //enum

        public Funcionamiento Funcionamiento { get; set; }
        public Maritimo(Funcionamiento func)
        {
            Funcionamiento = func;
        }
    }
}
