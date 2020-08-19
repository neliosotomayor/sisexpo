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
    public class CDExportacionDetalle : CDConexion
    {

        public List<CEExportacionDetalle> MostrarExportacionesDetalle(int sBuscar)
        {
            string sProcedure = string.Empty;

            if (sBuscar == 0)
            {
                sProcedure = "UP_MOSTRAR_EXPODETALLE";
            }
            else
            {
                sProcedure = "UP_MOSTRAR_EXPODETALLE_EXPOID";
            }

            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand(sProcedure);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            if (sBuscar > 0)
            { 
                cmd.Parameters.AddWithValue("@ExpId", sBuscar);
            }

            drLeerFilas = cmd.ExecuteReader();
            List<CEExportacionDetalle> Listar = new List<CEExportacionDetalle>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEExportacionDetalle
                {
                    ExpDet_Id = drLeerFilas.GetInt32(0),
                    Exportacion_Id = drLeerFilas.GetInt32(1),
                    Presentacion_Id = drLeerFilas.GetInt32(2),
                    ProPre_Descripcion = drLeerFilas.GetString(3),
                    ExpDet_Cajas = drLeerFilas.GetInt32(4),
                    ExpDet_Kilos = drLeerFilas.GetDecimal(5),
                    ExpDet_Precio = drLeerFilas.GetDecimal(6),
                    ExpDet_TotalPresentacion = drLeerFilas.GetDecimal(7),
                    Usuario_Creacion = drLeerFilas.IsDBNull(8) ? "..." : drLeerFilas.GetString(8),
                    Fecha_Creacion = drLeerFilas.IsDBNull(9) ? "..." : drLeerFilas.GetDateTime(9).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(10) ? "..." : drLeerFilas.GetString(10),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(11) ? "..." : drLeerFilas.GetDateTime(11).ToString()
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

        public void InsertarExportacionDetalle(CEExportacionDetalle objCEExportacionDetalle)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_EXPORTACIONDETALLE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            
            //cmd.Parameters.AddWithValue("@ExpDet_Id", objCEExportacionDetalle.ExpDet_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCEExportacionDetalle.Exportacion_Id);
            cmd.Parameters.AddWithValue("@ExpDet_Cajas", objCEExportacionDetalle.ExpDet_Cajas);
            cmd.Parameters.AddWithValue("@ExpDet_Kilos", objCEExportacionDetalle.ExpDet_Kilos);
            cmd.Parameters.AddWithValue("@ExpDet_Precio", objCEExportacionDetalle.ExpDet_Precio);
            cmd.Parameters.AddWithValue("@Presentacion_Id", objCEExportacionDetalle.Presentacion_Id);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEExportacionDetalle.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarExportacionDetalle(CEExportacionDetalle objCEExportacionDetalle)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_EXPORTACIONDETALLE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ExpDet_Id", objCEExportacionDetalle.ExpDet_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCEExportacionDetalle.Exportacion_Id);
            cmd.Parameters.AddWithValue("@ExpDet_Cajas", objCEExportacionDetalle.ExpDet_Cajas);
            cmd.Parameters.AddWithValue("@ExpDet_Kilos", objCEExportacionDetalle.ExpDet_Kilos);
            cmd.Parameters.AddWithValue("@ExpDet_Precio", objCEExportacionDetalle.ExpDet_Precio);
            cmd.Parameters.AddWithValue("@Presentacion_Id", objCEExportacionDetalle.Presentacion_Id);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEExportacionDetalle.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarExportacionDetalle(CEExportacionDetalle objCEExportacionDetalle)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_EXPORTACIONDETALLE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ExpDet_Id", objCEExportacionDetalle.ExpDet_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEExportacionDetalle.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        //public List<CEExportacion> ConsultaExportacionFecha(string sFechaDesde, string sFechaHasta, int iVehiculoId)
        //{
        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_CONSULTA_Exportacion_FECHA");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cnn;

        //    cmd.Parameters.AddWithValue("@FechaDesde", sFechaDesde);
        //    cmd.Parameters.AddWithValue("@FechaHasta", sFechaHasta);
        //    cmd.Parameters.AddWithValue("@VehiculoId", iVehiculoId);

        //    drLeerFilas = cmd.ExecuteReader();
        //    List<CEExportacion> Listar = new List<CEExportacion>();

        //    while (drLeerFilas.Read())
        //    {
        //        Listar.Add(new CEExportacion
        //        {
        //            Com_Id = drLeerFilas.GetInt32(0),
        //            Vehiculo_Id = drLeerFilas.GetInt32(1),
        //            VehiculoPlaca = drLeerFilas.GetString(2),
        //            Chofer_Id = drLeerFilas.GetInt32(3),
        //            ChoferNombre = drLeerFilas.GetString(4),
        //            Com_Fecha = drLeerFilas.GetString(5),
        //            Com_Kilometraje = drLeerFilas.GetString(6),
        //            Com_Galones = drLeerFilas.GetInt32(7),
        //            Com_Pintas = drLeerFilas.GetInt32(8),
        //            Com_Activo = drLeerFilas.GetString(9),
        //            Usuario_Creacion = drLeerFilas.IsDBNull(10) ? "..." : drLeerFilas.GetString(10),
        //            Fecha_Creacion = drLeerFilas.IsDBNull(11) ? "..." : drLeerFilas.GetDateTime(11).ToString(),
        //            Usuario_Modificacion = drLeerFilas.IsDBNull(12) ? "..." : drLeerFilas.GetString(12),
        //            Fecha_Modificacion = drLeerFilas.IsDBNull(13) ? "..." : drLeerFilas.GetDateTime(13).ToString()
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
