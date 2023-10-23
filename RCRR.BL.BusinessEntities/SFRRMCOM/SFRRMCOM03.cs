using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMCOM
{
    public class SFRRMCOM03
    {
        	public string NotCom_Id{get;set;}
	        public DateTime Not_Com_Fecha{get;set;}
	        public string Ped_Codigo{get;set;}
	        public string Requerido{get;set;}
	        public string CDestino{get;set;}
	        public Decimal Tcambio{get;set;}
	        public int Incluye_Igv{get;set;}
	        public int Moneda{get;set;}
	        public Decimal SubTotal{get;set;}
	        public Decimal Igv{get;set;}
            public Decimal Monto { get; set; }
            public string Observacion { get; set; }
            public string semana { get; set; }
     }
    public class SFRRMCOM03_List
    {
        public string NotCom_Id { get; set; }
        public DateTime Not_Com_Fecha { get; set; }
        public Decimal Monto { get; set; }
    }
}
