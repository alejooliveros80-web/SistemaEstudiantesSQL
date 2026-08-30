using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerPráctico_Csharp;

namespace TallerPractico_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e) => new Form01_HolaMundo().ShowDialog();

        private void btnEx2_Click_1(object sender, EventArgs e) => new Form02_Calculadora().ShowDialog();

        private void btnEx3_Click_1(object sender, EventArgs e) => new Form03_Temperatura().ShowDialog();

        private void btnEx4_Click_1(object sender, EventArgs e) => new Form04_RegistroEstudiante().ShowDialog();

        private void btnEx5_Click_1(object sender, EventArgs e) => new Form05_SistemaNotas().ShowDialog();

        private void btnEx6_Click_1(object sender, EventArgs e) => new Form06_ListaEstudiantes().ShowDialog();
        
        private void btnEx7_Click_1(object sender, EventArgs e) => new Form07_Inventario().ShowDialog();

        private void btnEx8_Click_1(object sender, EventArgs e) => new Form08_AgendaContactos().ShowDialog();
        private void btnSalir_Click_1(object sender, EventArgs e) => Application.Exit();
    }   
}