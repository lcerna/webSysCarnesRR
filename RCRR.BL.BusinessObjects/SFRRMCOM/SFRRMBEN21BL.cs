using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN21BL
    {
        public List<SFRRMBEN21_List> ListarRegistros(string descripcion)
        {
            SFRRMBEN21DA objSFRRMBEN11DA = new SFRRMBEN21DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public SFRRMBEN21 obtenerRegistros(string descripcion)
        {
            SFRRMBEN21DA objSFRRMBEN11DA = new SFRRMBEN21DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN21 objSFRRMBEN11)
        {
            SFRRMBEN21DA objSFRRMBEN11DA = new SFRRMBEN21DA();
            return objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public void actualizarRegistro(SFRRMBEN21 objSFRRMBEN11)
        {
            SFRRMBEN21DA objPersonaDA = new SFRRMBEN21DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string sCodigo)
        {
            SFRRMBEN21DA objSFRRMBEN11DA = new SFRRMBEN21DA();
            objSFRRMBEN11DA.eliminarRegistro(sCodigo);
        }
    }
}
