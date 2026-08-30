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
    public partial class Form02_Calculadora: Form
    {
        public Form02_Calculadora()
        {
            InitializeComponent();
        }
        private bool ValidarEntradas(out double n1, out double n2)
        {
            bool v1 = double.TryParse(txtNumero1.Text, out n1);
            bool v2 = double.TryParse(txtNumero2.Text, out n2);

            if (!v1 || !v2)
            {
                MessageBox.Show("Ingrese números válidos y no deje campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double n1, out double n2))
                lblResultado.Text = $"Resultado: {n1 + n2}";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double n1, out double n2))
                lblResultado.Text = $"Resultado: {n1 - n2}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double n1, out double n2))
                lblResultado.Text = $"Resultado: {n1 * n2}";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double n1, out double n2))
            {
                if (n2 == 0)
                    MessageBox.Show("No se permite la división entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    lblResultado.Text = $"Resultado: {n1 / n2}";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "Resultado:";
        }
    }
}
