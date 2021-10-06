using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Empleado2
{
    public abstract class Empleado
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        protected Empleado(int codigo, string cedula ,string nombres, string apellidos, decimal salario, DateTime fechaContratacion)
        {
            Cedula = cedula;
            Codigo = codigo;
            Nombres = nombres;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = FechaContratacion;
        }
        public abstract string GetEmpleadoAsString();
    }
}
