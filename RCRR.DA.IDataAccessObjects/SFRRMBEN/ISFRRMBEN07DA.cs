using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;


namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN07DA
    {
        List<SFRRMBEN07> obtenerDatosMovimientoId(string inv_codIde);
        void insertarRegistroMovimiento(SFRRMBEN07 objSFRRMBEN07);
        void actualizarRegistroMovimiento(SFRRMBEN07 objSFRRMBEN07);
        void eliminarRegistroMovimiento(string inv_codIde);
        SFRRMBEN07 llenarObjeto(SqlDataReader dr);
    }
}
