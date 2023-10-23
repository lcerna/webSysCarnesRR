using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM04BL
    {
        public static List<SFRRMADM04> obtenerRegistros(int descripcion)
        {
            SFRRMADM04DA objSFRRMADM04DA = new SFRRMADM04DA();
            return objSFRRMADM04DA.obtenerDatos(descripcion);
        }

        public static void insertarRegistro(SFRRMADM04 objSFRRMADM04)
        {

            validaRegistroDatos(objSFRRMADM04);

            SFRRMADM04DA objSFRRMADM04DA = new SFRRMADM04DA();
            objSFRRMADM04DA.insertarRegistro(objSFRRMADM04);
        }

        public static void actualizarRegistro(SFRRMADM04 objSFRRMADM04)
        {

            validaRegistroDatos(objSFRRMADM04);

            SFRRMADM04DA objPersonaDA = new SFRRMADM04DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM04);
        }

        public static void eliminarRegistro(int idSFRRMADM04)
        {
            SFRRMADM04DA objSFRRMADM04DA = new SFRRMADM04DA();
            objSFRRMADM04DA.eliminarRegistro(idSFRRMADM04);
        }

        private static void validaRegistroDatos(SFRRMADM04 objSFRRMADM04)
        {

            //Descripción
            

        }
    }
}
