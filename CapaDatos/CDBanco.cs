using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDBanco : CDConexion
    {

        public List<CEBanco> MostrarBancos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_BANCOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEBanco> Listar = new List<CEBanco>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEBanco
                {
                    Ban_Id = drLeerFilas.GetInt32(0),
                    Ban_Nombre = drLeerFilas.GetString(1),
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

        public void InsertarBanco(CEBanco objCEBanco)
        {
            Conectado();
            using (SqlCommand cmd = new SqlCommand("UP_INSERTAR_BANCO"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Ban_Nombre", objCEBanco.Ban_Nombre);
                cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEBanco.Usuario_Creacion);

                cmd.ExecuteNonQuery();
            }
            Desconectado();
        }

        public void ModificarBanco(CEBanco objCEBanco)
        {
            Conectado();
            using (SqlCommand cmd = new SqlCommand("UP_MODIFICAR_BANCO"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Ban_Id", objCEBanco.Ban_Id);
                cmd.Parameters.AddWithValue("@Ban_Nombre", objCEBanco.Ban_Nombre);
                cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEBanco.Usuario_Modificacion);

                cmd.ExecuteNonQuery();
            }
            Desconectado();
        }

        public void EliminarBanco(CEBanco objCEBanco)
        {
            Conectado();
            using (SqlCommand cmd = new SqlCommand("UP_ELIMINAR_BANCO"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Ban_Id", objCEBanco.Ban_Id);
                //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEBanco.Usuario_Modificacion);

                cmd.ExecuteNonQuery();
            }
            Desconectado();
        }

        public string MostrarBancoId(int sBuscar)
        {
            string sRespuesta = "";

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_BANCO_ID");
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
