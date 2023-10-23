using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
    public class SFRRMBEN09
    {
        	public int stk_codIde{get;set;}
	        public string CodAlmacen{get;set;}
	        public string Bie_Codigo{get;set;}
	        public int stk_cantMin{get;set;}
            public int stk_canMax{ get; set; }
	        public int stk_stockDocs{get;set;}
            public int stk_stockReal { get; set; }
	        public string Usu_Crea{get;set;}
	        public DateTime Fec_Crea{get;set;}
	        public string Usu_Upd {get;set;}
            public DateTime Fec_Upd { get; set; }
    }
}
