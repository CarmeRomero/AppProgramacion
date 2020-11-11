﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FormProgramacion
{
    class CNN
    {
        
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        string cadenaConexion;
        public CNN()
        {
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            dr = null;
            cadenaConexion = @"Data Source=database-1.c8opvcsreaob.sa-east-1.rds.amazonaws.com;Initial Catalog=CINE;User ID=PabloCausa; Password = Thereason2020";
        }

        public CNN(string cadenaConexion)
        {
            this.cnn = new SqlConnection();
            this.cmd = new SqlCommand();
            this.dr = null;
            this.cadenaConexion = cadenaConexion;
        }

        public SqlCommand pCmd { get => cmd; set => cmd = value; }
        public SqlDataReader pDr { get => dr; set => dr = value; }
        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

        public void conectar()
        {
            this.cnn.ConnectionString = cadenaConexion;
            this.cnn.Open();
            this.cmd.CommandType = CommandType.Text;
            this.cmd.Connection = cnn;
        }
        public void desconectar()
        {
            cnn.Close();
        }
        public DataTable extraerTabla(string nombreTabla)
        {
            this.conectar();
            DataTable dt = new DataTable();
            this.cmd.CommandText = "SELECT * FROM " + nombreTabla;
            dt.Load(cmd.ExecuteReader());
            this.desconectar();
            return dt;
        }
        public DataTable consultarTabla(string sentenciaSQL)
        {
            this.conectar();
            DataTable dt = new DataTable();
            this.cmd.CommandText = sentenciaSQL;
            dt.Load(cmd.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public void leerTabla(string nombreTabla)
        {
            this.conectar();
            this.cmd.CommandText = "SELECT * FROM " + nombreTabla;
            this.dr = cmd.ExecuteReader();
        }
        public void actualizarBD(string sentenciaSQL)
        {
            this.conectar();
            this.cmd.CommandText = sentenciaSQL;
            this.cmd.ExecuteNonQuery();
            this.desconectar();

        }
        //public void nuevo(string consultaSQL, string p1, int p2, int p3, double p4, DateTime p5)
        //{
        //    conectar();
        //    cmd.CommandText = consultaSQL;
        //    cmd.Parameters.AddWithValue("@param1", p1);
        //    cmd.Parameters.AddWithValue("@param2", p2);
        //    cmd.Parameters.AddWithValue("@param3", p3);
        //    cmd.Parameters.AddWithValue("@param4", p4);
        //    cmd.Parameters.AddWithValue("@param5", p5);
        //    cmd.ExecuteNonQuery();
        //    desconectar();
        //    cmd.Parameters.Clear();
        //}
        //public void editar(string consultaSQL, string p1, int p2, int p3, double p4, DateTime p5, int pk)
        //{
        //    conectar();
        //    cmd.CommandText = consultaSQL;
        //    cmd.Parameters.AddWithValue("@param1", p1);
        //    cmd.Parameters.AddWithValue("@param2", p2);
        //    cmd.Parameters.AddWithValue("@param3", p3);
        //    cmd.Parameters.AddWithValue("@param4", p4);
        //    cmd.Parameters.AddWithValue("@param5", p5);
        //    cmd.Parameters.AddWithValue("@pk", pk);
        //    cmd.ExecuteNonQuery();
        //    desconectar();
        //    cmd.Parameters.Clear();
        //}
        //public void borrar(int codigo)
        //{
        //    string sentenciaSQL = "";
        //    conectar();
        //    sentenciaSQL = "DELETE FROM producto " +
        //            "WHERE codigo = " + codigo;
        //    cmd.CommandText = sentenciaSQL;
        //    cmd.ExecuteNonQuery();
        //    desconectar();

        //}
    }
}
