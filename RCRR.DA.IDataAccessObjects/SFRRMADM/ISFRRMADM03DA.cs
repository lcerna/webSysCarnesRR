using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;


namespace RCRR.DA.IDataAccessObjects.SFRRMADM
{
    public interface ISFRRMADM03DA
    {
        List<SFRRMADM03> obtenerDatos(int Id_Opcion);
        void insertarRegistro(SFRRMADM03 objSFRRMADM03);
        void actualizarRegistro(SFRRMADM03 objSFRRMADM03);
        void eliminarRegistro(int Id_Opcion);
        SFRRMADM03 llenarObjeto(SqlDataReader dr);
    }
}
