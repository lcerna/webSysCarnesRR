using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM05BL
    {
        public  List<SFRRMADM05> obtenerRegistros(int descripcion)
        {
            SFRRMADM05DA objSFRRMADM05DA = new SFRRMADM05DA();
            return objSFRRMADM05DA.obtenerDatos(descripcion);
        }

        public  void insertarRegistro(SFRRMADM05 objSFRRMADM05)
        {

            validaRegistroDatos(objSFRRMADM05);

            SFRRMADM05DA objSFRRMADM05DA = new SFRRMADM05DA();
            objSFRRMADM05DA.insertarRegistro(objSFRRMADM05);
        }

        public  void actualizarRegistro(SFRRMADM05 objSFRRMADM05)
        {

            validaRegistroDatos(objSFRRMADM05);

            SFRRMADM05DA objPersonaDA = new SFRRMADM05DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM05);
        }

        public static void eliminarRegistro(int idSFRRMADM05)
        {
            SFRRMADM05DA objSFRRMADM05DA = new SFRRMADM05DA();
            objSFRRMADM05DA.eliminarRegistro(idSFRRMADM05);
        }

        private void validaRegistroDatos(SFRRMADM05 objSFRRMADM05)
        {

            //Descripción
            

        }
    }
}
