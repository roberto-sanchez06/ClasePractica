using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Empleado2
{
    public class Docente : Empleado
    {
        public CategoriaDocente CategoriaDocente;
        public Docente(int codigo, string cedula, string nombres, string apellidos, decimal salario, DateTime fechaContratacion) : 
            base(codigo, cedula, nombres, apellidos, salario, fechaContratacion)
        {
        }
        public override string GetEmpleadoAsString()
        {
            return string.Format("{0,5:d} {1,20} {2,20}, {3,20} {4,7: F} {2,20:d} {6,20}", $"{Codigo}", $"{Cedula}", $"{Nombres}", $"{Apellidos}", $"{Salario}", $"{FechaContratacion}", $"{ CategoriaDocente}\n");
        }
    }
}
