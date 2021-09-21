using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Enums;

namespace Clase1_Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehiculoLiviano vehiculoLiviano = new VehiculoLiviano("Lexus", "LX570", 5)
            {
                Transmision = Transmision.Automatica
            };
            VehiculoLiviano vehiculoLiviano2 = new VehiculoLiviano("Lexus", "LX570", Transmision.Automatica)
            {
                NumeroPuertas=3
            };
        }
    }
}
