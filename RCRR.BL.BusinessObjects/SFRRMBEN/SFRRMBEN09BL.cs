using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN09BL
    {
        public static List<SFRRMBEN09> obtenerRegistros(string descripcion)
        {
            SFRRMBEN09DA objSFRRMBEN09DA = new SFRRMBEN09DA();
            return objSFRRMBEN09DA.obtenerDatosId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN09 objSFRRMBEN09)
        {

            validaRegistroDatos(objSFRRMBEN09);

            SFRRMBEN09DA objSFRRMBEN09DA = new SFRRMBEN09DA();
            objSFRRMBEN09DA.insertarRegistro(objSFRRMBEN09);
        }

        public static void actualizarRegistro(SFRRMBEN09 objSFRRMBEN09)
        {

            validaRegistroDatos(objSFRRMBEN09);

            SFRRMBEN09DA objPersonaDA = new SFRRMBEN09DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN09);
        }

        public static void eliminarRegistro(string idSFRRMBEN09)
        {
            SFRRMBEN09DA objSFRRMBEN09DA = new SFRRMBEN09DA();
            objSFRRMBEN09DA.eliminarRegistro(idSFRRMBEN09);
        }

        private static void validaRegistroDatos(SFRRMBEN09 objSFRRMBEN09)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN09.CodAlmacen))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN09.CodAlmacen.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
