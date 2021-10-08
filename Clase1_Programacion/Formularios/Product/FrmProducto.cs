using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Enums.Producto;
using Domain.Entities.Producto;

namespace Clase1_Programacion.Formularios.Product
{
    public partial class FrmProducto : Form
    {
        public IProductoService productoS { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbUniMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = productoS.GetLastProductoId() + 1,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudCantidad.Value,
                Precio = nudPrecio.Value,
                FechaVencimiento = dtpCaducidad.Value,
                UnidadMedida = (UnidadMedida)cmbUniMedida.SelectedIndex,
                //pongo esto para probar
                FechaAdquisicon=DateTime.Now
            };
            productoS.Create(p);
            Dispose();
        }
    }
}
