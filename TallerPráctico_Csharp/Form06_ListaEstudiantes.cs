using System;
using System.Collections;
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
    public partial class Form06_ListaEstudiantes: Form
    {
        public class Estudiante
        {
            public string Documento { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Programa { get; set; }
            public int Edad { get; set; }
        }
        private List<Estudiante> lista = new List<Estudiante>();
        public Form06_ListaEstudiantes()
        {
            InitializeComponent();
        }
        private void ActualizarGrid()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = lista;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                lista.Add(new Estudiante
                {
                    Documento = txtDocumento.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Programa = txtPrograma.Text,
                    Edad = edad
                });
                ActualizarGrid();
                btnLimpiar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                int index = dgvEstudiantes.CurrentRow.Index;
                lista.RemoveAt(index);
                ActualizarGrid();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPrograma.Clear();
            txtEdad.Clear();
        }
    }
}
