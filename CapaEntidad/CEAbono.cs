using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAbono
    {

        private int _Abo_Id;
        private int _Exportacion_Id;
        private string _Exp_FacturaNro;
        private int _Cliente_Id;
        private string _Cli_Nombre;
        private int _Banco_Id;
        private string _Ban_Nombre;
        private string _Abo_Fecha;
        private string _Abo_NroTransferencia;
        private decimal _Abo_Importe;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Abo_Id
        {
            get
            {
                return _Abo_Id;
            }

            set
            {
                _Abo_Id = value;
            }
        }

        public int Exportacion_Id
        {
            get
            {
                return _Exportacion_Id;
            }

            set
            {
                _Exportacion_Id = value;
            }
        }

        public string Exp_FacturaNro
        {
            get
            {
                return _Exp_FacturaNro;
            }

            set
            {
                _Exp_FacturaNro = value;
            }
        }

        public int Cliente_Id
        {
            get
            {
                return _Cliente_Id;
            }

            set
            {
                _Cliente_Id = value;
            }
        }

        public string Cli_Nombre
        {
            get
            {
                return _Cli_Nombre;
            }

            set
            {
                _Cli_Nombre = value;
            }
        }

        public int Banco_Id
        {
            get
            {
                return _Banco_Id;
            }

            set
            {
                _Banco_Id = value;
            }
        }

        public string Ban_Nombre
        {
            get
            {
                return _Ban_Nombre;
            }

            set
            {
                _Ban_Nombre = value;
            }
        }

        public string Abo_Fecha
        {
            get
            {
                return _Abo_Fecha;
            }

            set
            {
                _Abo_Fecha = value;
            }
        }

        public string Abo_NroTransferencia
        {
            get
            {
                return _Abo_NroTransferencia;
            }

            set
            {
                _Abo_NroTransferencia = value;
            }
        }

        public decimal Abo_Importe
        {
            get
            {
                return _Abo_Importe;
            }

            set
            {
                _Abo_Importe = value;
            }
        }

        public string Usuario_Creacion
        {
            get
            {
                return _Usuario_Creacion;
            }

            set
            {
                _Usuario_Creacion = value;
            }
        }

        public string Fecha_Creacion
        {
            get
            {
                return _Fecha_Creacion;
            }

            set
            {
                _Fecha_Creacion = value;
            }
        }

        public string Usuario_Modificacion
        {
            get
            {
                return _Usuario_Modificacion;
            }

            set
            {
                _Usuario_Modificacion = value;
            }
        }

        public string Fecha_Modificacion
        {
            get
            {
                return _Fecha_Modificacion;
            }

            set
            {
                _Fecha_Modificacion = value;
            }
        }

    }
}
