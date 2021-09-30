using Domain.Entities.Empleado2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class EmpleadoModel
    {
        private Empleado2[] empleados;
        public void Add(Empleado2 e)
        {
            if (empleados == null)
            {
                empleados = new Empleado2[1];
                empleados[0] = e;
                return;
            }
            Empleado2[] tmp = new Empleado2[empleados.Length + 1];
            Array.Copy(empleados, tmp, empleados.Length);
            tmp[tmp.Length - 1] = e;
            empleados = tmp;
        }
        public Empleado2[] GetEmpleado2s()
        {
            return empleados;
        }
        public int GetLastEmpleadoId()
        {
            //cambiar getLasEmpleadoId
            return (empleados == null) ? 0 : empleados[empleados.Length - 1].Id;
        }
    }
}
