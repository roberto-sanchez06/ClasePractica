using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace AppCore.Processes
{
    public class DocenteSalaryCalculator : BaseSalaryCalculator
    {
        public override decimal CalculateSalary(Empleado empleado)
        {
            decimal inss = base.CalculateInss(empleado.Salario);
            decimal annualSalary = base.CalculateAnnualSalary(empleado.Salario-inss);
            decimal ir = base.CalculateIR(annualSalary);
            return empleado.Salario - inss - ir;
        }
    }
}
