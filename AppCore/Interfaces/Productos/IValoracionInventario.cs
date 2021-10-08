using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Services;
using Domain.Entities.Producto;

namespace AppCore.Interfaces.Productos
{
    public interface IValoracionInventario
    {
        decimal CalcularValorInventario(int salida, ref IProductoService productos);
        //decimal CalcularValorInventario(ProductoService[] ent);
        void Eliminar(ref IProductoService prod, int salida);
    }
}
