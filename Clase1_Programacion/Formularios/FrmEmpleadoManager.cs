//using CoreApp.Interfaces;
//using CoreApp.Interfaces;
using AppCore.Factories;
using AppCore.Interfaces;
using AppCore.Processes;
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
    public partial class FrmEmpleadoManager : Form
    {
        private IEmpleadoService empleadoService;
        //private SalaryCalculator salaryCalculator;
        public FrmEmpleadoManager(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
            InitializeComponent();
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente(1000, "001-000000-0000U", "Pepito Jose",
                "Perez Soza", 23786.98M, DateTime.Now)
            {
                CategoriaDocente = Domain.Enums.CategoriaDocente.Titular,
                Id = empleadoService.GetLastEmpleadoId() + 1
            };
            empleadoService.Create(emp);
            PrintEmpleado();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo(3000, "001-000000-0000P", "Ana Cecilia",
               "Conda Jimenez", 337860.00M, DateTime.Now)
            {
                HorasExtras = 23.5f,
                Id = empleadoService.GetLastEmpleadoId() + 1
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
                return;
            }
            richTextBox1.Text = "";
            SalaryCalculatorFactory salaryCalculatorFactory = new SalaryCalculatorFactory();
            foreach (Empleado e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
                //richTextBox1.AppendText($"Salario neto: {salaryCalculator.CalculateSalary(e)}\n");
                richTextBox1.AppendText($"Salario neto: {salaryCalculatorFactory.CreateInstance(e).CalculateSalary(e)}\n");
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
                FrmEmpleado datos = new FrmEmpleado(cmbTipoEmpleado.SelectedIndex);
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
