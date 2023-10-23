using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN03DA
    {
        List<SFRRMBEN03> obtenerDatosTipOperId(string TipOper);
        void insertarRegistroTipOperacion(SFRRMBEN03 objSFRRMBEN03);
        void actualizarRegistroTipoAlmacen(SFRRMBEN03 objSFRRMBEN03);
        void eliminarRegistroTipoAlmance(string TipOper);
        SFRRMBEN03 llenarObjetoAlmacen(SqlDataReader dr);
    }
}
