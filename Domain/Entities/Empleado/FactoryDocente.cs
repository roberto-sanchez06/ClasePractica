using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public class FactoryDocente : Factory
    {
        public override Employee FacthoryMethod(int codigo, string nombres, string apellidos, string nid, decimal salario, AtributosEmpleados atributos) {
            return new EmpleadoDocente(codigo, nombres, apellidos, nid, salario, atributos);    
        }
    }
}
