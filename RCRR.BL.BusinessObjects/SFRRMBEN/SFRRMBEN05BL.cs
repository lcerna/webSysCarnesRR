using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN05BL
    {
        public  List<SFRRMBEN05> obtenerRegistros(string descripcion)
        {
            SFRRMBEN05DA objSFRRMBEN05DA = new SFRRMBEN05DA();
            return objSFRRMBEN05DA.obtenerDatosMovimientoId(descripcion);
        }

        public  String insertarRegistro(SFRRMBEN05 objSFRRMBEN05)
        {

            validaRegistroDatos(objSFRRMBEN05);

            SFRRMBEN05DA objSFRRMBEN05DA = new SFRRMBEN05DA();
            String Codigo = objSFRRMBEN05DA.insertarRegistroMovimiento(objSFRRMBEN05);
            return Codigo;
        }

        public  void actualizarRegistro(SFRRMBEN05 objSFRRMBEN05)
        {

            validaRegistroDatos(objSFRRMBEN05);

            SFRRMBEN05DA objPersonaDA = new SFRRMBEN05DA();
            objPersonaDA.actualizarRegistroMovimiento(objSFRRMBEN05);
        }

        public  void eliminarRegistro(string idSFRRMBEN05)
        {
            SFRRMBEN05DA objSFRRMBEN05DA = new SFRRMBEN05DA();
            objSFRRMBEN05DA.eliminarRegistroMovimiento(idSFRRMBEN05);
        }

        private  void validaRegistroDatos(SFRRMBEN05 objSFRRMBEN05)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN05.CDocumento))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN05.CDocumento.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
