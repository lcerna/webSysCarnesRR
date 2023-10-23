using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;

namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM02DA
    {
        List<SFRRMADM02> obtenerDatos(int Id_Tipo_Usuaio);
        List<SFRRMADM02> obtenerDatos2();
        void insertarRegistro(SFRRMADM02 objSFRRMADM02);
        void actualizarRegistro(SFRRMADM02 objSFRRMADM02);
        void eliminarRegistro(int Id_Tipo_Usuaio);
        SFRRMADM02 llenarObjeto(SqlDataReader dr);
    }
}
