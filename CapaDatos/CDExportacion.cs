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
    public class CDExportacion : CDConexion
    {

        public List<CEExportacion> MostrarExportaciones(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_EXPORTACIONES");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEExportacion> Listar = new List<CEExportacion>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEExportacion
                {
                    Exp_Id = drLeerFilas.GetInt32(0),
                    Cliente_Id = drLeerFilas.GetInt32(1),
                    Cli_Nombre = drLeerFilas.GetString(2),
                    Exp_FacturaFecha = drLeerFilas.GetString(3),
                    Exp_FacturaNro = drLeerFilas.GetString(4),

                    Exp_FacturaCajas = drLeerFilas.GetInt64(5),
                    Exp_FacturaImporte = drLeerFilas.GetDecimal(6),
                    Producto_Id = drLeerFilas.GetInt32(7),
                    Pro_Nombre = drLeerFilas.GetString(8),
                    Exp_Contenedor = drLeerFilas.GetString(9),

                    Exp_Booking = drLeerFilas.GetString(10),
                    Exp_DUA = drLeerFilas.GetString(11),
                    Operador_Id = drLeerFilas.GetInt32(12),
                    Ope_Nombre = drLeerFilas.GetString(13),
                    Exp_Transporte = drLeerFilas.GetString(14),

                    Puerto_IdOrigen = drLeerFilas.GetInt32(15),
                    Pue_OrigenNombre = drLeerFilas.GetString(16),
                    Exp_ETD = drLeerFilas.GetString(17),
                    Exp_TTD = drLeerFilas.IsDBNull(18) ? "01/01/1900" : drLeerFilas.GetString(18).ToString(),
                    Puerto_IdDestino = drLeerFilas.GetInt32(19),
                    Pue_DestinoNombre = drLeerFilas.GetString(20),

                    Exp_ETA = drLeerFilas.GetString(21),
                    Exp_TTA = drLeerFilas.IsDBNull(22) ? "01/01/1900" : drLeerFilas.GetString(22).ToString(),
                    Exp_EstadoNave = drLeerFilas.GetString(23),
                    Comentario = drLeerFilas.IsDBNull(24) ? " " : drLeerFilas.GetString(24),

                    Usuario_Creacion = drLeerFilas.IsDBNull(25) ? "..." : drLeerFilas.GetString(25),
                    Fecha_Creacion = drLeerFilas.IsDBNull(26) ? "..." : drLeerFilas.GetDateTime(26).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(27) ? "..." : drLeerFilas.GetString(27),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(28) ? "..." : drLeerFilas.GetDateTime(28).ToString()
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

        public List<CEExportacion> MostrarExportacionesSaldos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_EXPORTACIONES_SALDOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEExportacion> Listar = new List<CEExportacion>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEExportacion
                {
                    Exp_Id = drLeerFilas.GetInt32(0),
                    Cliente_Id = drLeerFilas.GetInt32(1),
                    Cli_Nombre = drLeerFilas.GetString(2),
                    Exp_FacturaFecha = drLeerFilas.GetString(3),
                    Exp_FacturaNro = drLeerFilas.GetString(4),

                    Exp_FacturaCajas = drLeerFilas.GetInt64(5),
                    Exp_FacturaImporte = drLeerFilas.GetDecimal(6),
                    Producto_Id = drLeerFilas.GetInt32(7),
                    Pro_Nombre = drLeerFilas.GetString(8),
                    Exp_Contenedor = drLeerFilas.GetString(9),

                    Exp_Booking = drLeerFilas.GetString(10),
                    Exp_DUA = drLeerFilas.GetString(11),
                    Operador_Id = drLeerFilas.GetInt32(12),
                    Ope_Nombre = drLeerFilas.GetString(13),
                    Exp_Transporte = drLeerFilas.GetString(14),

                    Puerto_IdOrigen = drLeerFilas.GetInt32(15),
                    Pue_OrigenNombre = drLeerFilas.GetString(16),
                    Exp_ETD = drLeerFilas.GetString(17),
                    Exp_TTD = drLeerFilas.IsDBNull(18) ? "01/01/1900" : drLeerFilas.GetString(18).ToString(),
                    Puerto_IdDestino = drLeerFilas.GetInt32(19),
                    Pue_DestinoNombre = drLeerFilas.GetString(20),

                    Exp_ETA = drLeerFilas.GetString(21),
                    Exp_TTA = drLeerFilas.IsDBNull(22) ? "01/01/1900" : drLeerFilas.GetString(22).ToString(),
                    Exp_EstadoNave = drLeerFilas.GetString(23),
                    Comentario = drLeerFilas.IsDBNull(24) ? " " : drLeerFilas.GetString(24),

                    Usuario_Creacion = drLeerFilas.IsDBNull(25) ? "..." : drLeerFilas.GetString(25),
                    Fecha_Creacion = drLeerFilas.IsDBNull(26) ? "..." : drLeerFilas.GetDateTime(26).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(27) ? "..." : drLeerFilas.GetString(27),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(28) ? "..." : drLeerFilas.GetDateTime(28).ToString()
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

        public void InsertarExportacion(CEExportacion objCEExportacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_EXPORTACION");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@Exp_Id", objCEExportacion.Exp_Id);
            cmd.Parameters.AddWithValue("@Cliente_Id", objCEExportacion.Cliente_Id);
            cmd.Parameters.AddWithValue("@Exp_FacturaFecha", objCEExportacion.Exp_FacturaFecha);
            cmd.Parameters.AddWithValue("@Exp_FacturaNro", objCEExportacion.Exp_FacturaNro);
            cmd.Parameters.AddWithValue("@Exp_FacturaCajas", objCEExportacion.Exp_FacturaCajas);
            cmd.Parameters.AddWithValue("@Exp_FacturaImporte", objCEExportacion.Exp_FacturaImporte);
            cmd.Parameters.AddWithValue("@Producto_Id", objCEExportacion.Producto_Id);
            cmd.Parameters.AddWithValue("@Exp_Contenedor", objCEExportacion.Exp_Contenedor);
            cmd.Parameters.AddWithValue("@Exp_Booking", objCEExportacion.Exp_Booking);
            cmd.Parameters.AddWithValue("@Exp_DUA", objCEExportacion.Exp_DUA);
            cmd.Parameters.AddWithValue("@Operador_Id", objCEExportacion.Operador_Id);
            cmd.Parameters.AddWithValue("@Exp_Transporte", objCEExportacion.Exp_Transporte);
            cmd.Parameters.AddWithValue("@Puerto_IdOrigen", objCEExportacion.Puerto_IdOrigen);
            cmd.Parameters.AddWithValue("@Exp_ETD", objCEExportacion.Exp_ETD);
            cmd.Parameters.AddWithValue("@Exp_TTD", objCEExportacion.Exp_TTD);
            cmd.Parameters.AddWithValue("@Puerto_IdDestino", objCEExportacion.Puerto_IdDestino);
            cmd.Parameters.AddWithValue("@Exp_ETA", objCEExportacion.Exp_ETA);
            cmd.Parameters.AddWithValue("@Exp_TTA", objCEExportacion.Exp_TTA);
            cmd.Parameters.AddWithValue("@Exp_EstadoNave", objCEExportacion.Exp_EstadoNave);
            cmd.Parameters.AddWithValue("@Comentario", objCEExportacion.Comentario);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEExportacion.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarExportacion(CEExportacion objCEExportacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_EXPORTACION");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Exp_Id", objCEExportacion.Exp_Id);
            cmd.Parameters.AddWithValue("@Cliente_Id", objCEExportacion.Cliente_Id);
            cmd.Parameters.AddWithValue("@Exp_FacturaFecha", objCEExportacion.Exp_FacturaFecha);
            cmd.Parameters.AddWithValue("@Exp_FacturaNro", objCEExportacion.Exp_FacturaNro);
            cmd.Parameters.AddWithValue("@Exp_FacturaCajas", objCEExportacion.Exp_FacturaCajas);
            cmd.Parameters.AddWithValue("@Exp_FacturaImporte", objCEExportacion.Exp_FacturaImporte);
            cmd.Parameters.AddWithValue("@Producto_Id", objCEExportacion.Producto_Id);
            cmd.Parameters.AddWithValue("@Exp_Contenedor", objCEExportacion.Exp_Contenedor);
            cmd.Parameters.AddWithValue("@Exp_Booking", objCEExportacion.Exp_Booking);
            cmd.Parameters.AddWithValue("@Exp_DUA", objCEExportacion.Exp_DUA);
            cmd.Parameters.AddWithValue("@Operador_Id", objCEExportacion.Operador_Id);
            cmd.Parameters.AddWithValue("@Exp_Transporte", objCEExportacion.Exp_Transporte);
            cmd.Parameters.AddWithValue("@Puerto_IdOrigen", objCEExportacion.Puerto_IdOrigen);
            cmd.Parameters.AddWithValue("@Exp_ETD", objCEExportacion.Exp_ETD);
            cmd.Parameters.AddWithValue("@Exp_TTD", objCEExportacion.Exp_TTD);
            cmd.Parameters.AddWithValue("@Puerto_IdDestino", objCEExportacion.Puerto_IdDestino);
            cmd.Parameters.AddWithValue("@Exp_ETA", objCEExportacion.Exp_ETA);
            cmd.Parameters.AddWithValue("@Exp_TTA", objCEExportacion.Exp_TTA);
            cmd.Parameters.AddWithValue("@Exp_EstadoNave", objCEExportacion.Exp_EstadoNave);
            cmd.Parameters.AddWithValue("@Comentario", objCEExportacion.Comentario);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEExportacion.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarExportacion(CEExportacion objCEExportacion)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_EXPORTACION");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Exp_Id", objCEExportacion.Exp_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEExportacion.Usuario_Modificacion);

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
