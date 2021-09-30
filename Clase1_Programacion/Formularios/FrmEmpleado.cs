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
            Empleado2 emp = new Docente(1000, "001-123456-1234V", "Pepito", "Perez", 23434, DateTime.Now)
            {
                Id = empleadoModel.GetLastEmpleadoId() + 1,
                CategoriaDocente=CategoriaDocente.Titular
            };
            empleadoModel.Add(emp);
            PrintEmpleado();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Empleado2 emp = new Administrativo(1000, "001-123456-1234V", "Pepito", "Perez", 7823, DateTime.Now)
            {
                Id = empleadoModel.GetLastEmpleadoId() + 1,
                HorasExtras=2.5F
            };
            empleadoModel.Add(emp);
            PrintEmpleado();
        }
        private void PrintEmpleado()
        {
            Empleado2[] empleados = empleadoModel.GetEmpleado2s();
            if (empleadoModel == null)
            {
                richTextBox1.Text = "No hay elementos a enocntrar";
            }
            richTextBox1.Text = "";
            foreach (Empleado2 e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
            }
        }

        private void CmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
