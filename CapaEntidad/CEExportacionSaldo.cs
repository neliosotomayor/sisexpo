using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEExportacionSaldo
    {

        private int _Exp_Id;
        private int _Cliente_Id;
        private string _Cli_Nombre;    //Nuevo
        private string _Exp_FacturaFecha;
        private string _Exp_FacturaNro;
        private long _Exp_FacturaCajas;
        private decimal _Exp_FacturaImporte;
        private int _Producto_Id;
        private string _Pro_Nombre;    //Nuevo
        private string _Exp_Contenedor;
        private string _Exp_Booking;
        private string _Exp_DUA;
        private int _Operador_Id;
        private string _Ope_Nombre;    //Nuevo
        private string _Exp_Transporte;
        private int _Puerto_IdOrigen;
        private string _Pue_OrigenNombre;    //Nuevo
        private string _Exp_ETD;
        private string _Exp_TTD;
        private int _Puerto_IdDestino;
        private string _Pue_DestinoNombre;    //Nuevo
        private string _Exp_ETA;
        private string _Exp_TTA;
        private string _Exp_EstadoNave;
        private string _Comentario;
        private decimal _Abonos;
        private decimal _NC;
        private decimal _Saldo;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Exp_Id
        {
            get
            {
                return _Exp_Id;
            }

            set
            {
                _Exp_Id = value;
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

        public string Exp_FacturaFecha
        {
            get
            {
                return _Exp_FacturaFecha;
            }

            set
            {
                _Exp_FacturaFecha = value;
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

        public long Exp_FacturaCajas
        {
            get
            {
                return _Exp_FacturaCajas;
            }

            set
            {
                _Exp_FacturaCajas = value;
            }
        }

        public decimal Exp_FacturaImporte
        {
            get
            {
                return _Exp_FacturaImporte;
            }

            set
            {
                _Exp_FacturaImporte = value;
            }
        }

        public int Producto_Id
        {
            get
            {
                return _Producto_Id;
            }

            set
            {
                _Producto_Id = value;
            }
        }

        public string Pro_Nombre
        {
            get
            {
                return _Pro_Nombre;
            }

            set
            {
                _Pro_Nombre = value;
            }
        }

        public string Exp_Contenedor
        {
            get
            {
                return _Exp_Contenedor;
            }

            set
            {
                _Exp_Contenedor = value;
            }
        }

        public string Exp_Booking
        {
            get
            {
                return _Exp_Booking;
            }

            set
            {
                _Exp_Booking = value;
            }
        }

        public string Exp_DUA
        {
            get
            {
                return _Exp_DUA;
            }

            set
            {
                _Exp_DUA = value;
            }
        }

        public int Operador_Id
        {
            get
            {
                return _Operador_Id;
            }

            set
            {
                _Operador_Id = value;
            }
        }

        public string Ope_Nombre
        {
            get
            {
                return _Ope_Nombre;
            }

            set
            {
                _Ope_Nombre = value;
            }
        }

        public string Exp_Transporte
        {
            get
            {
                return _Exp_Transporte;
            }

            set
            {
                _Exp_Transporte = value;
            }
        }

        public int Puerto_IdOrigen
        {
            get
            {
                return _Puerto_IdOrigen;
            }

            set
            {
                _Puerto_IdOrigen = value;
            }
        }

        public string Pue_OrigenNombre
        {
            get
            {
                return _Pue_OrigenNombre;
            }

            set
            {
                _Pue_OrigenNombre = value;
            }
        }

        public string Exp_ETD
        {
            get
            {
                return _Exp_ETD;
            }

            set
            {
                _Exp_ETD = value;
            }
        }

        public string Exp_TTD
        {
            get
            {
                return _Exp_TTD;
            }

            set
            {
                _Exp_TTD = value;
            }
        }

        public int Puerto_IdDestino
        {
            get
            {
                return _Puerto_IdDestino;
            }

            set
            {
                _Puerto_IdDestino = value;
            }
        }

        public string Pue_DestinoNombre
        {
            get
            {
                return _Pue_DestinoNombre;
            }

            set
            {
                _Pue_DestinoNombre = value;
            }
        }

        public string Exp_ETA
        {
            get
            {
                return _Exp_ETA;
            }

            set
            {
                _Exp_ETA = value;
            }
        }

        public string Exp_TTA
        {
            get
            {
                return _Exp_TTA;
            }

            set
            {
                _Exp_TTA = value;
            }
        }

        public string Exp_EstadoNave
        {
            get
            {
                return _Exp_EstadoNave;
            }

            set
            {
                _Exp_EstadoNave = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _Comentario;
            }

            set
            {
                _Comentario = value;
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

        public decimal Abonos
        {
            get
            {
                return _Abonos;
            }

            set
            {
                _Abonos = value;
            }
        }

        public decimal NC
        {
            get
            {
                return _NC;
            }

            set
            {
                _NC = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return _Saldo;
            }

            set
            {
                _Saldo = value;
            }
        }

    }
}
