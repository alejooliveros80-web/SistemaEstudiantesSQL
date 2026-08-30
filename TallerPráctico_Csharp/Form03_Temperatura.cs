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
    public partial class Form03_Temperatura: Form
    {
        public Form03_Temperatura()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = $"Resultado: {fahrenheit:N2} °F";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para Celsius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
