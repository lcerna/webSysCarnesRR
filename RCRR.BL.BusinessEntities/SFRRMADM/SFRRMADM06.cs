using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCRR.BL.BusinessEntities.SFRRMADM
{
    public class SFRRMADM06
    {
        public int Id_Tasa_Cambio { set; get; }
        public int Id_Moneda { set; get; }
        public int dia { set; get; }
        public double tip_compra { get; set; }
        public double tip_venta { get; set; }
        public int Estado { set; get; }
        public DateTime Fecha { set; get; }
        public string Usu_Create { set; get; }
        public DateTime Fec_Create { set; get; }
        public string Usu_Update { set; get; }
        public DateTime Fec_Update { set; get; }
        public string Cod_Estado { set; get; }

    }
}
