using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Interfaces;
using Domain.Entities.Empleado2;
using Domain.Interfaces;

namespace CoreApp.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoModel empleadoModel;
        public EmpleadoService(IEmpleadoModel empleadoModel)
        {
            this.empleadoModel = empleadoModel;
        }
        public void Create(Empleado t)
        {
            empleadoModel.Create(t);
        }

        public bool Delete(Empleado t)
        {
            return empleadoModel.Delete(t);
        }

        public Empleado[] FindAll()
        {
            return empleadoModel.FindAll();
        }

        public Empleado FindById(int codigo)
        {
            return empleadoModel.FindById(codigo);
        }

        public int GetLastEmpleadoId()
        {
            return empleadoModel.GetLastEmpleadoId();
        }

        public int Update(Empleado t)
        {
            return empleadoModel.Update(t);
        }
    }
}
