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
    public partial class AdministradorActores : Form
    {
        //Conexion 
        private SqlConnection conexion = new SqlConnection("Server= DESKTOP-S9ALPN4; DataBase=AdministracionPeliculas; Integrated Security= TRUE");
        
        public AdministradorActores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarActores_Click(object sender, EventArgs e)
        {
            //Abrir conexion: 
            conexion.Open();
            MessageBox.Show("Se ha conectado correctamente la base de datos");
            //Mostrar lista de Actores 
            string query = "Select * from ACTOR";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSexoActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            cmbSexoActor.Items.Clear();
            //Abro conexion
            conexion.Open();
            //Operacion
            string query = "SELECT SEXO FROM ACTORES";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            cmbSexoActor.Items.Add("Masculino");
            cmbSexoActor.Items.Add("Femenino");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                //Abrir conexion: 
                conexion.Open();
                //Mostrar lista de Actores 
                string query = "Select * from ACTOR";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                conexion.Close();
            }
            else
            {
                //Mostrar lista de Actores 
                string query = "Select * from ACTOR Where NOMBRE_COMPLETO or SEXO or FECHA_NACIMIENTO '"+ textBox1.Text +"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }

        }

        private void btnNuevoActor_Click(object sender, EventArgs e)
        {
            AbrirDialogoAdd();
        }
        //Funcion para dialogos
        #region PRIVATE METHODS
        //Dialogo de agregar
       private void AbrirDialogoAdd()
        {
            //Llamando nuevo formulario:
            AgregarActor AgregarActor = new AgregarActor();
            AgregarActor.ShowDialog();
        }
        //Dialogo de modificar
        private void AbrirDialogoMod()
        {
            //Llamando nuevo formulario:
            ModificarActor ModificarActor = new ModificarActor();
            ModificarActor.ShowDialog();
        }
        //Dialogo de administrador de peliculas
        


    #endregion

    private void btnModificarActuar_Click(object sender, EventArgs e)
        {
            AbrirDialogoMod();
        }

        private void btnRedireccionPelicular_Click(object sender, EventArgs e)
        {
            AdministrarPeliculas administrarPeliculas = new AdministrarPeliculas();
            administrarPeliculas.ShowDialog();
        }
    }
}

       
      

