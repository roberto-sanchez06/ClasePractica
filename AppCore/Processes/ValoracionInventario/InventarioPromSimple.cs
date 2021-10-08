using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPromSimple : ValoracionInventario
    {
        public override decimal CalcularValorInventario(int salida, ref IProductoService productos)
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

        
    }
}
