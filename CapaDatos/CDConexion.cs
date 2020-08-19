using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;
using System.Windows;
using System.Windows.Forms;

public class CDConexion : IDisposable
{
    public SqlConnection cnn = new SqlConnection();

    public void Dispose()
    {
        if (cnn != null)
        {
            cnn.Dispose();
            cnn = null;
        }
    }
    protected Boolean Conectado()
    {
        try
        {
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            cnn.Open();
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    protected Boolean Desconectado()
    {
        try
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                return true;
            }
            else
                return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
