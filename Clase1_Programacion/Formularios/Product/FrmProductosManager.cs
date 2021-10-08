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

namespace Clase1_Programacion.Formularios.Product
{
    public partial class FrmProductosManager : Form
    {
        IProductoService productoService;
        public FrmProductosManager(IProductoService productoService)
        {
            this.productoService = productoService;
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.productoS = productoService;
            frmProducto.ShowDialog();

            rtbProductViewer.Text = productoService.GetProductosAsJson();
        }

        private void FrmProductosManager_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.productoS = productoService;
            frmProducto.ShowDialog();
        }
    }
}
