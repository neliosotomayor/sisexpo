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
    public class CDPuerto : CDConexion
    {

        public List<CEPuerto> MostrarPuertos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PUERTOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEPuerto> Listar = new List<CEPuerto>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEPuerto
                {
                    Pue_Id = drLeerFilas.GetInt32(0),
                    Pue_Nombre = drLeerFilas.GetString(1),
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

        public void InsertarPuerto(CEPuerto objCEPuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_PUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pue_Nombre", objCEPuerto.Pue_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEPuerto.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarPuerto(CEPuerto objCEPuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_PUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pue_Id", objCEPuerto.Pue_Id);
            cmd.Parameters.AddWithValue("@Pue_Nombre", objCEPuerto.Pue_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEPuerto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarPuerto(CEPuerto objCEPuerto)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_PUERTO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Pue_Id", objCEPuerto.Pue_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEPuerto.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public string MostrarPuertoId(int sBuscar)
        {
            string sRespuesta = "";

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PUERTO_ID");
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
