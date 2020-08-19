using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDUsuario : CDConexion
    {

        public List<CEUsuario> MostrarUsuarios(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_USUARIOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEUsuario> Listar = new List<CEUsuario>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEUsuario
                {
                    Usu_Id = drLeerFilas.GetInt32(0),
                    Usu_Nombre = drLeerFilas.GetString(1),
                    Usu_Apellido = drLeerFilas.GetString(2),
                    Usu_Usuario = drLeerFilas.GetString(3),
                    Usu_Password = drLeerFilas.GetString(4),
                    Usuario_Creacion = drLeerFilas.IsDBNull(5) ? "..." : drLeerFilas.GetString(5),
                    Fecha_Creacion = drLeerFilas.IsDBNull(6) ? "..." : drLeerFilas.GetDateTime(6).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(7) ? "..." : drLeerFilas.GetString(7),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(8) ? "..." : drLeerFilas.GetDateTime(8).ToString()
                    /*
                    Usuario_Creacion = drLeerFilas.IsDBNull(3) ? "..." : drLeerFilas.GetString(3),
                    Fecha_Creacion = drLeerFilas.GetDateTime(4) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(4),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(5) ? "..." : drLeerFilas.GetString(5),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(6) ? DateTime.Now : drLeerFilas.GetDateTime(6)
                    */
                });
            }
            drLeerFilas.Close();
            Desconectado();

            return Listar;
        }

        public void InsertarUsuario(CEUsuario objCEUsuarios)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_USUARIO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Usu_Nombre", objCEUsuarios.Usu_Nombre);
            cmd.Parameters.AddWithValue("@Usu_Apellido", objCEUsuarios.Usu_Apellido);
            cmd.Parameters.AddWithValue("@Usu_Usuario", objCEUsuarios.Usu_Usuario);
            cmd.Parameters.AddWithValue("@Usu_Password", objCEUsuarios.Usu_Password);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEUsuarios.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarUsuario(CEUsuario objCEUsuarios)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_USUARIO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Usu_Id", objCEUsuarios.Usu_Id);
            cmd.Parameters.AddWithValue("@Usu_Nombre", objCEUsuarios.Usu_Nombre);
            cmd.Parameters.AddWithValue("@Usu_Apellido", objCEUsuarios.Usu_Apellido);
            cmd.Parameters.AddWithValue("@Usu_Usuario", objCEUsuarios.Usu_Usuario);
            cmd.Parameters.AddWithValue("@Usu_Password", objCEUsuarios.Usu_Password);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEUsuarios.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarUsuario(CEUsuario objCEUsuarios)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_USUARIO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Usu_Id", objCEUsuarios.Usu_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEUsuarios.Usuario_Modificacion);
            
            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public DataTable ValidaUsuario(CEUsuario Obj)
        {
            DataTable DTResultado = new DataTable("Usuario");
            try
            {
                Conectado();

                SqlCommand cmd = new SqlCommand("UP_VALIDA_USUARIO");
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@Usuario", Obj.Usu_Id);
                //cmd.Parameters.AddWithValue("@Password", Obj.Usu_Password);

                SqlParameter pUsuario = new SqlParameter() { ParameterName = "@Usuario", SqlDbType = SqlDbType.VarChar, Size = 10, Value = Obj.Usu_Usuario };
                cmd.Parameters.Add(pUsuario);

                SqlParameter pPassword = new SqlParameter() { ParameterName = "@Password", SqlDbType = SqlDbType.VarChar, Size = 200, Value = Obj.Usu_Password };
                cmd.Parameters.Add(pPassword);

                //cmd.ExecuteNonQuery();
                cmd.Connection = cnn;

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DTResultado);

                Desconectado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTResultado = null;
            }
            
            return DTResultado;
        }

    }
}
