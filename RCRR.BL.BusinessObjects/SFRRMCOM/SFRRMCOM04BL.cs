using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;

namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
   public class SFRRMCOM04BL
    {
        public List<SFRRMCOM04> obtenerRegistros(string descripcion)
        {
            SFRRMCOM04DA objSFRRMBEN15DA = new SFRRMCOM04DA();
            return objSFRRMBEN15DA.obtenerDatosId(descripcion);
        }

        public void insertarRegistro(SFRRMCOM04 objSFRRMBEN15)
        {

            validaRegistroDatos(objSFRRMBEN15);

            SFRRMCOM04DA objSFRRMBEN15DA = new SFRRMCOM04DA();
            objSFRRMBEN15DA.insertarRegistro(objSFRRMBEN15);
        }

        public void actualizarRegistro(SFRRMCOM04 objSFRRMBEN15)
        {

            validaRegistroDatos(objSFRRMBEN15);

            SFRRMCOM04DA objPersonaDA = new SFRRMCOM04DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN15);
        }

        public void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMCOM04DA objSFRRMBEN15DA = new SFRRMCOM04DA();
            objSFRRMBEN15DA.eliminarRegistro(idSFRRMBEN11);
        }

        private void validaRegistroDatos(SFRRMCOM04 objSFRRMBEN15)
        {

           
                        if (String.IsNullOrEmpty(objSFRRMBEN15.Bie_Codigo))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN15.Bie_Codigo.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
