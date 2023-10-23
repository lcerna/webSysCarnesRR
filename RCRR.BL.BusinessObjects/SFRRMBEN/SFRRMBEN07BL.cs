using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN07BL
    {
        public static List<SFRRMBEN07> obtenerRegistros(string descripcion)
        {
            SFRRMBEN07DA objSFRRMBEN07DA = new SFRRMBEN07DA();
            return objSFRRMBEN07DA.obtenerDatosMovimientoId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN07 objSFRRMBEN07)
        {

            validaRegistroDatos(objSFRRMBEN07);

            SFRRMBEN07DA objSFRRMBEN07DA = new SFRRMBEN07DA();
            objSFRRMBEN07DA.insertarRegistroMovimiento(objSFRRMBEN07);
        }

        public static void actualizarRegistro(SFRRMBEN07 objSFRRMBEN07)
        {

            validaRegistroDatos(objSFRRMBEN07);

            SFRRMBEN07DA objPersonaDA = new SFRRMBEN07DA();
            objPersonaDA.actualizarRegistroMovimiento(objSFRRMBEN07);
        }

        public static void eliminarRegistro(string idSFRRMBEN07)
        {
            SFRRMBEN07DA objSFRRMBEN07DA = new SFRRMBEN07DA();
            objSFRRMBEN07DA.eliminarRegistroMovimiento(idSFRRMBEN07);
        }

        private static void validaRegistroDatos(SFRRMBEN07 objSFRRMBEN07)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN07.inv_descripcion))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN07.inv_descripcion.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
