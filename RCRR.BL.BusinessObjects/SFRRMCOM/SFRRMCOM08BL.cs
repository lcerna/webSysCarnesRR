using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;





namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
    public class SFRRMCOM08BL
    {
        public List<SFRRMCOM08> obtenerRegistros(string descripcion)
        {
            SFRRMCOM08DA objSFRRMBEN19DA = new SFRRMCOM08DA();
            return objSFRRMBEN19DA.obtenerDatosAlmacenId(descripcion);
        }

        public String insertarRegistro(SFRRMCOM08 objSFRRMBEN19)
        {

            validaRegistroDatos(objSFRRMBEN19);

            SFRRMCOM08DA objSFRRMBEN19DA = new SFRRMCOM08DA();
            String sCodigo = objSFRRMBEN19DA.insertarRegistroAlmacen(objSFRRMBEN19);

            return sCodigo;
        }

        public void actualizarRegistro(SFRRMCOM08 objSFRRMBEN19)
        {

            validaRegistroDatos(objSFRRMBEN19);

            SFRRMCOM08DA objPersonaDA = new SFRRMCOM08DA();
            objPersonaDA.actualizarRegistroAlmacen(objSFRRMBEN19);
        }

        public int ValidaEliminar(String sCodigo)
        {
            SFRRMCOM08DA objeto = new SFRRMCOM08DA();
            return objeto.ValidaEliminar(sCodigo);
        }

        public void eliminarRegistro(string idSFRRMBEN19)
        {
            SFRRMCOM08DA objSFRRMBEN19DA = new SFRRMCOM08DA();
            objSFRRMBEN19DA.eliminarRegistroAlmance(idSFRRMBEN19);
        }

        private void validaRegistroDatos(SFRRMCOM08 objSFRRMBEN19)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN19.TipCor_Descrip))
                throw new ArgumentException("Dato Requerido: Descripción");
        }
    }
}
