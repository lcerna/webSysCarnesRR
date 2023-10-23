using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;


namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM04DA
    {
        List<SFRRMADM04> obtenerDatos(int Opcion_Userld);
        void insertarRegistro(SFRRMADM04 objSFRRMADM04);
        void actualizarRegistro(SFRRMADM04 objSFRRMADM04);
        void eliminarRegistro(int Opcion_Userld);
        SFRRMADM04 llenarObjeto(SqlDataReader dr);
    }
}
