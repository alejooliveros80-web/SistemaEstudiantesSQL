using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerPráctico_Csharp
{
    public partial class Form01_HolaMundo: Form
    {
        public Form01_HolaMundo()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                lblMensaje.Text = $"Hola, {txtNombre.Text.Trim()}. Bienvenido a C#."; 
            else
                MessageBox.Show("Por favor ingresa tu nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            lblMensaje.Text = "";
            txtNombre.Focus();
        }
    }
    
}
