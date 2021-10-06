using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public class EmpleadoDocente : Employee
    {
        public TipoContratacion TipoContratacion { get; set; }
        public EmpleadoDocente(int codigo, string nombres, string apellidos, string nid, decimal salario) 
            : base(codigo, nombres, apellidos, nid, salario)
        {

        }

        public EmpleadoDocente(int codigo, string nombres, string apellidos, string nid, decimal salario,  AtributosEmpleados atributos) 
            : base(codigo, nombres, apellidos, nid, salario)
        {
            TipoContratacion = atributos.TipoContratacion;
        }

        public override decimal CalculoSalario()
        {
            return Salario;
        }
        public override string PrintEmpleado()
        {
            return $"Codigo: {Codigo}, Nombres: {Nombres}, Apellidos: {Apellidos}, Cedula: {NumeroIdentificacion}";
        }
        public override string PrintEmpleado2()
        {
            return $"{base.PrintEmpleado2()}, Nombres{Nombres}";
        }
    }
}
