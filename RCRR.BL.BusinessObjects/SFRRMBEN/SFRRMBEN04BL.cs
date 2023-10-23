using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN04BL
    {
        public  List<SFRRMBEN04> obtenerRegistros(string descripcion)
        {
            SFRRMBEN04DA objSFRRMBEN04DA = new SFRRMBEN04DA();
            return objSFRRMBEN04DA.obtenerDatosMovimientoId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN04 objSFRRMBEN04)
        {

            validaRegistroDatos(objSFRRMBEN04);

            SFRRMBEN04DA objSFRRMBEN04DA = new SFRRMBEN04DA();

            String sCodigo = objSFRRMBEN04DA.insertarRegistroMovimiento(objSFRRMBEN04);

            return sCodigo;
        }

        public  void actualizarRegistro(SFRRMBEN04 objSFRRMBEN04)
        {

            validaRegistroDatos(objSFRRMBEN04);

            SFRRMBEN04DA objPersonaDA = new SFRRMBEN04DA();
            objPersonaDA.actualizarRegistroMovimiento(objSFRRMBEN04);
        }

        public  void eliminarRegistro(string idSFRRMBEN04)
        {
            SFRRMBEN04DA objSFRRMBEN04DA = new SFRRMBEN04DA();
            objSFRRMBEN04DA.eliminarRegistroMovimiento(idSFRRMBEN04);
        }

        private void validaRegistroDatos(SFRRMBEN04 objSFRRMBEN04)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN04.DscMovimiento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN04.DscMovimiento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
