using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Interfaces.Productos;
using Domain.Entities.Producto;

namespace AppCore.Processes.ValoracionInventario
{
    public class InventarioPEPS : ValoracionInventario
    {
       
        public override decimal CalcularValorInventario(int salida, ref IProductoService productos)
        {
            if (productos.FindAll() == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos.FindAll()[0].Existencia)
            {
                throw new ArgumentException("Las salidas son menores a las primeras unidades que ingresaron");
            }
            decimal valor = productos.FindAll()[0].Precio;
            Eliminar(ref productos, salida);
            return valor;
        }

        
    }
}
