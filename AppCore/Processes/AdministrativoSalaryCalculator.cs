using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace AppCore.Processes
{
    public class AdministrativoSalaryCalculator : BaseSalaryCalculator
    {
        private float MonthHours => 160;
        public override decimal CalculateSalary(Empleado empleado)
        {
            decimal newSalary = empleado.Salario + ExtraHourSalary(((Administrativo)empleado).HorasExtras, 
                SalaryPerHour(empleado.Salario));
            decimal inss = base.CalculateInss(newSalary);
            decimal annualSalary = base.CalculateAnnualSalary(newSalary - inss);
            decimal ir = base.CalculateIR(annualSalary);
            return newSalary - inss - ir;
        }
        private decimal ExtraHourSalary(float hrs, decimal salaryPerHour)
        {
            return (decimal)hrs * salaryPerHour;
        }
        private decimal SalaryPerHour(decimal salary)
        {
            return salary / (decimal)MonthHours;
        }
    }
}
