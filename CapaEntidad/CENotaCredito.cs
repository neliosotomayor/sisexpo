using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CENotaCredito
    {

        private int _NC_Id;
        private int _Exportacion_Id;
        private string _Exp_FacturaNro;
        private int _Cliente_Id;
        private string _Cli_Nombre;
        private int _NCTipo_Id;
        private string _NCTip_Descripcion;
        private string _NC_Fecha;
        private string _NC_Nro;
        private decimal _NC_Importe;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int NC_Id
        {
            get
            {
                return _NC_Id;
            }

            set
            {
                _NC_Id = value;
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

        public string NC_Fecha
        {
            get
            {
                return _NC_Fecha;
            }

            set
            {
                _NC_Fecha = value;
            }
        }

        public int NCTipo_Id
        {
            get
            {
                return _NCTipo_Id;
            }

            set
            {
                _NCTipo_Id = value;
            }
        }

        public string NCTip_Descripcion
        {
            get
            {
                return _NCTip_Descripcion;
            }

            set
            {
                _NCTip_Descripcion = value;
            }
        }

        public string NC_Nro
        {
            get
            {
                return _NC_Nro;
            }

            set
            {
                _NC_Nro = value;
            }
        }

        public decimal NC_Importe
        {
            get
            {
                return _NC_Importe;
            }

            set
            {
                _NC_Importe = value;
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
