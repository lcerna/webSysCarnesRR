using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMCOM;

namespace RCRR.DA.IDataAccessObjects.SFRRMCOM
{
    public interface ISFRRMCOM01DA
    {
        List<SFRRMCOM01> obtenerDatosAlmacenId(string CodAlma);
        void insertarRegistroAlmacen(SFRRMCOM01 objSFRRMBEN01);
        void actualizarRegistroAlmacen(SFRRMCOM01 objSFRRMBEN01);
        void eliminarRegistroAlmance(string CodAlmacen);
        SFRRMCOM01 llenarObjetoAlmacen(SqlDataReader dr);

    }
}
