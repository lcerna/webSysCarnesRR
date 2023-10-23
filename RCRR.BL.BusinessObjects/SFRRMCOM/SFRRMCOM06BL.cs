using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;

namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
    public class SFRRMCOM06BL
    {
        public List<SFRRMCOM06> obtenerRegistros(string descripcion)
        {
            SFRRMCOM06DA objSFRRMBEN17DA = new SFRRMCOM06DA();
            return objSFRRMBEN17DA.obtenerDatosId(descripcion);
        }

        public string insertarRegistro(SFRRMCOM06 objSFRRMBEN17)
        {
            validaRegistroDatos(objSFRRMBEN17);

            SFRRMCOM06DA objSFRRMBEN17DA = new SFRRMCOM06DA();
            String sCodigo = objSFRRMBEN17DA.insertarRegistro(objSFRRMBEN17);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMCOM06 objSFRRMBEN17)
        {

            validaRegistroDatos(objSFRRMBEN17);

            SFRRMCOM06DA objPersonaDA = new SFRRMCOM06DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN17);
        }

        public void eliminarRegistro(string idSFRRMBEN17)
        {
            SFRRMCOM06DA objSFRRMBEN17DA = new SFRRMCOM06DA();
            objSFRRMBEN17DA.eliminarRegistro(idSFRRMBEN17);
        }

        private void validaRegistroDatos(SFRRMCOM06 objSFRRMBEN17)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN17.Nombre))
                throw new ArgumentException("Dato Requerido: Descripción");
        }
    }
}
