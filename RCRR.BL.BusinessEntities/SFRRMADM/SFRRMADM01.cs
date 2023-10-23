using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMADM
{
   public class SFRRMADM01
    {
        public int Id_Usuario { set; get; }
        public int Id_Tipo_Usuaio { set; get; }
        public string Estado { set; get; }
        public string Contraseña  { set; get; }
        public string Nombre_Usuario { set; get; }
        public string Nombre { set; get; }
        public string Usu_Create { set; get; }
        public DateTime Fec_Create { set; get; }
        public string Usu_Update { set; get; }
        public DateTime Fec_Update { set; get; }
        public string Cod_Estado { set; get; }



    }
}
