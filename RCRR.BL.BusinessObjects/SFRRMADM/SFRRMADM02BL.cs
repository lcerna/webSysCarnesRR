using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM02BL
    {
        public List<SFRRMADM02> obtenerRegistros(int descripcion)
        {
            SFRRMADM02DA objSFRRMADM02DA = new SFRRMADM02DA();
            return objSFRRMADM02DA.obtenerDatos(descripcion);
        }

        public List<SFRRMADM02> obtenerRegistros_V2()
        {
            SFRRMADM02DA objSFRRMADM02DA = new SFRRMADM02DA();
            return objSFRRMADM02DA.obtenerDatos_V2();
        }

        public void insertarRegistro(SFRRMADM02 objSFRRMADM02)
        {

            validaRegistroDatos(objSFRRMADM02);

            SFRRMADM02DA objSFRRMADM02DA = new SFRRMADM02DA();
            objSFRRMADM02DA.insertarRegistro(objSFRRMADM02);
        }

        public void actualizarRegistro(SFRRMADM02 objSFRRMADM02)
        {

            validaRegistroDatos(objSFRRMADM02);

            SFRRMADM02DA objPersonaDA = new SFRRMADM02DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM02);
        }

        public void eliminarRegistro(int idSFRRMADM02)
        {
            SFRRMADM02DA objSFRRMADM02DA = new SFRRMADM02DA();
            objSFRRMADM02DA.eliminarRegistro(idSFRRMADM02);
        }

       
        private void validaRegistroDatos(SFRRMADM02 objSFRRMADM02)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMADM02.Nombre_Tipo))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMADM02.Nombre_Tipo.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
