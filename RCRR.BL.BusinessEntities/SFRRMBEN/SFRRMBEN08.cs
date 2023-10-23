using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
    public class SFRRMBEN08
    {
            public int invd_codIde {get;set;}
	        public int inv_codIde {get;set;}
	        public string CodAlmacen {get;set;}
	        public string Bie_Codigo {get;set;}
	        public int invd_estado{get;set;}
	        public int invd_stockDoc{get;set;}
	        public int invd_stockDocAnterior{get;set;}
	        public int invd_stockReal{get;set;}
	        public int invd_stockRealAnterior{get;set;}
	        public Decimal invd_valor{get;set;}
	        public string Usu_Crea{get;set;}
	        public DateTime Fec_Crea{get;set;}
	        public string Usu_Upd{get;set;}
	        public DateTime Fec_Upd{get;set;}
    }
}
