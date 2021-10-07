using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace AppCore.Interfaces
{
    public interface IBaseSalaryCalculator
    {
        decimal CalculateSalary(Empleado t);
    }
}
