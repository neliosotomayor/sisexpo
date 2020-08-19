using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Funciones
    {

        //Mostrar Mensaje de Confirmación
        public void MensajeOk(string sMensaje)
        {
            MessageBox.Show(sMensaje, FrmLogin.gTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //Mostrar Mensaje de Error
        public void MensajeError(string sMensaje)
        {
            MessageBox.Show(sMensaje, FrmLogin.gTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult MensajeConfirmacion(string sMensaje)
        {
            DialogResult iRespuesta = MessageBox.Show(sMensaje, FrmLogin.gTitulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return iRespuesta;
        }

        public void MensajeAdvertencia(string sMensaje)
        {
            MessageBox.Show(sMensaje, FrmLogin.gTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool PuedeEliminar()
        {
            return (FrmLogin.gUsuario.Trim() == "NSOTOMAYOR");
        }
        
        //public void SoloLetras(KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (Char.IsLetter(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void SoloNumeros(KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (Char.IsNumber(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        //else if (char.IsSeparator(e.KeyChar))
        //        //{
        //        //    e.Handled = false;
        //        //}
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 255))
            {
                MensajeAdvertencia("Solo puede ingresar números");
                e.Handled = true;
                return;
            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123) && (e.KeyChar <= 255))
            {
                MensajeAdvertencia("Solo puede ingresar letras");
                e.Handled = true;
                return;
            }
        }

    }
}
