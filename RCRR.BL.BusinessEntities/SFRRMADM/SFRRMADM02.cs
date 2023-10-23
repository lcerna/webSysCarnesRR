using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMADM
{
    public class SFRRMADM02
    {
        public int Id_Tipo_Usuario { set; get; }
        public string Nombre_Tipo { set; get; }
        public string Estado { set; get; }
        public string Usu_Create { set; get; }
        public DateTime Fec_Create { set; get; }
        public string Usu_Update { set; get; }
        public DateTime Fec_Update { set; get; }
        public string Cod_Estado { set; get; }

    }
}

