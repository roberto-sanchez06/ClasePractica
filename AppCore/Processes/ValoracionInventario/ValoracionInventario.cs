using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;
using Domain.Interfaces;

namespace AppCore.Processes.ValoracionInventario
{
    public abstract class ValoracionInventario : IValoracionInventario
    {
        public abstract decimal CalcularValorInventario(int salida, ref IProductoService productos);
        public virtual void Eliminar(ref IProductoService prod, int salida)
        {
            //aqui se puede escribir el metodo como virtual para despues invalidarlo
            throw new NotImplementedException();
        }
    }
}
