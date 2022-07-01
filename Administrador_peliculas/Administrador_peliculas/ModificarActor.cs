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
    public partial class ModificarActor : Form
    {
        public ModificarActor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ModeloActor actor = new ModeloActor();
            actor.Nombre = txtNombre.Text;
            actor.Sexo = txtSexo.Text;
            actor.Fecha_nacimiento = txtFechaNacimiento.Text;
            actor.Pelicula = txtPelicula.Text;
        }
    }
}
