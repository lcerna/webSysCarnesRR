using System;
using System.Collections.Generic;
using RCRR.DA.DataAccessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMVEN;
//using RCRR.DA.DataAccessObjects.SFRRMVEN;

namespace RCRR.BL.BusinessObjects.SFRRMVEN
{
    public class SFRRMVEN06BL
    {
        public List<SFRRMVEN06> obtenerRegistros(string descripcion)
        {
            SFRRMVEN06DA objSFRRMBEN11DA = new SFRRMVEN06DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMVEN06 objSFRRMBEN11)
        {
            SFRRMVEN06DA objSFRRMBEN11DA = new SFRRMVEN06DA();
            return objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public void actualizarRegistro(SFRRMVEN06 objSFRRMBEN11)
        {
            SFRRMVEN06DA objPersonaDA = new SFRRMVEN06DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string sCodigo)
        {
            SFRRMVEN06DA objSFRRMBEN11DA = new SFRRMVEN06DA();
            objSFRRMBEN11DA.eliminarRegistro(sCodigo);
        }
    }
}
