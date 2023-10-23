using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN02BL
    {
        public static List<SFRRMBEN02> obtenerRegistros(string descripcion)
        {
            SFRRMBEN02DA objSFRRMBEN02DA = new SFRRMBEN02DA();
            return objSFRRMBEN02DA.obtenerDatosTipAlmacenId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN02 objSFRRMBEN02)
        {

            validaRegistroDatos(objSFRRMBEN02);

            SFRRMBEN02DA objSFRRMBEN02DA = new SFRRMBEN02DA();
            objSFRRMBEN02DA.insertarRegistroTipoAlmacen(objSFRRMBEN02);
        }

        public static void actualizarRegistro(SFRRMBEN02 objSFRRMBEN02)
        {

            validaRegistroDatos(objSFRRMBEN02);

            SFRRMBEN02DA objPersonaDA = new SFRRMBEN02DA();
            objPersonaDA.actualizarRegistroTipoAlmacen(objSFRRMBEN02);
        }

        public static void eliminarRegistro(string idSFRRMBEN02)
        {
            SFRRMBEN02DA objSFRRMBEN02DA = new SFRRMBEN02DA();
            objSFRRMBEN02DA.eliminarRegistroTipoAlmance(idSFRRMBEN02);
        }

        private static void validaRegistroDatos(SFRRMBEN02 objSFRRMBEN02)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN02.DscAlmacen))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN02.DscAlmacen.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
