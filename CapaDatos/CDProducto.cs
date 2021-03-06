﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDProducto : CDConexion
    {

        public List<CEProducto> MostrarProductos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PRODUCTOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEProducto> Listar = new List<CEProducto>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEProducto
                {
                    Pro_Id = drLeerFilas.GetInt32(0),
                    Pro_Nombre = drLeerFilas.GetString(1),
                    Usuario_Creacion = drLeerFilas.IsDBNull(2) ? "..." : drLeerFilas.GetString(2),
                    Fecha_Creacion = drLeerFilas.IsDBNull(3) ? "..." : drLeerFilas.GetDateTime(3).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(4) ? "..." : drLeerFilas.GetString(4),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(5) ? "..." : drLeerFilas.GetDateTime(5).ToString()
                    /*
                    Usuario_Creacion = drLeerFilas.IsDBNull(4) ? "" : drLeerFilas.GetString(4),
                    Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
                    */
                });
            }
            drLeerFilas.Close();
            Desconectado();

            return Listar;
        }

        public void InsertarProducto(CEProducto objCEProducto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_PRODUCTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pro_Nombre", objCEProducto.Pro_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEProducto.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarProducto(CEProducto objCEProducto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_PRODUCTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pro_Id", objCEProducto.Pro_Id);
            cmd.Parameters.AddWithValue("@Pro_Nombre", objCEProducto.Pro_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEProducto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarProducto(CEProducto objCEProducto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_PRODUCTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pro_Id", objCEProducto.Pro_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEProducto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public string MostrarProductoId(int sBuscar)
        {
            string sRespuesta = "";

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PRODUCTO_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();

            while (drLeerFilas.Read())
            {
                sRespuesta = drLeerFilas.GetString(1);
            }
            drLeerFilas.Close();
            Desconectado();

            return sRespuesta;
        }

    }
}
