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
    public partial class Form05_SistemaNotas: Form
    {
        public Form05_SistemaNotas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota1.Text, out double n1) &&
                double.TryParse(txtNota2.Text, out double n2) &&
                double.TryParse(txtNota3.Text, out double n3))
            {
                double promedio = (n1 + n2 + n3) / 3.0;
                lblPromedio.Text = $"Promedio: {promedio:N2}";

                if (promedio >= 3.0)
                {
                    lblEstado.Text = "Estado: APROBADO";
                    lblEstado.ForeColor = Color.Green;
                }
                else
                {
                    lblEstado.Text = "Estado: REPROBADO";
                    lblEstado.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Ingrese las 3 notas en formato numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
