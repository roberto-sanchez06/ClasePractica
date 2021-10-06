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
        private EmpleadoModel empleadoModel;
        public FrmEmpleado()
        {
            empleadoModel = new EmpleadoModel();
            InitializeComponent();
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente(1000, "001-123456-1234V", "Pepito", "Perez", 23434, DateTime.Now)
            {
                Id = empleadoModel.GetLastEmpleadoId() + 1,
                CategoriaDocente=CategoriaDocente.Titular
            };
            empleadoModel.Create(emp);
            PrintEmpleado();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo(1000, "001-123456-1234V", "Pepito", "Perez", 7823, DateTime.Now)
            {
                Id = empleadoModel.GetLastEmpleadoId() + 1,
                HorasExtras=2.5F
            };
            empleadoModel.Create(emp);
            PrintEmpleado();
        }
        private void PrintEmpleado()
        {
            Empleado[] empleados = empleadoModel.FindAll();
            if (empleadoModel == null)
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
                datos.EmpleadoM = empleadoModel;
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
