using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;


namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
   public class SFRRMCOM10BL
    {
        public List<SFRRMCOM10_List> ListarRegistros(string descripcion)
        {
            SFRRMCOM10DA objSFRRMBEN11DA = new SFRRMCOM10DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public SFRRMCOM10 obtenerRegistros(string descripcion)
        {
            SFRRMCOM10DA objSFRRMBEN11DA = new SFRRMCOM10DA();
            return objSFRRMBEN11DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMCOM10 objSFRRMBEN11)
        {
            SFRRMCOM10DA objSFRRMBEN11DA = new SFRRMCOM10DA();
            return objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
        }

        public void actualizarRegistro(SFRRMCOM10 objSFRRMBEN11)
        {
            SFRRMCOM10DA objPersonaDA = new SFRRMCOM10DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string sCodigo)
        {
            SFRRMCOM10DA objSFRRMBEN11DA = new SFRRMCOM10DA();
            objSFRRMBEN11DA.eliminarRegistro(sCodigo);
        }

    }
}
