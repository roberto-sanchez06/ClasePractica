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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1_Programacion.Formularios
{
    public partial class FrmEmployee : Form
    {
        public EmpleadoModel EmpleadoM {get; set;}
        //public int  TipoEmpleado { get; set; }
        private int Tipo;
        public FrmEmployee(int tipo)
        {
            Tipo = tipo;
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Validar(txtCedula.Text, txtCodigo.Text, txtNombre.Text, txtApellido.Text);
                //Empleado2 emp;
                switch (Tipo)
                {
                    case 0:
                        Empleado2 emp= new Docente(int.Parse(txtCodigo.Text), txtCedula.Text, txtNombre.Text, txtApellido.Text, nudSalario.Value, dtpFecha.Value)
                        {
                            CategoriaDocente = (CategoriaDocente)cmbCategoriaDocente.SelectedIndex
                        };
                        EmpleadoM.Add(emp);
                        break;
                    case 1:
                        emp = new Administrativo(int.Parse(txtCodigo.Text), txtCedula.Text, txtNombre.Text, txtApellido.Text, nudSalario.Value, dtpFecha.Value)
                        {
                            HorasExtras = (float)nudHorasExtras.Value
                        };
                        EmpleadoM.Add(emp);
                        break;
                }
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Validar(string cedula, string codigo, string nombres, string apellidos)
        {
            if(string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos))
            {
                throw new ArgumentException("Hay campos vacios, por favor rellenelos");
            }
            string patronCedula = @"001-\d{6}-\d{4}[A-Z]";
            if (Regex.Matches(cedula, patronCedula).Count <= 0)
            {
                throw new ArgumentException("El patron de la cedula no es el correcto");
            }
            //if (codigo.Length > 10)
            //{
            //    throw new ArgumentException("El codigo no puede tener mas de 10 digitos");
            //}
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se admiten numeros","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            cmbCategoriaDocente.Items.AddRange(Enum.GetValues(typeof(CategoriaDocente)).Cast<object>().ToArray());
            switch (Tipo)
            {
                case 0:
                    pnlDocente.Visible = true;
                    break;
                case 1:
                    pnlAdmin.Visible = true;
                    break;
            }
        }
    }
}
