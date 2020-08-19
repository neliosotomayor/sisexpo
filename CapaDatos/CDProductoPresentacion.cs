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
    public class CDProductoPresentacion : CDConexion
    {

        public List<CEProductoPresentacion> MostrarProductoPresentaciones(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PRODUCTOPRESENTACIONES");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEProductoPresentacion> Listar = new List<CEProductoPresentacion>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEProductoPresentacion
                {
                    ProPre_Id = drLeerFilas.GetInt32(0),
                    Producto_Id = drLeerFilas.GetInt32(1),
                    Pro_Nombre = drLeerFilas.GetString(2),
                    ProPre_Descripcion = drLeerFilas.GetString(3),
                    ProPre_Kilos = drLeerFilas.GetDecimal(4),
                    Usuario_Creacion = drLeerFilas.IsDBNull(5) ? "..." : drLeerFilas.GetString(5),
                    Fecha_Creacion = drLeerFilas.IsDBNull(6) ? "..." : drLeerFilas.GetDateTime(6).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(7) ? "..." : drLeerFilas.GetString(7),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(8) ? "..." : drLeerFilas.GetDateTime(8).ToString()
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

        public void InsertarProductoPresentacion(CEProductoPresentacion objCEProductoPresentacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_PRODUCTOPRESENTACION");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Producto_Id", objCEProductoPresentacion.Producto_Id);
            cmd.Parameters.AddWithValue("@ProPre_Descripcion", objCEProductoPresentacion.ProPre_Descripcion);
            cmd.Parameters.AddWithValue("@ProPre_Kilos", objCEProductoPresentacion.ProPre_Kilos);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEProductoPresentacion.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarProductoPresentacion(CEProductoPresentacion objCEProductoPresentacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_ProductoPresentacion");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ProPre_Id", objCEProductoPresentacion.ProPre_Id);
            cmd.Parameters.AddWithValue("@Producto_Id", objCEProductoPresentacion.Producto_Id);
            cmd.Parameters.AddWithValue("@ProPre_Descripcion", objCEProductoPresentacion.ProPre_Descripcion);
            cmd.Parameters.AddWithValue("@ProPre_Kilos", objCEProductoPresentacion.ProPre_Kilos);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEProductoPresentacion.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarProductoPresentacion(CEProductoPresentacion objCEProductoPresentacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_PRODUCTOPRESENTACION");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ProPre_Id", objCEProductoPresentacion.ProPre_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEProductoPresentacion.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public List<CEProductoPresentacion> MostrarPresentacionesPorProducto(int sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_PRODPRESENTACIONES_PROID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Prod_Id", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEProductoPresentacion> Listar = new List<CEProductoPresentacion>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEProductoPresentacion
                {
                    ProPre_Id = drLeerFilas.GetInt32(0),
                    ProPre_Descripcion = drLeerFilas.GetString(1),
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

        //public string MostrarProductoPresentacionId(int sBuscar)
        //{
        //    string sRespuesta = "";

        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_MOSTRAR_ProductoPresentacionS_ID");
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
