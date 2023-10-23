using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN11DA
    {
        List<SFRRMBEN11> obtenerDatosId(string GuiaRD_Codi);
        void insertarRegistro(SFRRMBEN11 objSFRRMBEN11);
        void actualizarRegistro(SFRRMBEN11 objSFRRMBEN11);
        void eliminarRegistro(string GuiaRD_Codi);
        SFRRMBEN11 llenarObjeto(SqlDataReader dr);
    }
}
