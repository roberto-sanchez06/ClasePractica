using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace Domain.Interfaces
{
    public interface IEmpleadoModel : IModel<Empleado>
    {
        Empleado FindById(int codigo);
        int GetLastEmpleadoId();
    }
}
