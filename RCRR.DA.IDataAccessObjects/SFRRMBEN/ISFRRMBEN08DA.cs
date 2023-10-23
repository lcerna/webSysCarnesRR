using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMBEN;

namespace RCRR.DA.IDataAccessObjects.SFRRMBEN
{
    public interface ISFRRMBEN08DA
    {
        List<SFRRMBEN08> obtenerDatosId(string invd_codIde);
        void insertarRegistro(SFRRMBEN08 objSFRRMBEN08);
        void actualizarRegistro(SFRRMBEN08 objSFRRMBEN08);
        void eliminarRegistro(string invd_codIde);
        SFRRMBEN08 llenarObjeto(SqlDataReader dr);

    }
}
