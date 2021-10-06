using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Clase1_Programacion.Formularios;
using Clase1_Programacion.Formularios.Product;
using Domain.Interfaces;
using Infraestructure;
using Infraestructure.ProductoModel;

namespace Clase1_Programacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmpleadoModel>().As<IEmpleadoModel>();
            builder.RegisterType<EmpleadoService>().As<IEmpleadoService>();

            //aqui empiezan los cambios
            builder.RegisterType<ProductoModel>().As<IProductoModel>();
            builder.RegisterType<ProductoService>().As<IProductoService>();
            //terminan cambios 
           
            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProductosManager(container.Resolve<IProductoService>()));
        }
    }
}
