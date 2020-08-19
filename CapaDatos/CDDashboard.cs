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
    public class CDDashboard : CDConexion
    {

        public DataTable MostrarDatos()
        {
            DataTable DTResultado = new DataTable("DASHBOARD");
            try
            {
                Conectado();

                SqlCommand cmd = new SqlCommand("UP_DASHBOARD");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = cnn;

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DTResultado);

                Desconectado();

            }
            catch (Exception ex)
            {
                DTResultado = null;
                Desconectado();
            }

            return DTResultado;
        }

        public DataTable MostrarGrafico(int iDato)
        {
            string sProcedure = String.Empty;

            DataTable DTResultado = new DataTable("GRAFICO");

            try
            {
                Conectado();

                switch (iDato)
                {
                    case 1:
                        sProcedure = "UP_DASHBOARD_ARANDANOS";
                        break;
                    case 2:
                        sProcedure = "UP_DASHBOARD_ARVEJA";
                        break;
                    case 3:
                        sProcedure = "UP_DASHBOARD_CURCUMA";
                        break;
                    case 4:
                        sProcedure = "UP_DASHBOARD_GRANADA";
                        break;
                    case 5:
                        sProcedure = "UP_DASHBOARD_JENGIBRE";
                        break;
                    case 6:
                        sProcedure = "UP_DASHBOARD_PALTAS";
                        break;
                }

                SqlCommand cmd = new SqlCommand(sProcedure);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = cnn;

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DTResultado);

                Desconectado();

            }
            catch (Exception ex)
            {
                DTResultado = null;
                Desconectado();
            }

            return DTResultado;
        }

    }
}
