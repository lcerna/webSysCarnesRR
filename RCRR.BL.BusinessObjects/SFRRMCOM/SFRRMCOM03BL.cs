using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;

namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
    public class SFRRMCOM03BL
    {
        public List<SFRRMCOM03_List> ListarRegistros(string descripcion)
        {
            SFRRMCOM03DA objSFRRMBEN11DA = new SFRRMCOM03DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public SFRRMCOM03 obtenerRegistros(string descripcion)
        {
            SFRRMCOM03DA objSFRRMBEN11DA = new SFRRMCOM03DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMCOM03 objSFRRMBEN14)
        {

            validaRegistroDatos(objSFRRMBEN14);

            SFRRMCOM03DA objSFRRMBEN11DA = new SFRRMCOM03DA();
            string Codigo = objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN14);

            return Codigo;
        }

        public void actualizarRegistro(SFRRMCOM03 objSFRRMBEN14)
        {

            validaRegistroDatos(objSFRRMBEN14);

            SFRRMCOM03DA objPersonaDA = new SFRRMCOM03DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN14);
        }

        public void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMCOM03DA objSFRRMBEN11DA = new SFRRMCOM03DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }

        private void validaRegistroDatos(SFRRMCOM03 objSFRRMBEN11)
        {
            
            if (String.IsNullOrEmpty(objSFRRMBEN11.Observacion))
                throw new ArgumentException("Dato Requerido: Descripción");



        }
    }
}
