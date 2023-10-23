using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMCOM
{
    public class SFRRMCOM10
    {
        public String Prov_Codigo {get; set;}
        public String Tip_Doc {get; set;}
        public String Prov_NumDoc {get; set;}
        public String Prov_Nombre { get; set; }
        public String Prov_Direccion {get; set;}
        public String Prov_Telefono {get; set;}
        public String Prov_TipTelf {get; set;}
        public String Prov_Contacto {get; set;}
        public String Prov_email {get; set;}
        public String Prov_Observaciones {get; set;}
        public String Depa {get; set;}
        public String Prov {get; set;}
        public String Dist {get; set;}
        public String Prov_Estado {get; set;}
        public String Usu_Crea {get; set;}
        public DateTime Fec_Crea {get; set;}
        public String Usu_Upd {get; set;}
        public DateTime Fec_upd {get; set;}    
    }

    public class SFRRMCOM10_List
    {
        public string Prov_Codigo { get; set; }
        public string Prov_Nombre { get; set; }
        public String Prov_NumDoc { get; set; }
    }
}
