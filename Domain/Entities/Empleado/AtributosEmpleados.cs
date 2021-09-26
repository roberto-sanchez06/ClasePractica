using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public class AtributosEmpleados
    {
        public TipoContratacion TipoContratacion { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
    }
}
