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
            while (prod.FindAll()[0].Existencia < salida)
            {
                salida -= prod.FindAll()[0].Existencia;
                prod.Delete(prod.FindAll()[0]);
                Array.Sort(prod.FindAll(), new Producto.ProductoCompareFechaAdq());
            }
            prod.FindAll()[0].Existencia -= salida;
            if (prod.FindAll()[0].Existencia == 0)
            {
                prod.Delete(prod.FindAll()[0]);
                Array.Sort(prod.FindAll(), new Producto.ProductoCompareFechaAdq());
            }

        }
    }
}
