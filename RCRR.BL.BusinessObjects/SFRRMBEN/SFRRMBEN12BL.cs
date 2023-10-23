using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN12BL
    {
        public static List<SFRRMBEN11> obtenerRegistros(string descripcion)
        {
            SFRRMBEN11DA objSFRRMBEN11DA = new SFRRMBEN11DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN11 objSFRRMBEN11)
        {

            validaRegistroDatos(objSFRRMBEN11);

            SFRRMBEN11DA objSFRRMBEN11DA = new SFRRMBEN11DA();
            objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public static void actualizarRegistro(SFRRMBEN11 objSFRRMBEN11)
        {

            validaRegistroDatos(objSFRRMBEN11);

            SFRRMBEN11DA objPersonaDA = new SFRRMBEN11DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public static void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMBEN11DA objSFRRMBEN11DA = new SFRRMBEN11DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }

        private static void validaRegistroDatos(SFRRMBEN11 objSFRRMBEN11)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN11.NroMovimiento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN11.NroMovimiento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
