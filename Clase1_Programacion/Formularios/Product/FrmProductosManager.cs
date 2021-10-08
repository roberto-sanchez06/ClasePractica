using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Factories;
using AppCore.Interfaces;
using Domain.Entities.Producto;
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

       

        private void FrmProductosManager_Load(object sender, EventArgs e)
        {
            
            cmbValoracion.Items.AddRange(Enum.GetValues(typeof(TipoValorInventario))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            //Producto[] productos = productoService.FindAll();
            //if (productoService == null)
            //{
            //    rtbProductViewer.Text = "No hay elementos a encontrar";
            //    return;
            //}
            //rtbProductViewer.Text = "";
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.productoS = productoService;
            frmProducto.ShowDialog();
            if (productoService == null)
            {
                rtbProductViewer.Text = "No hay elementos a encontrar";
                return;
            }
            rtbProductViewer.Text=string.Format("{0,-5:d} {1,20:d} {2,20: d} {3,20:f} {4,20:f} \n",
                            "Id", "Fecha", "Cant", "Costo Uni", "Costo Total");
            foreach (Producto p in productoService.FindAll())
            {
                rtbProductViewer.AppendText(p.MostrarDatos());
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (cmbValoracion.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningun metodo de valoracion de inventario","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            int salida = (int)nudSalida.Value;
            ValoracionInventarioFactory factory = new ValoracionInventarioFactory();
            decimal precio=factory.CrearInstancia((TipoValorInventario)cmbValoracion.SelectedIndex).CalcularValorInventario(salida, ref productoService);
            rtbSalidas.AppendText("el precio de la salida es: "+precio.ToString()+ "\n");
        }

        private void cmbUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
