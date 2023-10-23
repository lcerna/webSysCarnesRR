using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN06DA
    {
        List<SFRRMBEN06> obtenerDatosMovimientoBienId(int Nro, string Bien_Codigo);
        void insertarRegistroMovimiento_Bien(SFRRMBEN06 objSFRRMBEN06);
        void actualizarRegistroMovimiento_Bien(SFRRMBEN06 objSFRRMBEN06);
        void eliminarRegistroMovimiento_Bien(int Nro, string Bien_Codigo);
        SFRRMBEN06 llenarObjeto(SqlDataReader dr);
    }
}
