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
    public class CDAbono : CDConexion
    {

        public List<CEAbono> MostrarAbonosPorExportacion(int sBuscar)
        {
            Conectado();
            SqlDataReader drLeerFilas;
            SqlCommand cmd = new SqlCommand("UP_MOSTRAR_ABONOS_EXPOID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Exp_Id", sBuscar);
            drLeerFilas = cmd.ExecuteReader();
            List<CEAbono> Listar = new List<CEAbono>();

            while (drLeerFilas.Read())
            {
                Listar.Add(new CEAbono
                {
                    Abo_Id = drLeerFilas.GetInt32(0),
                    Exportacion_Id = drLeerFilas.GetInt32(1),
                    Exp_FacturaNro = drLeerFilas.GetString(2),
                    Cliente_Id = drLeerFilas.GetInt32(3),
                    Cli_Nombre = drLeerFilas.GetString(4),
                    Banco_Id = drLeerFilas.GetInt32(5),
                    Ban_Nombre = drLeerFilas.GetString(6),
                    Abo_Fecha = drLeerFilas.GetString(7),
                    Abo_NroTransferencia = drLeerFilas.GetString(8),
                    Abo_Importe = drLeerFilas.GetDecimal(9),
                    Usuario_Creacion = drLeerFilas.IsDBNull(10) ? "..." : drLeerFilas.GetString(10),
                    Fecha_Creacion = drLeerFilas.IsDBNull(11) ? "..." : drLeerFilas.GetDateTime(11).ToString(),
                    Usuario_Modificacion = drLeerFilas.IsDBNull(12) ? "..." : drLeerFilas.GetString(12),
                    Fecha_Modificacion = drLeerFilas.IsDBNull(13) ? "..." : drLeerFilas.GetDateTime(13).ToString()
                });
            }
            drLeerFilas.Close();
            Desconectado();

            return Listar;
        }

        public void InsertarAbono(CEAbono objCEAbono)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_INSERTAR_ABONO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@Abo_Id", objCEAbono.Abo_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCEAbono.Exportacion_Id);
            cmd.Parameters.AddWithValue("@Abo_Fecha", objCEAbono.Abo_Fecha);
            cmd.Parameters.AddWithValue("@Abo_Importe", objCEAbono.Abo_Importe);
            cmd.Parameters.AddWithValue("@Banco_Id", objCEAbono.Banco_Id);
            cmd.Parameters.AddWithValue("@Abo_NroTransferencia", objCEAbono.Abo_NroTransferencia);

            cmd.Parameters.AddWithValue("@Usuario_Creacion", objCEAbono.Usuario_Creacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void ModificarAbono(CEAbono objCEAbono)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_MODIFICAR_ABONO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Abo_Id", objCEAbono.Abo_Id);
            cmd.Parameters.AddWithValue("@Exportacion_Id", objCEAbono.Exportacion_Id);
            cmd.Parameters.AddWithValue("@Abo_Fecha", objCEAbono.Abo_Fecha);
            cmd.Parameters.AddWithValue("@Abo_Importe", objCEAbono.Abo_Importe);
            cmd.Parameters.AddWithValue("@Banco_Id", objCEAbono.Banco_Id);
            cmd.Parameters.AddWithValue("@Abo_NroTransferencia", objCEAbono.Abo_NroTransferencia);

            cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEAbono.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }

        public void EliminarAbono(CEAbono objCEAbono)
        {
            Conectado();
            SqlCommand cmd = new SqlCommand("UP_ELIMINAR_ABONO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Abo_Id", objCEAbono.Abo_Id);
            //cmd.Parameters.AddWithValue("@Usuario_Modificacion", objCEAbono.Usuario_Modificacion);

            cmd.ExecuteNonQuery();
            Desconectado();
        }
        
    }
}
