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
    public partial class Form07_Inventario: Form
    {
        public class Producto
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }
            public double Subtotal => Precio * Cantidad;
        }

        private List<Producto> inventario = new List<Producto>();
        public Form07_Inventario()
        {
            InitializeComponent();
        }
        private void ActualizarTabla()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventario;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrecio.Text, out double precio) && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                inventario.Add(new Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Categoria = cmbCategoria.SelectedItem?.ToString() ?? "General",
                    Precio = precio,
                    Cantidad = cantidad
                });
                ActualizarTabla();
                CalcularTotalInventario();
            }
            else
            {
                MessageBox.Show("Ingrese precio y cantidad numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e) => CalcularTotalInventario();

        private void CalcularTotalInventario()
        {
            double total = inventario.Sum(p => p.Subtotal);
            lblValorTotal.Text = $"Valor Total Inventario: ${total:N2}";
        }
    }
}
