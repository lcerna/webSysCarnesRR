using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.DA.DataAccessObjects.SFRRMBEN;

namespace RCRR.BL.BusinessObjects.SFRRMBEN
{
    public class SFRRMBEN06BL
    {
        public  List<SFRRMBEN06> obtenerRegistros(int Nro,string descripcion)
        {
            SFRRMBEN06DA objSFRRMBEN06DA = new SFRRMBEN06DA();
            return objSFRRMBEN06DA.obtenerDatosMovimientoBienId(Nro,descripcion);
        }

        public String insertarRegistro(SFRRMBEN06 objSFRRMBEN06)
        {

            validaRegistroDatos(objSFRRMBEN06);

            SFRRMBEN06DA objSFRRMBEN06DA = new SFRRMBEN06DA();
            String Codigo =objSFRRMBEN06DA.insertarRegistroMovimiento_Bien(objSFRRMBEN06);
            return Codigo;
        }

        public void actualizarRegistro(SFRRMBEN06 objSFRRMBEN06)
        {

            validaRegistroDatos(objSFRRMBEN06);

            SFRRMBEN06DA objPersonaDA = new SFRRMBEN06DA();
            objPersonaDA.actualizarRegistroMovimiento_Bien(objSFRRMBEN06);
        }

        public static void eliminarRegistro(int Nro,string idSFRRMBEN06)
        {
            SFRRMBEN06DA objSFRRMBEN06DA = new SFRRMBEN06DA();
            objSFRRMBEN06DA.eliminarRegistroMovimiento_Bien(Nro, idSFRRMBEN06);
        }

        private void validaRegistroDatos(SFRRMBEN06 objSFRRMBEN06)
        {

            //Descripción
            if (String.IsNullOrEmpty(objSFRRMBEN06.NumeroOC))
                throw new ArgumentException("Dato Requerido: Descripción");

            if (objSFRRMBEN06.NumeroOC.Length == 1)
                throw new ArgumentException("Dato Inválido: Descripción");


        }
    }
}
