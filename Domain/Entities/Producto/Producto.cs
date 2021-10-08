using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums.Producto;

namespace Domain.Entities.Producto
{
    public class Producto
    {
        //agregue fecha de adquisicion
        public DateTime FechaAdquisicon { get; set; }
        //
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if (x.Precio < y.Precio)
                {
                    return -1;
                }
                else if (x.Precio > y.Precio)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class ProductoCompareFechaAdq : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return x.FechaAdquisicon.CompareTo(y.FechaAdquisicon);
            }
        }
        public string MostrarDatos()
        {
            return string.Format("{0,-5:d} {1,20:d} {2,10: d} {3,20:f} {4,20:f} \n",
                            $"{Id}", $"{FechaAdquisicon}", $"{Existencia}", $"{Precio}", $"{ Precio*Existencia }");
        }
    }
}
