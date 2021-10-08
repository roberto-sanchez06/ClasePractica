using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioUEPS : IValoracionInventario
    {
        public decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos.FindAll()[productos.FindAll().Length-1].Existencia)
            {
                throw new ArgumentException("Las salidas son menores a las ultimas unidades que ingresaron, para evitar incovenientes divida las salidas en la cantidad que haga falta");
            }
            decimal valor = productos.FindAll()[productos.FindAll().Length - 1].Precio;
            
            Eliminar(ref productos, salida);
            return valor;
        }

        public void Eliminar(ref IProductoService prod, int salida)
        {
            //lo primero creo que ni es necesario al igual que en pep
            while (prod.FindAll()[prod.FindAll().Length-1].Existencia < salida)
            {
                salida -= prod.FindAll()[0].Existencia;
                prod.Delete(prod.FindAll()[prod.FindAll().Length - 1]);
            }
            prod.FindAll()[prod.FindAll().Length - 1].Existencia -= salida;
            if (prod.FindAll()[0].Existencia == 0)
            {
                prod.Delete(prod.FindAll()[prod.FindAll().Length - 1]);
            }
        }
    }
}
