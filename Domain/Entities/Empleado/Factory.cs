using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public abstract class Factory
    {
        public abstract Employee FacthoryMethod(int codigo, string nombres, string apellidos, string nid, decimal salario, AtributosEmpleados atributos);
        public virtual string MostrarSalarioNeto(int codigo, string nombres, string apellidos, string nid, decimal salario, AtributosEmpleados atributos)
        {
            Employee emp = FacthoryMethod(codigo, nombres, apellidos, nid, salario, atributos);
            return $"El salario neto mensual del empleado es: {emp.CalculoSalario()}";
        }
    }
}
