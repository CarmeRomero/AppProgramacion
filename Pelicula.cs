using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProgramacion
{
    class Pelicula
    {
        int id_pelicula;
        string titulo;
        int id_genero;
        int id_nacionalidad;
        int id_idioma;
        int id_clasificacion;
        string nacionalidad;


        public int pId_pelicula { get => id_pelicula; set => id_pelicula = value; }
        public string pTitulo { get => titulo; set => titulo = value; }
        public int pId_genero { get => id_genero; set => id_genero = value; }
        public int pId_nacionalidad { get => id_nacionalidad; set => id_nacionalidad = value; }
        public int pId_idioma { get => id_idioma; set => id_idioma = value; }
        public int pId_clasificacion { get => id_clasificacion; set => id_clasificacion = value; }
        public string pNacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public override string ToString()
        {
            string txt = "";
            txt = titulo + " - " + nacionalidad;
            return txt;
        }
    }
}
