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
    public class CDExportacionSaldo : CDConexion
    {

        public List<CEExportacionSaldo> MostrarExportacionesSaldos(string sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_EXPORTACIONES_SALDOS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Buscar", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEExportacionSaldo> Listar = new List<CEExportacionSaldo>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEExportacionSaldo
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

                    Abonos = drLeerFilas.GetDecimal(25),
                    NC = drLeerFilas.GetDecimal(26),
                    Saldo = drLeerFilas.GetDecimal(27),

                    Usuario_Creacion = drLeerFilas.IsDBNull(28) ? "..." : drLeerFilas.GetString(28),
                    Fecha_Creacion = drLeerFilas.IsDBNull(29) ? "..." : drLeerFilas.GetDateTime(29).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(30) ? "..." : drLeerFilas.GetString(30),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(31) ? "..." : drLeerFilas.GetDateTime(31).ToString()
                });
            }
            drLeerFilas.Close();
            Desconectado();

            return Listar;
        }

    }
}
