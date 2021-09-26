﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Empleado
{
    public abstract class Empleado
    {
        //el id puede ser string 
        protected int Codigo { get; set; }
        protected string Nombres { get; set; }
        protected string Apellidos { get; set; }
        protected Cargo Cargo { get; set; }
        protected string NumeroIdentificacion { get; set; }
        protected decimal Salario { get; set; }
        protected Empleado(int codigo, string nombres, string apellidos, string numeroIdentificacion, decimal salario)
        {
            Codigo = codigo;
            Nombres = nombres;
            Apellidos = apellidos;
            NumeroIdentificacion = numeroIdentificacion;
            Salario = salario;
        }

        public abstract string PrintEmpleado();
        public abstract decimal CalculoSalario();
        public virtual string PrintEmpleado2()
        {
            return $"Codigo{ Codigo }";
        }
    }
}
