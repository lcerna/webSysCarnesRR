using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN14BL
    {
        public List<SFRRMBEN14_List> ListarRegistros(string descripcion)
        {
            SFRRMBEN14DA objSFRRMBEN11DA = new SFRRMBEN14DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public  SFRRMBEN14 obtenerRegistros(string descripcion)
        {
            SFRRMBEN14DA objSFRRMBEN11DA = new SFRRMBEN14DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public  String insertarRegistro(SFRRMBEN14 objSFRRMBEN14)
        {

            validaRegistroDatos(objSFRRMBEN14);

            SFRRMBEN14DA objSFRRMBEN11DA = new SFRRMBEN14DA();
            string Codigo = objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN14);

            return Codigo;
        }

        public  void actualizarRegistro(SFRRMBEN14 objSFRRMBEN14)
        {

            validaRegistroDatos(objSFRRMBEN14);

            SFRRMBEN14DA objPersonaDA = new SFRRMBEN14DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN14);
        }

        public  void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMBEN14DA objSFRRMBEN11DA = new SFRRMBEN14DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }

        private  void validaRegistroDatos(SFRRMBEN14 objSFRRMBEN11)
        {

            //Descripción
            //if (String.IsNullOrEmpty(objSFRRMBEN11.Observacion))
            //    throw new ArgumentException("Dato Requerido: Descripción");



        }
    }
}
