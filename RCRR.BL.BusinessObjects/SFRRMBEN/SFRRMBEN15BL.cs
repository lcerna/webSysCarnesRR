using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN15BL
    {
        public List<SFRRMBEN15> obtenerRegistros(string descripcion)
        {
            SFRRMBEN15DA objSFRRMBEN15DA = new SFRRMBEN15DA();
            return objSFRRMBEN15DA.obtenerDatosId(descripcion);
        }

        public void insertarRegistro(SFRRMBEN15 objSFRRMBEN15)
        {

            validaRegistroDatos(objSFRRMBEN15);

            SFRRMBEN15DA objSFRRMBEN15DA = new SFRRMBEN15DA();
            objSFRRMBEN15DA.insertarRegistro(objSFRRMBEN15);
        }

        public void actualizarRegistro(SFRRMBEN15 objSFRRMBEN15)
        {

            validaRegistroDatos(objSFRRMBEN15);

            SFRRMBEN15DA objPersonaDA = new SFRRMBEN15DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN15);
        }

        public  void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMBEN15DA objSFRRMBEN15DA = new SFRRMBEN15DA();
            objSFRRMBEN15DA.eliminarRegistro(idSFRRMBEN11);
        }

        private void validaRegistroDatos(SFRRMBEN15 objSFRRMBEN15)
        {
/*
            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN15.NroMovimiento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN15.NroMovimiento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");
            */

        }
    }
}
