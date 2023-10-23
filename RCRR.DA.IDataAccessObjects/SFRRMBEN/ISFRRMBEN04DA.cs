using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN04DA
    {
        List<SFRRMBEN04> obtenerDatosMovimientoId(string CodMovimiento);
        void insertarRegistroMovimiento(SFRRMBEN04 objSFRRMBEN04);
        void actualizarRegistroMovimiento(SFRRMBEN04 objSFRRMBEN04);
        void eliminarRegistroMovimiento(string CodMovimiento);
        SFRRMBEN04 llenarObjetoTipoAlmacen(SqlDataReader dr);
    }
}
