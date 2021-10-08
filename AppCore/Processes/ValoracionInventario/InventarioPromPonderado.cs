using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPromPonderado : ValoracionInventario
    {
       
        public override decimal CalcularValorInventario(int salida, ref IProductoService productos)
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
       
        
    }
}
