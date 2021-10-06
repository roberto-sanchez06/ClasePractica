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
using Domain.Entities.Empleado;
using Domain.Enums;

namespace Clase1_Programacion.Formularios
{
    public partial class FormularioEmpleado : Form
    {
        public int Contador { get; set; }
        public FormularioEmpleado()
        {
            Contador = 0;
            InitializeComponent();
        }

        private void FormularioEmpleado_Load(object sender, EventArgs e)
        {
            cmbContratacion.Items.AddRange(Enum.GetValues(typeof(TipoContratacion)).Cast<object>().ToArray());
            cmbTipoEmpleado.Items.AddRange(Enum.GetValues(typeof(TipoEmpleado)).Cast<object>().ToArray());
            MessageBox.Show("A continuacion, llenara este formulario para dos empleados","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoEmpleado.SelectedIndex)
            {
                case 0:
                    pnlAdmin.Visible = false;
                    pnlDocente.Visible = true;
                    break;
                case 1:
                    pnlDocente.Visible = false;
                    pnlAdmin.Visible = true;
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Contador >= 2)
            {
                MessageBox.Show("Ha rellenado los datos de los 2 empleados, la app se cerrará","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            try
            {
                VerificarDatos(txtNombre.Text, txtNombre.Text, txtNumId.Text);
                Factory[] fabrica = new Factory[2];
                AtributosEmpleados atri;
                switch (cmbTipoEmpleado.SelectedIndex)
                {
                    case 0:
                        fabrica[Contador] = new FactoryDocente();
                        if (cmbContratacion.SelectedIndex == -1)
                        {
                            //MessageBox.Show("No selecciono ningun tipo de contratacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //return;
                            throw new ArgumentException("No selecciono ningun tipo de contratacion");
                        }
                        atri = new AtributosEmpleados()
                        {
                            TipoContratacion = (TipoContratacion)cmbContratacion.SelectedIndex
                        };
                        break;
                    case 1:
                        VerificarHoras(dtpEntrada.Value, dtpSalida.Value);
                        fabrica[Contador] = new FactoryEmpleadoAdmin();
                        atri = new AtributosEmpleados()
                        {
                                Entrada = dtpEntrada.Value,
                                Salida = dtpSalida.Value
                        };
                        break;
                    default:
                        throw new ArgumentException("No seleccionó ningun tipo de empleado");
                }
                MessageBox.Show(fabrica[Contador].MostrarSalarioNeto((int)nudCodigo.Value, txtNombre.Text,
                                txtApellido.Text, txtNumId.Text, nudSalario.Value, atri));
                LimpiarPantalla();
                Contador++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void VerificarDatos(string nombre, string apellido, string nid)
        {
            string patron = @"001-\d{6}-\d{4}[A-Z]{1}";
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                throw new ArgumentException("Campos de nombres o apellidos vacios");
            }
            if (Regex.Matches(nid, patron).Count <=0 ) // tambien podria ser regex.match()
            {
                throw new ArgumentException("El numero de identificacion no tiene el formato correcto");
            }
        }
        private void LimpiarPantalla()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNumId.Text = string.Empty;
            nudCodigo.Value = nudCodigo.Minimum;
            nudSalario.Value = nudSalario.Minimum;
            cmbTipoEmpleado.SelectedIndex = -1;
            cmbContratacion.SelectedIndex = -1;
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            pnlAdmin.Visible = false;
            pnlDocente.Visible = false;
        }
        private void VerificarHoras(DateTime entrada, DateTime salida)
        {
            if (entrada.CompareTo(salida) >= 0)
            {
                throw new ArgumentException("La hora de entrada no puede ser mayor o igual a la hora de salida, por favor verifique estos datos");
            }
            //para fines practicos
            if((salida-entrada).Hours < 8)
            {
                throw new ArgumentException("No se puede trabajar menos de 8 horas");
            }
        }
    }
}
