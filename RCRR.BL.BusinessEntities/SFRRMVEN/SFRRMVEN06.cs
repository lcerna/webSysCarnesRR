using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMVEN
{
    public class SFRRMVEN06
    {
        public int DetF_ID {get; set;}
        public String Fac_Codigo {get; set;}
        public String DetF_ISCodi {get; set;}
        public String DetF_Orden { get; set; }
        public decimal DetF_Cantida {get; set;}
        public decimal DetF_Precio {get; set;}
        public decimal DetF_ValorVenta {get; set;}
        public decimal DetF_ValorCosto {get; set;}
        public String Usu_Crea {get; set;}
        public DateTime Fec_Crea {get; set;}  
        public String Usu_Upd {get; set;}
        public DateTime Fec_Upd {get; set;} 
        public String CodAlmacen {get; set;}
     }
}
