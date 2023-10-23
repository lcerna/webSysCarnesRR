using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
    public class SFRRMBEN06
    {
        public int Nro {get;set;}
        public string Bien_Codigo{get;set;}
        public string NroMovimiento{get;set;}
        public Decimal Ingreso{get;set;}
        public Decimal Solicita{get;set;}
        public Decimal Despacho{get;set;}
        public Decimal Precio{get;set;}
        public Decimal PrecioUS{get;set;}
        public Decimal PrecioUD{get;set;}
        public string Moneda{get;set;}
        public Decimal TipoCambio{get;set;}
        public string Observacion{get;set;}
        public string NumeroOC{get;set;}
        public string Ped_Codigo{get;set;}
        public string Estado{get;set;}
        public string Usu_Crea{get;set;}
        public DateTime Fec_Crea{get;set;}
        public string Usu_Upd{get;set;}
        public DateTime Fec_Upd { get; set; }
        public string Bie_Codigo { get; set; }
    }
}
