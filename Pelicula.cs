using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProgramacion
{
    class Pelicula
    {
        CNN cnn = new CNN(@"Data Source=database-1.c8opvcsreaob.sa-east-1.rds.amazonaws.com;Initial Catalog=CINE;User ID=PabloCausa; Password = Thereason2020");
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
        public void nuevo(Pelicula p)
        {
            cnn.conectar();
            cnn.pCmd.CommandText = "INSERT INTO PELICULAS(titulo,Id_genero,Id_nacionalidad,Id_idioma,id_clasificacion) " +
                "VALUES(@param1, @param2, @param3, @param4, @param5)";
            cnn.pCmd.Parameters.AddWithValue("@param1", p.pTitulo);
            cnn.pCmd.Parameters.AddWithValue("@param2", p.pId_genero);
            cnn.pCmd.Parameters.AddWithValue("@param3", p.pId_nacionalidad);
            cnn.pCmd.Parameters.AddWithValue("@param4", p.pId_idioma);
            cnn.pCmd.Parameters.AddWithValue("@param5", p.pId_clasificacion);
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();
            cnn.pCmd.Parameters.Clear();
        }
        public void editar(Pelicula p)
        {
            string sentenciaSQL = "UPDATE PELICULAS SET " +
                            "titulo = @param1," +
                            "Id_genero = @param2," +
                            "Id_nacionalidad = @param3, " +
                            "Id_idioma = @param4, " +
                            "id_clasificacion = @param5 " +
                            "WHERE Id_pelicula = @pk";
            cnn.conectar();
            cnn.pCmd.CommandText = sentenciaSQL;
            cnn.pCmd.Parameters.AddWithValue("@param1", p.pTitulo);
            cnn.pCmd.Parameters.AddWithValue("@param2", p.pId_genero);
            cnn.pCmd.Parameters.AddWithValue("@param3", p.pId_nacionalidad);
            cnn.pCmd.Parameters.AddWithValue("@param4", p.pId_idioma);
            cnn.pCmd.Parameters.AddWithValue("@param5", p.pId_clasificacion);
            cnn.pCmd.Parameters.AddWithValue("@pk", p.pId_pelicula);
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();
            cnn.pCmd.Parameters.Clear();
        }
        public void borrar(Pelicula p)
        {
            string sentenciaSQL = "UPDATE PELICULAS SET " +
                            "Cancelada = @param1 " +
                            
                            "WHERE Id_pelicula = @pk";
            cnn.conectar();
            
            sentenciaSQL = "DELETE FROM PELICULAS " +
                    "WHERE id_pelicula = " + codigo;
            cnn.pCmd.CommandText = sentenciaSQL;
            cnn.pCmd.Parameters.AddWithValue("@param1", 1);
            cnn.pCmd.Parameters.AddWithValue("@pk", p.pId_pelicula);
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();
            cnn.pCmd.Parameters.Clear();

        }
    }
}
