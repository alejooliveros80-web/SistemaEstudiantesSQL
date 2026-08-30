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
    public partial class Form04_RegistroEstudiante: Form
    {
        public Form04_RegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || cmbPrograma.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string info = $"-- ESTUDIANTE REGISTRADO --\n\n" +
                          $"Documento: {txtDocumento.Text}\n" +
                          $"Nombre: {txtNombre.Text} {txtApellido.Text}\n" +
                          $"Programa: {cmbPrograma.SelectedItem}\n" +
                          $"Fecha Nacimiento: {dtpFechaNacimiento.Value.ToShortDateString()}";

            MessageBox.Show(info, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbPrograma.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
    }
}
