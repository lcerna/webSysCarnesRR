using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;


namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
    public class SFRRMCOM07BL
    {
        public List<SFRRMCOM07> obtenerRegistros(string descripcion)
        {
            SFRRMCOM07DA objSFRRMBEN18DA = new SFRRMCOM07DA();
            return objSFRRMBEN18DA.obtenerDatosAlmacenId(descripcion);
        }

        public String insertarRegistro(SFRRMCOM07 objSFRRMBEN18)
        {

            validaRegistroDatos(objSFRRMBEN18);

            SFRRMCOM07DA objSFRRMBEN18DA = new SFRRMCOM07DA();
            String sCodigo = objSFRRMBEN18DA.insertarRegistroAlmacen(objSFRRMBEN18);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMCOM07 objSFRRMBEN18)
        {

            validaRegistroDatos(objSFRRMBEN18);

            SFRRMCOM07DA objPersonaDA = new SFRRMCOM07DA();
            objPersonaDA.actualizarRegistroAlmacen(objSFRRMBEN18);
        }

        public void eliminarRegistro(string idSFRRMBEN18)
        {
            SFRRMCOM07DA objSFRRMBEN18DA = new SFRRMCOM07DA();
            objSFRRMBEN18DA.eliminarRegistroAlmance(idSFRRMBEN18);
        }

        private void validaRegistroDatos(SFRRMCOM07 objSFRRMBEN18)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN18.Descripcion))
                throw new ArgumentException("Dato Requerido: Descripción");
        }
    }
}
