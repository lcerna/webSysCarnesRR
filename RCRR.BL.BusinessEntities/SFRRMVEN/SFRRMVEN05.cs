using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMVEN
{
    public class SFRRMVEN05
    {
        public String Fac_Codigo { get; set; }
        public String Cli_Codigo { get; set; }
        public DateTime Fac_Fecha { get; set; }
        public decimal Fac_Semana { get; set; }
        public String Fac_Tdocu { get; set; }
        public String Fac_Ndocu { get; set; }
        public decimal Fac_Subtotal { get; set; }
        public decimal Fac_Igv { get; set; }
        public decimal Fac_Total { get; set; }
        public decimal Fac_Saldo { get; set; }
        public decimal Fac_Descuento { get; set; }
        public String Fac_Estado { get; set; }
        public String Fac_Glosa { get; set; }
        public String IncluyeIGV { get; set; }
        public String Fac_Moneda { get; set; }
        public decimal Fac_TCambio { get; set; }
        public String Fac_MotAnulacion { get; set; }
        public String Usu_Crea { get; set; }
        public DateTime Fec_Crea { get; set; }
        public String Usu_Upd { get; set; }
        public DateTime Fec_Upd { get; set; }
        public String UsuAnulo { get; set; }
        public DateTime FAnulada { get; set; } 
    }
}
