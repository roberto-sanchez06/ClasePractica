using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Empleado
{
    public class EmpleadoAdministrativo : Employee
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public int HorasExtras { get; set; }
        public EmpleadoAdministrativo(int codigo, string nombres, string apellidos, string nid, decimal salario) 
            : base (codigo, nombres, apellidos, nid, salario)
        {
            
        }
        public EmpleadoAdministrativo(int codigo, string nombres, string apellidos, string nid, decimal salario, AtributosEmpleados atributos) 
            : base(codigo, nombres, apellidos, nid, salario)
        {
            HoraEntrada = atributos.Entrada;
            HoraSalida = atributos.Salida;
            HorasExtras = CalculoHorasExtras();
        }

        public int CalculoHorasExtras()
        {
            int hrsExtras = (HoraSalida - HoraEntrada).Hours-8;
            if (hrsExtras > 3 || hrsExtras<1)
            {
                throw new ArgumentException("Las horas extras de un dia no pueden ser mayores a 3 o menores a 1");
            }
            return hrsExtras;
        }
        public override decimal CalculoSalario()
        {
            decimal salarioHr = Salario / 160;
            decimal salarioHrsExtras = salarioHr * HorasExtras;
            return Salario + salarioHrsExtras;
        }

        //METODO CREADO EN CLASE
        public override string PrintEmpleado()
        {
            return $"Hora de entrada: {HoraEntrada}, Hora de salida: {HoraSalida}";
        }
    }
}
