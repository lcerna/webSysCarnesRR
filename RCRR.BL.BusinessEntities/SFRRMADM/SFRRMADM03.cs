using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMADM
{
    public class SFRRMADM03
    {
        public int Id_Opcion { set; get; }
        public int padre { set; get; }
        public int orden { set; get; }
        public string url { set; get; }
        public string Descripcion { set; get; }
        public string Usu_Create { set; get; }
        public DateTime Fec_Create { set; get; }
        public string Usu_Update { set; get; }
        public DateTime Fec_Update { set; get; }
        public string Cod_Estado { set; get; }
    }
}
