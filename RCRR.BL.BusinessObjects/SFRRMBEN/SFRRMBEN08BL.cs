using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN08BL
    {
        public static List<SFRRMBEN08> obtenerRegistros(string descripcion)
        {
            SFRRMBEN08DA objSFRRMBEN08DA = new SFRRMBEN08DA();
            return objSFRRMBEN08DA.obtenerDatosId(descripcion);
        }

        public static void insertarRegistro(SFRRMBEN08 objSFRRMBEN08)
        {

            validaRegistroDatos(objSFRRMBEN08);

            SFRRMBEN08DA objSFRRMBEN08DA = new SFRRMBEN08DA();
            objSFRRMBEN08DA.insertarRegistro(objSFRRMBEN08);
        }

        public static void actualizarRegistro(SFRRMBEN08 objSFRRMBEN08)
        {

            validaRegistroDatos(objSFRRMBEN08);

            SFRRMBEN08DA objPersonaDA = new SFRRMBEN08DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN08);
        }

        public static void eliminarRegistro(string idSFRRMBEN08)
        {
            SFRRMBEN08DA objSFRRMBEN08DA = new SFRRMBEN08DA();
            objSFRRMBEN08DA.eliminarRegistro(idSFRRMBEN08);
        }

        private static void validaRegistroDatos(SFRRMBEN08 objSFRRMBEN08)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN08.CodAlmacen))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN08.CodAlmacen.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
