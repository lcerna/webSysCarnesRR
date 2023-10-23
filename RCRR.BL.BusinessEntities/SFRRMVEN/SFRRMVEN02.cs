using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMVEN
{
    public class SFRRMVEN02
    {
        public string Cue_Codigo {get; set;}
        public string Ban_Codigo {get; set;}
        public string Cuenta {get; set;}
        public string Cue_Tipo { get; set; }
        public int Cue_Estado {get; set;}
        public string Cta_numero {get; set;}
        public decimal Cue_SInicial {get; set;}
        public decimal Cue_SActual {get; set;}
        public string Usu_Crea {get; set;}
        public DateTime Fec_Crea {get; set;}
        public string Usu_Upd {get; set;}
        public DateTime Fec_Upd {get; set;}



    }
}
