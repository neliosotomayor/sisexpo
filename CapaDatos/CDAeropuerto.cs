using System;
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
    public class CDAeropuerto : CDConexion
    {

        public List<CEAeropuerto> MostrarAeropuertos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_AEROPUERTOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEAeropuerto> Listar = new List<CEAeropuerto>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEAeropuerto
                {
                    Aer_Id = drLeerFilas.GetInt32(0),
                    Aer_Nombre = drLeerFilas.GetString(1),
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

        public void InsertarAeropuerto(CEAeropuerto objCEAeropuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_AEROPUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Aer_Nombre", objCEAeropuerto.Aer_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEAeropuerto.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarAeropuerto(CEAeropuerto objCEAeropuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_AEROPUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Aer_Id", objCEAeropuerto.Aer_Id);
            cmd.Parameters.AddWithValue("@Aer_Nombre", objCEAeropuerto.Aer_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEAeropuerto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarAeropuerto(CEAeropuerto objCEAeropuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_AEROPUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Aer_Id", objCEAeropuerto.Aer_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEPuerto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public string MostrarAeropuertoId(int sBuscar)
        {
            string sRespuesta = "";

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_AEROPUERTO_ID");
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
