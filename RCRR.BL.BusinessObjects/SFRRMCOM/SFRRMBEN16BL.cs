using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN16BL
    {
        public List<SFRRMBEN16_List> ListarRegistros(string descripcion)
        {
            SFRRMBEN16DA objSFRRMBEN11DA = new SFRRMBEN16DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public SFRRMBEN16 obtenerRegistro(string descripcion)
        {
            SFRRMBEN16DA objSFRRMBEN16DA = new SFRRMBEN16DA();
            return objSFRRMBEN16DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN16 objSFRRMBEN11)
        {
            SFRRMBEN16DA objSFRRMBEN11DA = new SFRRMBEN16DA();

            String Codigo = objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
            return Codigo;
        }

        public void actualizarRegistro(SFRRMBEN16 objSFRRMBEN11)
        {
            SFRRMBEN16DA objPersonaDA = new SFRRMBEN16DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMBEN16DA objSFRRMBEN11DA = new SFRRMBEN16DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }
    }
}
