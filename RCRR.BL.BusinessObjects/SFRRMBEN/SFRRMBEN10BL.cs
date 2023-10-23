using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN10BL
    {
        public static List<SFRRMBEN10> obtenerRegistros(string descripcion)
        {
            SFRRMBEN10DA objSFRRMBEN10DA = new SFRRMBEN10DA();
            return objSFRRMBEN10DA.obtenerDatosId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN10 objSFRRMBEN10)
        {

            validaRegistroDatos(objSFRRMBEN10);

            SFRRMBEN10DA objSFRRMBEN10DA = new SFRRMBEN10DA();
            objSFRRMBEN10DA.insertarRegistro(objSFRRMBEN10);
        }

        public static void actualizarRegistro(SFRRMBEN10 objSFRRMBEN10)
        {

            validaRegistroDatos(objSFRRMBEN10);

            SFRRMBEN10DA objPersonaDA = new SFRRMBEN10DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN10);
        }

        public static void eliminarRegistro(string idSFRRMBEN10)
        {
            SFRRMBEN10DA objSFRRMBEN10DA = new SFRRMBEN10DA();
            objSFRRMBEN10DA.eliminarRegistro(idSFRRMBEN10);
        }

        private static void validaRegistroDatos(SFRRMBEN10 objSFRRMBEN10)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN10.CodMovimiento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN10.CodMovimiento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
