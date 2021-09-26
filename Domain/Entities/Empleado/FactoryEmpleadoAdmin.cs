using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public class FactoryEmpleadoAdmin : Factory
    {
        public override Empleado FacthoryMethod(int codigo, string nombres, string apellidos, string nid, decimal salario, AtributosEmpleados atributos)
        {
            return new EmpleadoAdministrativo(codigo, nombres, apellidos, nid, salario, atributos);
        }
    }
}
