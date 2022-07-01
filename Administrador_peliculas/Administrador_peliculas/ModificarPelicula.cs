using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_peliculas
{
    public partial class ModificarPelicula : Form
    {
        public ModificarPelicula()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             ModeloPeliculas pelicula = new ModeloPeliculas();
                pelicula.Titulo_Pelicula = txtTitulo.Text;
                pelicula.Genero = txtGenero.Text;
                pelicula.Fecha_estreno = txtFechaEstreno.Text;
        }
    }
}
