using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMVEN
{
    public class SFRRMVEN03
    {
        public String Cli_Codigo {get; set;}
        public String CDocumento {get; set;}
        public String Cli_NumDocu {get; set;}
        public String Cli_RazonSocial { get; set; }
        public String Cli_ApePat {get; set;}
        public String Cli_ApeMat {get; set;}
        public String Cli_Nombre {get; set;}
        public String Cli_Direccion {get; set;}
        public String Cli_Referencia {get; set;}
        public String Cli_Contacto {get; set;}
        public String Depa {get; set;}
        public String Prov {get; set;}
        public String Dist {get; set;}
        public String Cli_email {get; set;}
        public String Cli_TipTef {get; set;}
        public String Cli_NumTelf {get; set;}
        public String Cli_Estado {get; set;}
        public String Usu_Crea {get; set;}
        public DateTime Fec_Crea {get; set;}  
        public String Usu_Upd {get; set;}
        public DateTime Fec_Upd {get; set;}  
    }

    public class SFRRMVEN03_List
    {
        public String Cli_Codigo {get; set;}
        public String Cli_NumDocu {get; set;}
        public String Cli_RazonSocial { get; set; }
    }

}
