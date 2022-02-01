using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorioBD1
{


    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-JA8S81B\\BASEDEDATOS; dataBase=BBDDPrueba1; integrated security= true");
        public Form1()
        {
            InitializeComponent();
        }

        private void coneccion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Ha Iniciado La Conexión con el servidor.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión");
            }
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT Id, Seccion, NombreArticulo, Precio, Fecha, PaisOrigen FROM Articulo";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            vista.DataSource = tabla;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Articulo WHERE Id = @Id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@Id", txtCampo.Text);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            vista.DataSource = tabla;

            conexion.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Articulo (Seccion, NombreArticulo, Precio, Fecha, PaisOrigen) VALUES (@Seccion, @NombreArticulo, @Precio, @Fecha, @PaisOrigen)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@Seccion", txtseccion.Text);
            comando.Parameters.AddWithValue("@NombreArticulo", txtnombre.Text);
            comando.Parameters.AddWithValue("@Precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@Fecha", txtfecha.Text);
            comando.Parameters.AddWithValue("@PaisOrigen", txtpaisorigen.Text);

            comando.ExecuteNonQuery();

            txtseccion.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtfecha.Text = "";
            txtpaisorigen.Text = "";

            conexion.Close();
            MessageBox.Show("Insertado");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE Articulo SET Seccion= @Seccion, NombreArticulo = @NombreArticulo, Precio = @Precio, Fecha = @Fecha, PaisOrigen = @PaisOrigen WHERE Id = @Id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@Seccion", txtseccion.Text);
            comando.Parameters.AddWithValue("@NombreArticulo", txtnombre.Text);
            comando.Parameters.AddWithValue("@Precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@Fecha", txtfecha.Text);
            comando.Parameters.AddWithValue("@PaisOrigen", txtpaisorigen.Text);
            comando.Parameters.AddWithValue("@Id", txtid.Text);
            comando.ExecuteNonQuery();

            txtid.Text = "";
            txtseccion.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtfecha.Text = "";
            txtpaisorigen.Text = "";

            conexion.Close();
            MessageBox.Show("Actualizado");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM Articulo WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            comando.Parameters.AddWithValue("@Id",txtid.Text);
            comando.ExecuteNonQuery();

            txtid.Text = "";
            conexion.Close();
            MessageBox.Show("Registro Eliminado");
        }
    }
}
