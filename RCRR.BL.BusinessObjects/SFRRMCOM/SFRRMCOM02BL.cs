using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;

namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
   public class SFRRMCOM02BL
    {
        public static List<SFRRMCOM02> obtenerRegistros(string descripcion)
        {
            SFRRMCOM02DA objSFRRMBEN11DA = new SFRRMCOM02DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public static void insertarRegistro(SFRRMCOM02 objSFRRMBEN11)
        {

            validaRegistroDatos(objSFRRMBEN11);

            SFRRMCOM02DA objSFRRMBEN11DA = new SFRRMCOM02DA();
            objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public static void actualizarRegistro(SFRRMCOM02 objSFRRMBEN11)
        {

            validaRegistroDatos(objSFRRMBEN11);

            SFRRMCOM02DA objPersonaDA = new SFRRMCOM02DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public static void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMCOM02DA objSFRRMBEN11DA = new SFRRMCOM02DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }

        private static void validaRegistroDatos(SFRRMCOM02 objSFRRMBEN11)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN11.NroMovimiento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN11.NroMovimiento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
