using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces.Producto;
using Domain.Enums.Producto;

namespace AppCore.Factories
{
    public class ValoracionInventarioFactory
    {
        public IValoracionInventario CrearInstancia(TipoValorInventario tipo)
        {
            switch (tipo)
            {
                case TipoValorInventario.Peps:
                    break;
                case TipoValorInventario.Ueps:
                    break;
                case TipoValorInventario.PromedioSimple:
                    break;
                case TipoValorInventario.PromedioPonderado:
                    break;
            }
            return null;
        }
    }
}
