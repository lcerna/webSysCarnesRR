using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM01BL
    {
        public static List<SFRRMADM01> obtenerRegistros(string descripcion)
        {
            SFRRMADM01DA objSFRRMADM01DA = new SFRRMADM01DA();
            return objSFRRMADM01DA.obtenerDatos(descripcion);
        }

        public static void insertarRegistro(SFRRMADM01 objSFRRMADM01)
        {

            validaRegistroDatos(objSFRRMADM01);

            SFRRMADM01DA objSFRRMADM01DA = new SFRRMADM01DA();
            objSFRRMADM01DA.insertarRegistro(objSFRRMADM01);
        }

        public static void actualizarRegistro(SFRRMADM01 objSFRRMADM01)
        {

            validaRegistroDatos(objSFRRMADM01);

            SFRRMADM01DA objPersonaDA = new SFRRMADM01DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM01);
        }

        public static void eliminarRegistro(string idSFRRMADM01)
        {
            SFRRMADM01DA objSFRRMADM01DA = new SFRRMADM01DA();
            objSFRRMADM01DA.eliminarRegistro(idSFRRMADM01);
        }

        private static void validaRegistroDatos(SFRRMADM01 objSFRRMADM01)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMADM01.Nombre))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMADM01.Nombre.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
