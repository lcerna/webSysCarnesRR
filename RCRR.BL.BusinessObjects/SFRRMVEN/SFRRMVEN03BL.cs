using System;
using System.Collections.Generic;
using RCRR.DA.DataAccessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMVEN;
//using RCRR.DA.DataAccessObjects.SFRRMVEN;

namespace RCRR.BL.BusinessObjects.SFRRMVEN
{
    public class SFRRMVEN03BL
    {
        public List<SFRRMVEN03_List> listarRegistros(string descripcion)
        {
            SFRRMVEN03DA objSFRRMBEN11DA = new SFRRMVEN03DA();
            return objSFRRMBEN11DA.listarRegistros(descripcion);
        }

        public SFRRMVEN03 obtenerRegistros(string descripcion)
        {
            SFRRMVEN03DA objSFRRMBEN11DA = new SFRRMVEN03DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMVEN03 objSFRRMBEN11)
        {
            SFRRMVEN03DA objSFRRMBEN11DA = new SFRRMVEN03DA();
            return objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public void actualizarRegistro(SFRRMVEN03 objSFRRMBEN11)
        {
            SFRRMVEN03DA objPersonaDA = new SFRRMVEN03DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string sCodigo)
        {
            SFRRMVEN03DA objSFRRMBEN11DA = new SFRRMVEN03DA();
            objSFRRMBEN11DA.eliminarRegistro(sCodigo);
        }
    }
}
