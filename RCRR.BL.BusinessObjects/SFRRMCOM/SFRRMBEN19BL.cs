using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;


namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN19BL
    {
        public List<SFRRMBEN19> obtenerRegistros(string descripcion)
        {
            SFRRMBEN19DA objSFRRMBEN19DA = new SFRRMBEN19DA();
            return objSFRRMBEN19DA.obtenerDatosAlmacenId(descripcion);
        }

        public String insertarRegistro(SFRRMBEN19 objSFRRMBEN19)
        {

            validaRegistroDatos(objSFRRMBEN19);

            SFRRMBEN19DA objSFRRMBEN19DA = new SFRRMBEN19DA();
            String sCodigo = objSFRRMBEN19DA.insertarRegistroAlmacen(objSFRRMBEN19);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMBEN19 objSFRRMBEN19)
        {

            validaRegistroDatos(objSFRRMBEN19);

            SFRRMBEN19DA objPersonaDA = new SFRRMBEN19DA();
            objPersonaDA.actualizarRegistroAlmacen(objSFRRMBEN19);
        }

        public int ValidaEliminar(String sCodigo)
        {
            SFRRMBEN19DA objeto = new SFRRMBEN19DA();
            return objeto.ValidaEliminar(sCodigo);
        }

        public void eliminarRegistro(string idSFRRMBEN19)
        {
            SFRRMBEN19DA objSFRRMBEN19DA = new SFRRMBEN19DA();
            objSFRRMBEN19DA.eliminarRegistroAlmance(idSFRRMBEN19);
        }

        private void validaRegistroDatos(SFRRMBEN19 objSFRRMBEN19)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN19.TipCor_Descrip))
                throw new ArgumentException("Dato Requerido: Descripción");
        }  
    }
}
