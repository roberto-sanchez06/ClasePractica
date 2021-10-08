using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPromPonderado : IValoracionInventario
    {
       
        public decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            decimal valor=CalcularCostoTotal(productos) / TotalProductos(productos);
            Eliminar(ref productos, salida);
            return valor;
        }
        private decimal CalcularCostoTotal(IProductoService prod)
        {
            decimal suma = 0;
            foreach(Producto p in prod.FindAll())
            {
                suma += p.Precio * p.Existencia;
            }
            return suma;
        }
        private int TotalProductos(IProductoService prod)
        {
            int suma = 0;
            foreach (Producto p in prod.FindAll())
            {
                suma += p.Existencia;
            }
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
            if (prod.FindAll()[0].Existencia == 0)
            {
                prod.Delete(prod.FindAll()[0]);
                Array.Sort(prod.FindAll(), new Producto.ProductoCompareFechaAdq());
            }
        }
    }
}
