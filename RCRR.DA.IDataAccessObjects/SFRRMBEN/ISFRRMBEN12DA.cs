using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN12DA
    {
        List<SFRRMBEN01> obtenerDatosAlmacenId(string CodAlma);
        void insertarRegistroAlmacen(SFRRMBEN01 objSFRRMBEN01);
        void actualizarRegistroAlmacen(SFRRMBEN01 objSFRRMBEN01);
        void eliminarRegistroAlmance(string CodAlmacen);
        SFRRMBEN01 llenarObjetoAlmacen(SqlDataReader dr);
    }
}
