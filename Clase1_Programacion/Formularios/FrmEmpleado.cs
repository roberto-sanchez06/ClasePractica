//using CoreApp.Interfaces;
//using CoreApp.Interfaces;
using AppCore.Interfaces;
using Domain.Entities.Empleado2;
using Domain.Enums;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1_Programacion.Formularios
{
    public partial class FrmEmpleado : Form
    {
        //Le puse incrustrar tipos inter...en la referenci a coreapp para evitar el error
        //Lo de arriba no hace referencia a esto
        private IEmpleadoService empleadoService;
        public FrmEmpleado(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
            InitializeComponent();
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente(1000, "001-123456-1234V", "Pepito", "Perez", 23434, DateTime.Now)
            {
                Id = empleadoService.GetLastEmpleadoId() + 1,
                CategoriaDocente=CategoriaDocente.Titular
            };
            empleadoService.Create(emp);
            PrintEmpleado();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo(1000, "001-123456-1234V", "Pepito", "Perez", 7823, DateTime.Now)
            {
                Id = empleadoService.GetLastEmpleadoId() + 1,
                HorasExtras=2.5F
            };
            empleadoService.Create(emp);
            PrintEmpleado();
        }
        private void PrintEmpleado()
        {
            Empleado[] empleados = empleadoService.FindAll();
            if (empleadoService == null)
            {
                richTextBox1.Text = "No hay elementos a encontrar";
            }
            richTextBox1.Text = "";
            foreach (Empleado e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("No ha seleccionado ningun tipo de empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmEmployee datos = new FrmEmployee(cmbTipoEmpleado.SelectedIndex);
                datos.empleadoS = empleadoService;
                datos.ShowDialog();
                PrintEmpleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
