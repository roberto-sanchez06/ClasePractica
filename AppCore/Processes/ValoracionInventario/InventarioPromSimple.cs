using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPromSimple : IValoracionInventario
    {
        public decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            decimal suma=0;
            foreach (Producto p in productos.FindAll())
            {
                suma += p.Precio;
            }
            suma/= productos.FindAll().Length;
            Eliminar(ref productos, salida);
            return suma;
        }

        public void Eliminar(ref IProductoService prod, int salida)
        {
            while (prod.FindAll()[0].Existencia < salida)
            {
                salida -= prod.FindAll()[0].Existencia;
                prod.Delete(prod.FindAll()[0]);
                Array.Sort(prod.FindAll(), new Producto.ProductoCompareFechaAdq());
            }
            prod.FindAll()[0].Existencia -= salida;
            if(prod.FindAll()[0].Existencia == 0)
            {
                prod.Delete(prod.FindAll()[0]);
                Array.Sort(prod.FindAll(), new Producto.ProductoCompareFechaAdq());
            }
        }
    }
}
