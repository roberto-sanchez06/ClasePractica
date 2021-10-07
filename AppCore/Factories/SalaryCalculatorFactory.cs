using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Processes;
using Domain.Entities.Empleado2;

namespace AppCore.Factories
{
    public class SalaryCalculatorFactory
    {
        //private Docente docente;
        //private Administrativo administrativo;
        public IBaseSalaryCalculator CreateInstance(Empleado empleado)
        {
            if(empleado is Docente)
            {
                return new DocenteSalaryCalculator();
            }
            else if(empleado is Administrativo)
            {
                return new AdministrativoSalaryCalculator();
            }
            return null;
        }
    }
}
