using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService:IService<Empleado>
    {
        Empleado FindById(int codigo);
        int GetLastEmpleadoId();
    }
}
