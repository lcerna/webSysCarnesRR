using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN17BL
    {
        public List<SFRRMBEN17> obtenerRegistros(string descripcion)
        {
            SFRRMBEN17DA objSFRRMBEN17DA = new SFRRMBEN17DA();
            return objSFRRMBEN17DA.obtenerDatosId(descripcion);
        }

        public string insertarRegistro(SFRRMBEN17 objSFRRMBEN17)
        {
            validaRegistroDatos(objSFRRMBEN17);

            SFRRMBEN17DA objSFRRMBEN17DA = new SFRRMBEN17DA();
            String sCodigo = objSFRRMBEN17DA.insertarRegistro(objSFRRMBEN17);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMBEN17 objSFRRMBEN17)
        {

            validaRegistroDatos(objSFRRMBEN17);

            SFRRMBEN17DA objPersonaDA = new SFRRMBEN17DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN17);
        }

        public void eliminarRegistro(string idSFRRMBEN17)
        {
            SFRRMBEN17DA objSFRRMBEN17DA = new SFRRMBEN17DA();
            objSFRRMBEN17DA.eliminarRegistro(idSFRRMBEN17);
        }

        private void validaRegistroDatos(SFRRMBEN17 objSFRRMBEN17)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN17.Nombre))
                throw new ArgumentException("Dato Requerido: Descripción");
        }
    }
}
