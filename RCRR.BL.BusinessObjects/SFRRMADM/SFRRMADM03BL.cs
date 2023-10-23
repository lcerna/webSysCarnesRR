using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM03BL
    {
        public static List<SFRRMADM03> obtenerRegistros(int descripcion)
        {
            SFRRMADM03DA objSFRRMADM03DA = new SFRRMADM03DA();
            return objSFRRMADM03DA.obtenerDatos(descripcion);
        }

        public static void insertarRegistro(SFRRMADM03 objSFRRMADM03)
        {

            validaRegistroDatos(objSFRRMADM03);

            SFRRMADM03DA objSFRRMADM03DA = new SFRRMADM03DA();
            objSFRRMADM03DA.insertarRegistro(objSFRRMADM03);
        }

        public static void actualizarRegistro(SFRRMADM03 objSFRRMADM03)
        {

            validaRegistroDatos(objSFRRMADM03);

            SFRRMADM03DA objPersonaDA = new SFRRMADM03DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM03);
        }

        public static void eliminarRegistro(int idSFRRMADM03)
        {
            SFRRMADM03DA objSFRRMADM03DA = new SFRRMADM03DA();
            objSFRRMADM03DA.eliminarRegistro(idSFRRMADM03);
        }

        private static void validaRegistroDatos(SFRRMADM03 objSFRRMADM03)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMADM03.Descripcion))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMADM03.Descripcion.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
