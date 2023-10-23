using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;


namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM01DA
    {
        List<SFRRMADM01> obtenerDatos(string Id_Usuario);
        void insertarRegistro(SFRRMADM01 objSFRRMADM01);
        void actualizarRegistro(SFRRMADM01 objSFRRMADM01);
        void eliminarRegistro(string Id_Usuario);
        SFRRMADM01 llenarObjeto(SqlDataReader dr);
    }
}
