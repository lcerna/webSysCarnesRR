using System;
using System.Collections.Generic;
using RCRR.DA.DataAccessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMVEN;
//using RCRR.DA.DataAccessObjects.SFRRMVEN;

namespace RCRR.BL.BusinessObjects.SFRRMVEN
{
    public class SFRRMVEN05BL
    {
        public List<SFRRMVEN05> obtenerRegistros(string descripcion)
        {
            SFRRMVEN05DA objSFRRMBEN11DA = new SFRRMVEN05DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMVEN05 objSFRRMBEN11)
        {
            SFRRMVEN05DA objSFRRMBEN11DA = new SFRRMVEN05DA();
            return objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public void actualizarRegistro(SFRRMVEN05 objSFRRMBEN11)
        {
            SFRRMVEN05DA objPersonaDA = new SFRRMVEN05DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string sCodigo)
        {
            SFRRMVEN05DA objSFRRMBEN11DA = new SFRRMVEN05DA();
            objSFRRMBEN11DA.eliminarRegistro(sCodigo);
        }
    }
}
