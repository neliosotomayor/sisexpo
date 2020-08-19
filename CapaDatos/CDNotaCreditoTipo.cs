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
    public class CDNotaCreditoTipo : CDConexion
    {

        public List<CENotaCreditoTipo> MostrarNotaCreditoTipos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_NOTASCREDITOTIPOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CENotaCreditoTipo> Listar = new List<CENotaCreditoTipo>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CENotaCreditoTipo
                {
                    NCTip_Id = drLeerFilas.GetInt32(0),
                    NCTip_Descripcion = drLeerFilas.GetString(1),
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

        public void InsertarNotaCreditoTipo(CENotaCreditoTipo objCENotaCreditoTipo)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_NOTACREDITOTIPO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NCTip_Descripcion", objCENotaCreditoTipo.NCTip_Descripcion);
            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCENotaCreditoTipo.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarNotaCreditoTipo(CENotaCreditoTipo objCENotaCreditoTipo)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_NOTACREDITOTIPO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NCTip_Id", objCENotaCreditoTipo.NCTip_Id);
            cmd.Parameters.AddWithValue("@NCTip_Descripcion", objCENotaCreditoTipo.NCTip_Descripcion);
            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCENotaCreditoTipo.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarNotaCreditoTipo(CENotaCreditoTipo objCENotaCreditoTipo)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_NOTACREDITOTIPO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NCTip_Id", objCENotaCreditoTipo.NCTip_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCENotaCreditoTipo.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        //public string MostrarNotaCreditoTipoId(int sBuscar)
        //{
        //    string sRespuesta = "";

        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_MOSTRAR_NotaCreditoTipoS_ID");
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
