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
    public class CDOperador : CDConexion
    {

        public List<CEOperador> MostrarOperadores(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_OPERADORES");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEOperador> Listar = new List<CEOperador>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEOperador
                {
                    Ope_Id = drLeerFilas.GetInt32(0),
                    Ope_Nombre = drLeerFilas.GetString(1),
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

        public void InsertarOperador(CEOperador objCEOperador)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_OPERADOR");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Ope_Nombre", objCEOperador.Ope_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEOperador.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarOperador(CEOperador objCEOperador)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_OPERADOR");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Ope_Id", objCEOperador.Ope_Id);
            cmd.Parameters.AddWithValue("@Ope_Nombre", objCEOperador.Ope_Nombre);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEOperador.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarOperador(CEOperador objCEOperador)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_OPERADOR");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Ope_Id", objCEOperador.Ope_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEOperador.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        //public string MostrarOperadorId(int sBuscar)
        //{
        //    string sRespuesta = "";

        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_MOSTRAR_OperadorS_ID");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cnn;

        //    cmd.Parameters.AddWithValue("@Buscar", sBuscar);
        //    drLeerFilas = cmd.ExecuteReader();

        //    while (drLeerFilas.Read())
        //    {
        //        sRespuesta = drLeerFilas.GetString(1);
        //    }
        //    drLeerFilas.Close();
        //    Desconectado();

        //    return sRespuesta;
        //}

    }
}
