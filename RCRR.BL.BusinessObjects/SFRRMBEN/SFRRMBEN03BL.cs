using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN03BL
    {
         public List<SFRRMBEN03> obtenerRegistros(string descripcion)
        {
            SFRRMBEN03DA objSFRRMBEN03DA = new SFRRMBEN03DA();
            return objSFRRMBEN03DA.obtenerDatosTipOperId(descripcion);
        }

        public string insertarRegistro(SFRRMBEN03 objSFRRMBEN03)
        {

            validaRegistroDatos(objSFRRMBEN03);

            SFRRMBEN03DA objSFRRMBEN03DA = new SFRRMBEN03DA();
            String sCodigo = objSFRRMBEN03DA.insertarRegistroTipOperacion(objSFRRMBEN03);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMBEN03 objSFRRMBEN03)
        {

            validaRegistroDatos(objSFRRMBEN03);

            SFRRMBEN03DA objPersonaDA = new SFRRMBEN03DA();
            objPersonaDA.actualizarRegistroTipoAlmacen(objSFRRMBEN03);
        }

        public void eliminarRegistro(string idSFRRMBEN03)
        {
            SFRRMBEN03DA objSFRRMBEN03DA = new SFRRMBEN03DA();
            objSFRRMBEN03DA.eliminarRegistroTipoAlmance(idSFRRMBEN03);
        }

        private void validaRegistroDatos(SFRRMBEN03 objSFRRMBEN03)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN03.DscAlmacen))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN03.DscAlmacen.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
