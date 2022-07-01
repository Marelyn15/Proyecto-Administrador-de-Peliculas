using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_peliculas
{
    internal class ModeloActor
    {
        //Representacion de la tabla ACTORES
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Pelicula { get; set; }
    }
}
