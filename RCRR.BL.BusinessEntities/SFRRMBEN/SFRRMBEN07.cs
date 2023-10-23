using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMBEN
{
   public class SFRRMBEN07
    {
    public int inv_codIde{get;set;}
	public string inv_descripcion{get;set;}
	public DateTime inv_fecha{get;set;}
	public Decimal inv_tipo{get;set;}
	public Decimal inv_estado{get;set;}
	public string Usu_Crea{get;set;}
    public DateTime Fec_Crea { get; set; }
	public string Usu_Upd{get;set;}
    public DateTime Fec_Upd { get; set; }
    public int aud_status { get; set; }
    }
}
