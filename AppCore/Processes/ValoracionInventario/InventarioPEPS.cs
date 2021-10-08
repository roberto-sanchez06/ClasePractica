using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPEPS : IValoracionInventario
    {
        // no se ocupo nada de salida
        public decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos.FindAll()[0].Existencia)
            {
                throw new ArgumentException("Las salidas son menores a las primeras unidades que ingresaron, para evitar incovenientes divida las salidas en la cantidad que haga falta");
            }
            decimal valor = productos.FindAll()[0].Precio;
            Eliminar(ref productos, salida);
            return valor;
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
