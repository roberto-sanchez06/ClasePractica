using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioUEPS : ValoracionInventario
    {
       
        public override decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos.FindAll()[productos.FindAll().Length-1].Existencia)
            {
                throw new ArgumentException("Las salidas son mayores a las ultimas unidades que ingresaron de ultimo");
            }
            decimal valor = productos.FindAll()[productos.FindAll().Length - 1].Precio;
            
            Eliminar(ref productos, salida);
            return valor;
        }

        public override void Eliminar(ref IProductoService prod, int salida)
        {
           
            while (prod.FindAll()[prod.FindAll().Length-1].Existencia < salida)
            {
                salida -= prod.FindAll()[prod.FindAll().Length - 1].Existencia;
                prod.Delete(prod.FindAll()[prod.FindAll().Length - 1]);
            }
            prod.FindAll()[prod.FindAll().Length - 1].Existencia -= salida;
            if (prod.FindAll()[prod.FindAll().Length - 1].Existencia == 0)
            {
                prod.Delete(prod.FindAll()[prod.FindAll().Length - 1]);
            }
        }
    }
}
