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
using Domain.Entities.Producto;

namespace Clase1_Programacion.Formularios.Product
{
    public partial class FrmInventarioViewer : Form
    {
        public IProductoService productoServ { get; set; }
        public FrmInventarioViewer()
        {
            InitializeComponent();
        }

        private void InventarioViewer_Load(object sender, EventArgs e)
        {
            richTextBox1.Text= productoServ.GetProductosAsJson();
        }
    }
}
