using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;


namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN01BL
    {
        public List<SFRRMBEN01> obtenerRegistros(string descripcion)
        {
            SFRRMBEN01DA objSFRRMBEN01DA = new SFRRMBEN01DA();
            return objSFRRMBEN01DA.obtenerDatosAlmacenId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN01 objSFRRMBEN01)
        {

            validaRegistroDatos(objSFRRMBEN01);

            SFRRMBEN01DA objSFRRMBEN01DA = new SFRRMBEN01DA();
            String sCodigo = objSFRRMBEN01DA.insertarRegistroAlmacen(objSFRRMBEN01);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMBEN01 objSFRRMBEN01)
        {

            validaRegistroDatos(objSFRRMBEN01);

            SFRRMBEN01DA objPersonaDA = new SFRRMBEN01DA();
            objPersonaDA.actualizarRegistroAlmacen(objSFRRMBEN01);
        }

        public void eliminarRegistro(string idSFRRMBEN01)
        {
            SFRRMBEN01DA objSFRRMBEN01DA = new SFRRMBEN01DA();
            objSFRRMBEN01DA.eliminarRegistroAlmance(idSFRRMBEN01);
        }

        private void validaRegistroDatos(SFRRMBEN01 objSFRRMBEN01)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN01.DscAlmacen))
                throw new ArgumentException("Dato Requerido: Descripción");
        }  
    }
}
