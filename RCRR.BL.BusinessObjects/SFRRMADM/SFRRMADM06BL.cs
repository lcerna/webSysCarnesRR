using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;

namespace RCRR.BL.BusinessObjects.SFRRMADM
{
    public class SFRRMADM06BL
    {
        public List<SFRRMADM06> obtenerRegistros(int Id_Tasa_Cambio, int Id_Moneda, DateTime Fecha)
        {
            SFRRMADM06DA objSFRRMADM06DA = new SFRRMADM06DA();
            return objSFRRMADM06DA.obtenerDatos(Id_Tasa_Cambio, Id_Moneda, Fecha);
        }

        public void insertarRegistro(SFRRMADM06 objSFRRMADM06)
        {

            validaRegistroDatos(objSFRRMADM06);

            SFRRMADM06DA objSFRRMADM06DA = new SFRRMADM06DA();
            objSFRRMADM06DA.insertarRegistro(objSFRRMADM06);
        }

        public void actualizarRegistro(SFRRMADM06 objSFRRMADM06)
        {

            validaRegistroDatos(objSFRRMADM06);

            SFRRMADM06DA objPersonaDA = new SFRRMADM06DA();
            objPersonaDA.actualizarRegistro(objSFRRMADM06);
        }

        public void eliminarRegistro(int idSFRRMADM06)
        {
            SFRRMADM06DA objSFRRMADM06DA = new SFRRMADM06DA();
            objSFRRMADM06DA.eliminarRegistro(idSFRRMADM06);
        }

        private void validaRegistroDatos(SFRRMADM06 objSFRRMADM06)
        {

            //Descripción


        }
    }
}
