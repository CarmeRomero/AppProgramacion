using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProgramacion
{
    class Cliente
    {
        CNN cnn = new CNN(@"Data Source=database-1.c8opvcsreaob.sa-east-1.rds.amazonaws.com;Initial Catalog=CINE;User ID=PabloCausa; Password = Thereason2020");
        int id_cliente;
        string nombre;
        string apellido;
        DateTime fecha_nac;
        string calle;
        int altura;
        int nro_documento;
        int id_tipo_doc;
        int id_sexo;
        int d_barrio;

        public int pId_cliente { get => id_cliente; set => id_cliente = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public DateTime pFecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string pCalle { get => calle; set => calle = value; }
        public int pAltura { get => altura; set => altura = value; }
        public int pNro_documento { get => nro_documento; set => nro_documento = value; }
        public int pId_tipo_doc { get => id_tipo_doc; set => id_tipo_doc = value; }
        public int pId_sexo { get => id_sexo; set => id_sexo = value; }
        public int pD_barrio { get => d_barrio; set => d_barrio = value; }


        public void nuevo(Cliente cli)
        {
            cnn.conectar();
            cnn.pCmd.CommandText = "INSERT INTO CLIENTES(nombre,apellido,fecha_nac,calle,altura,nro_documento,id_tipo_doc,id_sexo,d_barrio) " +
                "VALUES(@param1, @param2, @param3, @param4, @param5,@param6,@param7,@param8,@param9)";
            cnn.pCmd.Parameters.AddWithValue("@param1", cli.pNombre);
            cnn.pCmd.Parameters.AddWithValue("@param2", cli.pApellido);
            cnn.pCmd.Parameters.AddWithValue("@param3", cli.pFecha_nac);
            cnn.pCmd.Parameters.AddWithValue("@param4", cli.pCalle);
            cnn.pCmd.Parameters.AddWithValue("@param5", cli.pAltura);
            cnn.pCmd.Parameters.AddWithValue("@param6", cli.pNro_documento);
            cnn.pCmd.Parameters.AddWithValue("@param7", cli.pId_tipo_doc);
            cnn.pCmd.Parameters.AddWithValue("@param8", cli.pId_sexo);
            cnn.pCmd.Parameters.AddWithValue("@param9", cli.pD_barrio);
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();
            cnn.pCmd.Parameters.Clear();
        }
        public void editar(Cliente cli)
        {
            string sentenciaSQL = "UPDATE CLIENTES SET " +
                            " nombre = @param1," +
                            " apellido = @param2," +
                            " fecha_nac = @param3, " +
                            " calle = @param4, " +
                            " altura = @param5, " +
                            " nro_documento = @param6, " +
                            " id_tipo_doc = @param7, " +
                            " id_sexo = @param8, " +
                            " d_barrio = @param9 " +
                            " WHERE Id_cliente = @pk";
            cnn.conectar();
            cnn.pCmd.CommandText = sentenciaSQL;
            cnn.pCmd.Parameters.AddWithValue("@param1", cli.pNombre);
            cnn.pCmd.Parameters.AddWithValue("@param2", cli.pApellido);
            cnn.pCmd.Parameters.AddWithValue("@param3", cli.fecha_nac);
            cnn.pCmd.Parameters.AddWithValue("@param4", cli.pCalle);
            cnn.pCmd.Parameters.AddWithValue("@param5", cli.pAltura);
            cnn.pCmd.Parameters.AddWithValue("@param6", cli.pNro_documento);
            cnn.pCmd.Parameters.AddWithValue("@param7", cli.pId_tipo_doc);
            cnn.pCmd.Parameters.AddWithValue("@param8", cli.pId_sexo);
            cnn.pCmd.Parameters.AddWithValue("@param9", cli.pD_barrio);
            
            cnn.pCmd.Parameters.AddWithValue("@pk", cli.id_cliente);
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();
            cnn.pCmd.Parameters.Clear();
        }
        public void borrar(int codigo)
        {
            string sentenciaSQL = "";
            cnn.conectar();
            sentenciaSQL = "DELETE FROM CLIENTES " +
                    "WHERE id_cliente = " + codigo;
            cnn.pCmd.CommandText = sentenciaSQL;
            cnn.pCmd.ExecuteNonQuery();
            cnn.desconectar();

        }

        int sex;
        public string SexoDelCliente()
        {
            if (id_sexo == 1)
                return "Femenino";
            else
                return "Masculino";
        }

        public override string ToString()
        {
            string txt = "";
            txt = id_cliente +"  " +apellido + " , " + nombre;
            return txt;
        }


    }
}
