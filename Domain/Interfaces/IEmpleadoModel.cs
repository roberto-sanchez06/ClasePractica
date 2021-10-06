using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleado2;

namespace Domain.Interfaces
{
    public interface IEmpleadoModel : IModel<Empleado>
    {
        //el metodo findbyId bien podria ser de la interfaz IModel
        Empleado FindById(int codigo);
        int GetLastEmpleadoId();
    }
}
