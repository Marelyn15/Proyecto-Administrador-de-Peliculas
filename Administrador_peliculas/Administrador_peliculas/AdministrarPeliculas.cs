using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administrador_peliculas
{
    public partial class AdministrarPeliculas : Form
        
    {
        //Conexion 
        private SqlConnection conexion = new SqlConnection("Server= DESKTOP-S9ALPN4; DataBase=AdministracionPeliculas; Integrated Security= TRUE");
        public AdministrarPeliculas()
        {
            InitializeComponent();
        }

        private void MostrarPeliculas_Click(object sender, EventArgs e)
        {
            //Abrir conexion: 
            conexion.Open();
            MessageBox.Show("Se ha conectado correctamente la base de datos");
            //Mostrar lista de Actores 
            string query = "Select * from PELICULAS";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnRedireccionActores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Funcion para dialogos
        #region PRIVATE METHODS
        //Dialogo de agregar
        private void AbrirDialogoAdd()
        {
            //Llamando nuevo formulario:
            AgregarPelicula AgregarPelicula = new AgregarPelicula();
            AgregarPelicula.ShowDialog();
        }
        //Dialogo de modificar
        private void AbrirDialogoMod()
        {
            //Llamando nuevo formulario:
            ModificarPelicula ModificarPelicula = new ModificarPelicula();
            ModificarPelicula.ShowDialog();
        }
        #endregion

        private void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            AbrirDialogoAdd();
        }

        private void btnModificarPelicula_Click(object sender, EventArgs e)
        {
            AbrirDialogoMod();
        }
    }
}
