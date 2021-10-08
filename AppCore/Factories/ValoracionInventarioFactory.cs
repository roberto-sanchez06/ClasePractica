using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces.Productos;
using AppCore.Processes.ValoracionInventario;
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
                    return new InventarioPEPS();
                    break;
                case TipoValorInventario.Ueps:
                    return new InventarioUEPS();
                    break;
                case TipoValorInventario.PromedioSimple:
                    return new InventarioPromSimple();
                    break;
                case TipoValorInventario.PromedioPonderado:
                    return new InventarioPromPonderado();
                    break;
            }
            return null;
        }
    }
}
