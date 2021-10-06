using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Entities.Empleado;
using Domain.Enums;

namespace Clase1_Programacion.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*VehiculoLiviano vehiculoLiviano = new VehiculoLiviano("Lexus", "LX570", 5)
            {
                Transmision = Transmision.Automatica
            };
            VehiculoLiviano vehiculoLiviano2 = new VehiculoLiviano("Lexus", "LX570", Transmision.Automatica)
            {
                NumeroPuertas=3
            };*/

            /*Empleado[] empleados = new Empleado[] {
                new EmpleadoDocente(1200, "Pepito Jose", "Perez Lopez", "001-000000-0000V", 4254)
                {
                    TipoContratacion=TipoContratacion.CuarentaHoras
                },
                new EmpleadoAdministrativo(1200, "Ana Maria", "Fuentes Leon", "001-000000-0000V", 44543)
                {
                    HoraEntrada=new DateTime(2021,09,22,08,00,00),
                    HoraSalida=new DateTime(2021,09,22,16,00,00),
                }
            };            
            foreach (Empleado emp in empleados)
            {
                Print(emp);
            }*/

            Factory[] fabrica = new Factory[]
            {
                //new FactoryDocente(),
                new FactoryEmpleadoAdmin()
            };
            foreach (Factory f in fabrica)
            {
                PrintSalarioNeto(f, 1, "Juan", "perez", "001-000000-0000V", 5000, new AtributosEmpleados { Entrada= new DateTime(2021,09,22,08,00,00), Salida= new DateTime(2021, 09, 22, 18,00,00)});
            }
        }
        private void Print(Employee e)
        {
            MessageBox.Show(e.PrintEmpleado());
        }
        private void PrintSalarioNeto(Factory f, int codigo, string nombre, string apellido, string nid, decimal salario,AtributosEmpleados atributos)
        {
            MessageBox.Show(f.MostrarSalarioNeto(codigo, nombre, apellido, nid, salario, atributos));
        }
    }
}
