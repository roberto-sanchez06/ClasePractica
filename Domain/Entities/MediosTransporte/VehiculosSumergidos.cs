using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities
{
    public class VehiculosSumergidos : Maritimo
    {
        public decimal ProfundidadMax { get; set; }
        public VehiculosSumergidos(Funcionamiento func,decimal profMax): base(func) 
        {
            ProfundidadMax = profMax;
        }
    }
}
