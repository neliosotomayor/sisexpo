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
    public class CDNotaCredito : CDConexion
    {

        public List<CENotaCredito> MostrarNotasDeCreditoPorExportacion(int sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_NOTASCREDITO_EXPOID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Expo_Id", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CENotaCredito> Listar = new List<CENotaCredito>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CENotaCredito
                {
                    NC_Id = drLeerFilas.GetInt32(0),
                    Exportacion_Id = drLeerFilas.GetInt32(1),
                    Exp_FacturaNro = drLeerFilas.GetString(2),
                    Cliente_Id = drLeerFilas.GetInt32(3),
                    Cli_Nombre = drLeerFilas.GetString(4),
                    NCTipo_Id = drLeerFilas.GetInt32(5),
                    NCTip_Descripcion = drLeerFilas.GetString(6),
                    NC_Fecha = drLeerFilas.GetString(7),
                    NC_Nro = drLeerFilas.GetString(8),
                    NC_Importe = drLeerFilas.GetDecimal(9),
                    Usuario_Creacion = drLeerFilas.IsDBNull(10) ? "..." : drLeerFilas.GetString(10),
                    Fecha_Creacion = drLeerFilas.IsDBNull(11) ? "..." : drLeerFilas.GetDateTime(11).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(12) ? "..." : drLeerFilas.GetString(12),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(13) ? "..." : drLeerFilas.GetDateTime(13).ToString()
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

        public void InsertarNotaCredito(CENotaCredito objCENotaCreditos)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_NOTACREDITO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@NC_Id", objCENotaCreditos.NC_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCENotaCreditos.Exportacion_Id);
            cmd.Parameters.AddWithValue("@NC_Fecha", objCENotaCreditos.NC_Fecha);
            cmd.Parameters.AddWithValue("@NC_Nro", objCENotaCreditos.NC_Nro);
            cmd.Parameters.AddWithValue("@NC_Importe", objCENotaCreditos.NC_Importe);
            cmd.Parameters.AddWithValue("@NCTipo_Id", objCENotaCreditos.NCTipo_Id);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCENotaCreditos.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarNotaCredito(CENotaCredito objCENotaCreditos)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_NOTACREDITO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NC_Id", objCENotaCreditos.NC_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCENotaCreditos.Exportacion_Id);
            cmd.Parameters.AddWithValue("@NC_Fecha", objCENotaCreditos.NC_Fecha);
            cmd.Parameters.AddWithValue("@NC_Nro", objCENotaCreditos.NC_Nro);
            cmd.Parameters.AddWithValue("@NC_Importe", objCENotaCreditos.NC_Importe);
            cmd.Parameters.AddWithValue("@NCTipo_Id", objCENotaCreditos.NCTipo_Id);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCENotaCreditos.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarNotaCredito(CENotaCredito objCENotaCreditos)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_NOTACREDITO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NC_Id", objCENotaCreditos.NC_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCENotaCreditos.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        //public List<CENotaCredito> ConsultaNotaCreditosFecha(string sFechaDesde, string sFechaHasta, int iVehiculoId, int iNotaCredito)
        //{
        //    Conectado();
        //    SqlDataReader drLeerFilas;
        //    SqlCommand cmd = new SqlCommand("UP_CONSULTA_NotaCreditoS_FECHA");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cnn;

        //    cmd.Parameters.AddWithValue("@FechaDesde", sFechaDesde);
        //    cmd.Parameters.AddWithValue("@FechaHasta", sFechaHasta);
        //    cmd.Parameters.AddWithValue("@VehiculoId", iVehiculoId);
        //    cmd.Parameters.AddWithValue("@NotaCredito", iNotaCredito);

        //    drLeerFilas = cmd.ExecuteReader();
        //    List<CENotaCredito> Listar = new List<CENotaCredito>();

        //    while (drLeerFilas.Read())
        //    {
        //        Listar.Add(new CENotaCredito
        //        {
        //            Inc_Id = drLeerFilas.GetInt32(0),
        //            Vehiculo_Id = drLeerFilas.GetInt32(1),
        //            VehiculoPlaca = drLeerFilas.GetString(2),
        //            Chofer_Id = drLeerFilas.GetInt32(3),
        //            ChoferNombre = drLeerFilas.GetString(4),
        //            Inc_Fecha = drLeerFilas.GetString(5),
        //            Inc_Descripcion = drLeerFilas.GetString(6),
        //            Inc_Tipo = drLeerFilas.GetInt32(7),
        //            TipoNotaCredito = drLeerFilas.GetString(8),
        //            Inc_Activo = drLeerFilas.GetString(9),
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
