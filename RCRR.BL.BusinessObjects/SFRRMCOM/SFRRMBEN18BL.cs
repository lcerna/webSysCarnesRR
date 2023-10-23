using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;


namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN18BL
    {
        public List<SFRRMBEN18> obtenerRegistros(string descripcion)
        {
            SFRRMBEN18DA objSFRRMBEN18DA = new SFRRMBEN18DA();
            return objSFRRMBEN18DA.obtenerDatosAlmacenId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN18 objSFRRMBEN18)
        {

            validaRegistroDatos(objSFRRMBEN18);

            SFRRMBEN18DA objSFRRMBEN18DA = new SFRRMBEN18DA();
            String sCodigo = objSFRRMBEN18DA.insertarRegistroAlmacen(objSFRRMBEN18);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMBEN18 objSFRRMBEN18)
        {

            validaRegistroDatos(objSFRRMBEN18);

            SFRRMBEN18DA objPersonaDA = new SFRRMBEN18DA();
            objPersonaDA.actualizarRegistroAlmacen(objSFRRMBEN18);
        }

        public void eliminarRegistro(string idSFRRMBEN18)
        {
            SFRRMBEN18DA objSFRRMBEN18DA = new SFRRMBEN18DA();
            objSFRRMBEN18DA.eliminarRegistroAlmance(idSFRRMBEN18);
        }

        private void validaRegistroDatos(SFRRMBEN18 objSFRRMBEN18)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN18.Descripcion))
                throw new ArgumentException("Dato Requerido: Descripción");
        }  
    }
}
