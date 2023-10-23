using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;

namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM06DA
    {
        List<SFRRMADM05> obtenerDatos(int Id_Tasa_Cambio);
        void insertarRegistro(SFRRMADM05 objSFRRMADM05);
        void actualizarRegistro(SFRRMADM05 objSFRRMADM05);
        void eliminarRegistro(int Id_Tasa_Cambio);
        SFRRMADM05 llenarObjeto(SqlDataReader dr);
    }
}
