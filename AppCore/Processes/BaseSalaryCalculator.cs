using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Empleado2;

namespace AppCore.Processes
{
    //desde aqui repasar tambien
    public abstract class BaseSalaryCalculator : IBaseSalaryCalculator
    {
        private decimal InssRate => 0.07M;

        private TarifaIR[] tarifaIRs = new TarifaIR[]
        {
            new TarifaIR(){ Desde=0.01M, Hasta=100000, ImpuestoBase=0, PorcentajeAplicable=0, SobreExceso=0},
            new TarifaIR(){ Desde=100000.01M, Hasta=200000, ImpuestoBase=0, PorcentajeAplicable=0.15M, SobreExceso=100000},
            new TarifaIR(){ Desde=200000.01M, Hasta=350000, ImpuestoBase=15000, PorcentajeAplicable=0.20M, SobreExceso=200000},
            new TarifaIR(){ Desde=350000.01M, Hasta=500000, ImpuestoBase=45000, PorcentajeAplicable=0.25M, SobreExceso=350000},
            new TarifaIR(){ Desde=500000.01M, Hasta=5000000, ImpuestoBase=87500, PorcentajeAplicable=0.30M, SobreExceso=500000},
        };
        public abstract decimal CalculateSalary(Empleado t);
        public decimal CalculateIR(decimal annualSalary)
        {
            decimal ir = decimal.MinValue;
            foreach (TarifaIR tarifaIr in tarifaIRs)
            {
                //repasar estas lineas de codigo
                if ((annualSalary - tarifaIr.Desde) * (tarifaIr.Hasta - annualSalary) >= 0)
                {
                    ir = ((((annualSalary - tarifaIr.SobreExceso) * tarifaIr.PorcentajeAplicable) + tarifaIr.ImpuestoBase) / 12);
                    break;
                }
            }
            return ir;
        }
        public decimal CalculateAnnualSalary(decimal salary)
        {
            return salary * 12;
        }
        public decimal CalculateInss(decimal salary)
        {
            return salary * InssRate;
        }
    }
}
