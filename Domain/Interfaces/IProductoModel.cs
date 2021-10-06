using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Producto;
using Domain.Enums.Producto;

namespace Domain.Interfaces
{
    public interface IProductoModel : IModel<Producto>
    {
        Producto GetProductoById(int codigo);
        Producto[] GetProductosByUnidadMedida(UnidadMedida um);
        Producto[] GetProductosByFechaVencimiento(DateTime dt);
        Producto[] GetProductosByRangoPrecio(decimal start, decimal end);
        string GetProductosAsJson();
        int GetLastProductoId();
        Producto[] GetProductosOrderByPrecio();
    }
}
