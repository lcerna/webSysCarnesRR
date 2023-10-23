using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN02DA
    {
        List<SFRRMBEN02> obtenerDatosTipAlmacenId(string TipAlma);
        void insertarRegistroTipoAlmacen(SFRRMBEN02 objSFRRMBEN02);
        void actualizarRegistroTipoAlmacen(SFRRMBEN02 objSFRRMBEN02);
        void eliminarRegistroTipoAlmance(string TipAlma);
        SFRRMBEN02 llenarObjetoTipoAlmacen(SqlDataReader dr);

    }
}
