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
    public class CDMenu : CDConexion
    {

        public DataTable HabilitaMenu(int iUsuarioId)
        {
            DataTable DTResultado = new DataTable("Menu");
            try
            {
                Conectado();

                SqlCommand cmd = new SqlCommand("UP_MOSTRAR_MENU");
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pUsuario = new SqlParameter() { ParameterName = "@UsuarioId", SqlDbType = SqlDbType.Int, Value = iUsuarioId };
                cmd.Parameters.Add(pUsuario);

                //cmd.ExecuteNonQuery();
                cmd.Connection = cnn;

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DTResultado);

                Desconectado();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTResultado = null;
            }

            return DTResultado;
        }

        //public List<CEMenu> MostrarMenu(int iUsuarioId)
        //{
        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_MOSTRAR_MENU");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cnn;

        //    cmd.Parameters.AddWithValue("@UsuarioId", iUsuarioId);
        //    drLeerFilas = cmd.ExecuteReader();
        //    List<CEMenu> Listar = new List<CEMenu>();

        //    while (drLeerFilas.Read())
        //    {
        //        Listar.Add(new CEMenu
        //        {
        //            Registro = drLeerFilas.GetInt32(0),
        //            Registro_Incidencia = drLeerFilas.GetInt32(1),
        //            Registro_Combustible = drLeerFilas.GetInt32(2),
        //            Registro_Mantenimiento = drLeerFilas.GetInt32(3),
        //            Registro_Leasing = drLeerFilas.GetInt32(4),
        //            Consulta = drLeerFilas.GetInt32(5),
        //            Consulta_Combustible = drLeerFilas.GetInt32(6),
        //            Consulta_Incidencias = drLeerFilas.GetInt32(7),
        //            Consulta_Mantenimientos = drLeerFilas.GetInt32(8),
        //            Consulta_SOAT = drLeerFilas.GetInt32(9),
        //            Mantenimiento = drLeerFilas.GetInt32(10),
        //            Mantenimiento_Bancos = drLeerFilas.GetInt32(11),
        //            Mantenimiento_Choferes = drLeerFilas.GetInt32(12),
        //            Mantenimiento_Seguros = drLeerFilas.GetInt32(13),
        //            Mantenimiento_Talleres = drLeerFilas.GetInt32(14),
        //            Mantenimiento_Usuarios = drLeerFilas.GetInt32(15),
        //            Mantenimiento_Vehiculos = drLeerFilas.GetInt32(16),
        //            Mantenimiento_Vehiculos_Marcas = drLeerFilas.GetInt32(17),
        //            Mantenimiento_Vehiculos_Modelos = drLeerFilas.GetInt32(18)
        //            /*
        //            Usuario_Creacion = drLeerFilas.IsDBNull(4) ? "" : drLeerFilas.GetString(4),
        //            Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
        //            Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
        //            Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
        //            */
        //        });
        //    }
        //    drLeerFilas.Close();
        //    Desconectado();

        //    return Listar;
        //}

    }
}
