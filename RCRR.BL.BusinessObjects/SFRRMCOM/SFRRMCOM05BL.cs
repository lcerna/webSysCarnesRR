using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.DA.DataAccessObjects.SFRRMCOM;

namespace RCRR.BL.BusinessObjects.SFRRMCOM
{
    public class SFRRMCOM05BL
    {
        public List<SFRRMCOM05_List> ListarRegistros(string descripcion)
        {
            SFRRMCOM05DA objSFRRMBEN11DA = new SFRRMCOM05DA();
            return objSFRRMBEN11DA.ListarRegistros(descripcion);
        }

        public SFRRMCOM05 obtenerRegistro(string descripcion)
        {
            SFRRMCOM05DA objSFRRMBEN16DA = new SFRRMCOM05DA();
            return objSFRRMBEN16DA.obtenerDatosId(descripcion);
        }

        public String insertarRegistro(SFRRMCOM05 objSFRRMBEN11)
        {
            SFRRMCOM05DA objSFRRMBEN11DA = new SFRRMCOM05DA();

            String Codigo = objSFRRMBEN11DA.insertarRegistro(objSFRRMBEN11);
            return Codigo;
        }

        public void actualizarRegistro(SFRRMCOM05 objSFRRMBEN11)
        {
            SFRRMCOM05DA objPersonaDA = new SFRRMCOM05DA();
            objPersonaDA.actualizarRegistro(objSFRRMBEN11);
        }

        public void eliminarRegistro(string idSFRRMBEN11)
        {
            SFRRMCOM05DA objSFRRMBEN11DA = new SFRRMCOM05DA();
            objSFRRMBEN11DA.eliminarRegistro(idSFRRMBEN11);
        }
    }
}
