using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;

namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM05DA
    {
        List<SFRRMADM05> obtenerDatos(int Id_Moneda);
        void insertarRegistro(SFRRMADM05 objSFRRMADM05);
        void actualizarRegistro(SFRRMADM05 objSFRRMADM05);
        void eliminarRegistro(int Id_Moneda);
        SFRRMADM05 llenarObjeto(SqlDataReader dr);
    }
}
