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
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El empleado con id {t.Id} no se encuentra.");
            }

            if (index != empleados.Length - 1)
            {
                empleados[index] = empleados[empleados.Length - 1];
            }

            Empleado[] tmp = new Empleado[empleados.Length - 1];
            Array.Copy(empleados, tmp, tmp.Length);
            empleados = tmp;

            return empleados.Length == tmp.Length;
        }

        public Empleado[] FindAll()
        {
            return empleados;
        }

        public Empleado FindById(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentException($"El Id: {codigo} no es valido.");
            }

            int index = GetIndexById(codigo);

            return index <= 0 ? null : empleados[index];
        }
        public int GetLastEmpleadoId()
        {
            try
            {
                return (empleados == null) ? 0 : empleados[empleados.Length - 1].Id;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }

        public int Update(Empleado t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            empleados[index] = t;
            return index;
        }

        #region private methods
        // este metodo se podria hacer de otra forma y podria ser tambien de la interfaz
        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (empleados == null)
            {
                return index;
            }

            foreach (Empleado p in empleados)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }
        #endregion
    }
}
