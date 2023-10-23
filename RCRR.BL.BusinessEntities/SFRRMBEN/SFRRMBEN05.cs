using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
    public class SFRRMBEN05
    {
       public string NroMovimiento {get;set;}
       public string CodAlmacen{get;set;}
       public DateTime Fecha{get;set;}
       public decimal Semana{get;set;}
       public string Prov_Codigo{get;set;}
       public string Estado{get;set;}
       public string TipOper{get;set;}
       public string CodMovimiento {get;set;}
       public string CDocumento{get;set;}
       public string NroDocumento{get;set;}
       public DateTime FecDocumento {get;set;}
       public string Destino {get;set;}
       public string IncluyeIGV{get;set;}
       public decimal Total{get;set;}
       public string Moneda{get;set;}
       public decimal TipoCambio{get;set;} 
       public string Observacion{get;set;} 
       public DateTime UsuarioFEC{get;set;}
       public string Anu_Motivo{get;set;}
       public string Anu_Usuario{get;set;} 
       public DateTime Anu_Fecha{get;set;}
       public string Usu_Crea{get;set;}
       public DateTime Fec_Crea{get;set;}
       public string Usu_Upd{get;set;}
       public DateTime Fec_Upd { get; set; }
    }
    }