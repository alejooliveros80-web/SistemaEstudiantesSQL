using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerPractico_Csharp
{
    public partial class Form08_AgendaContactos : Form
    {
        public Form08_AgendaContactos()
        {
            InitializeComponent();
        }

        private void Form08_AgendaContactos_Load(object sender, EventArgs e)
        {

            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM contactos", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvContactos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla desde SQL: " + ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO contactos (documento, nombre, telefono, correo, ciudad) VALUES (@doc, @nom, @tel, @cor, @ciu)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@ciu", txtCiudad.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contacto guardado exitosamente en SQL Server.");

                    RefrescarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en SQL: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT * FROM contactos WHERE documento = @doc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["nombre"].ToString();
                        txtTelefono.Text = reader["telefono"].ToString();
                        txtCorreo.Text = reader["correo"].ToString();
                        txtCiudad.Text = reader["ciudad"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún contacto con ese documento.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar en SQL: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "UPDATE contactos SET nombre=@nom, telefono=@tel, correo=@cor, ciudad=@ciu WHERE documento=@doc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@ciu", txtCiudad.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contacto actualizado exitosamente en SQL Server.");

                    RefrescarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar en SQL: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "DELETE FROM contactos WHERE documento = @doc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contacto eliminado de SQL Server.");

                    RefrescarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar en SQL: " + ex.Message);
            }
        }
    }
}
