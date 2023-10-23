using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN10DA
    {
        List<SFRRMBEN10> obtenerDatosId(string GuiaR_Numero);
        void insertarRegistro(SFRRMBEN10 objSFRRMBEN10);
        void actualizarRegistro(SFRRMBEN10 objSFRRMBEN10);
        void eliminarRegistro(string GuiaR_Numero);
        SFRRMBEN10 llenarObjeto(SqlDataReader dr);

    }
}
