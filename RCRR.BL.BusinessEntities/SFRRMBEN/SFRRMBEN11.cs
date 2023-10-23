using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
    public class SFRRMBEN11
    {
        	public int GuiaRD_Codi{get;set;}
	        public string GuiaR_Numero{get;set;}
	        public string NroMovimiento{get;set;}
	        public string Ped_Codigo{get;set;}
	        public string Bie_Codigo{get;set;}
	        public Decimal GuiaRD_Cantidad{get;set;}
	        public string GuiaRD_Adicional{get;set;}
	        public string GuiaR_Nuevo_Usuario{get;set;}
	        public DateTime GuiaR_Nuevo_Fecha{get;set;}
	        public string Usu_Upd{get;set;}
            public DateTime Fec_Upd { get; set; }
    }
}
