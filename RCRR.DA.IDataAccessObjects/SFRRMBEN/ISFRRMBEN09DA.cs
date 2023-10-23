using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN09DA
    {
        List<SFRRMBEN09> obtenerDatosId(string stk_codIde);
        void insertarRegistro(SFRRMBEN09 objSFRRMBEN09);
        void actualizarRegistro(SFRRMBEN09 objSFRRMBEN09);
        void eliminarRegistro(string stk_codIde);
        SFRRMBEN09 llenarObjeto(SqlDataReader dr);
    }
}
