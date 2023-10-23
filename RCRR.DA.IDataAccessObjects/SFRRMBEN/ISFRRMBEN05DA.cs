using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN05DA
    {
        List<SFRRMBEN05> obtenerDatosMovimientoId(string NroMovimiento);
        void insertarRegistroMovimiento(SFRRMBEN05 objSFRRMBEN05);
        void eliminarRegistroMovimiento(string NroMovimiento);
        SFRRMBEN05 llenarObjetoTipoAlmacen(SqlDataReader dr);
    }
}
