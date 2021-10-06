using Domain.Entities.Empleado2;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class EmpleadoModel : IEmpleadoModel
    {
        private Empleado[] empleados;
        public void Create(Empleado e)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                return;
            }
            Empleado[] tmp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados, tmp, empleados.Length);
            tmp[tmp.Length - 1] = e;
            empleados = tmp;
        }

        public bool Delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado[] FindAll()
        {
            return empleados;
        }

        public Empleado FindById(int codigo)
        {
            throw new NotImplementedException();
        }

        public int GetLastEmpleadoId()
        {
            //cambiar getLasEmpleadoId
            return (empleados == null) ? 0 : empleados[empleados.Length - 1].Id;
        }

        public int Update(Empleado t)
        {
            throw new NotImplementedException();
        }
    }
}
