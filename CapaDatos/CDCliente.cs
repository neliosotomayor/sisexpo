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
    public class CDCliente : CDConexion
    {

        public List<CECliente> MostrarClientes(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_CLIENTES");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CECliente> Listar = new List<CECliente>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CECliente
                {
                    Cli_Id = drLeerFilas.GetInt32(0),
                    Cli_Nombre = drLeerFilas.GetString(1),
                    Cli_Credito = drLeerFilas.GetInt32(2),
                    Usuario_Creacion = drLeerFilas.IsDBNull(3) ? "..." : drLeerFilas.GetString(3),
                    Fecha_Creacion = drLeerFilas.IsDBNull(4) ? "..." : drLeerFilas.GetDateTime(4).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(5) ? "..." : drLeerFilas.GetString(5),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(6) ? "..." : drLeerFilas.GetDateTime(6).ToString()
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

        public void InsertarCliente(CECliente objCECliente)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_CLIENTE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Cli_Nombre", objCECliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@Cli_Credito", objCECliente.Cli_Credito);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCECliente.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarCliente(CECliente objCECliente)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_CLIENTE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Cli_Id", objCECliente.Cli_Id);
            cmd.Parameters.AddWithValue("@Cli_Nombre", objCECliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@Cli_Credito", objCECliente.Cli_Credito);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCECliente.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarCliente(CECliente objCECliente)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_CLIENTE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Cli_Id", objCECliente.Cli_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCECliente.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public string MostrarClienteId(int sBuscar)
        {
            string sRespuesta = "";

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_CLIENTE_ID");
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
