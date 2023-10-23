using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace RCRR.DA.DataAccessObjects.SFRRMCOM
{
    public class SFRRMCOM02DA
    {
        public List<SFRRMCOM02> obtenerDatosId(string codigo)
        {
            List<SFRRMCOM02> objSFRRMBEN11 = new List<SFRRMCOM02>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@GuiaRD_Codi", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN11SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN11.Add(llenarObjeto(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (!dr.IsClosed)
                    dr.Close();
            }

            return objSFRRMBEN11;
        }

        public void insertarRegistro(SFRRMCOM02 objSFRRMBEN11)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[11];

                    sqlParams[0] = new SqlParameter("@GuiaRD_Codi", objSFRRMBEN11.GuiaRD_Codi);
                    sqlParams[1] = new SqlParameter("@GuiaR_Numero", objSFRRMBEN11.GuiaR_Numero);
                    sqlParams[2] = new SqlParameter("@NroMovimiento", objSFRRMBEN11.NroMovimiento);
                    sqlParams[3] = new SqlParameter("@Ped_Codigo", objSFRRMBEN11.Ped_Codigo);
                    sqlParams[4] = new SqlParameter("@Bie_Codigo", objSFRRMBEN11.Bie_Codigo);
                    sqlParams[5] = new SqlParameter("@GuiaRD_Cantidad", objSFRRMBEN11.GuiaRD_Cantidad);
                    sqlParams[6] = new SqlParameter("@GuiaRD_Adicional", objSFRRMBEN11.GuiaRD_Adicional);
                    sqlParams[7] = new SqlParameter("@GuiaR_Nuevo_Usuario", objSFRRMBEN11.GuiaR_Nuevo_Usuario);
                    sqlParams[8] = new SqlParameter("@GuiaR_Nuevo_Fecha", objSFRRMBEN11.GuiaR_Nuevo_Fecha);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", objSFRRMBEN11.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", objSFRRMBEN11.Fec_Upd);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN11InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMCOM02 objSFRRMBEN11)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[11];

                    sqlParams[0] = new SqlParameter("@GuiaRD_Codi", objSFRRMBEN11.GuiaRD_Codi);
                    sqlParams[1] = new SqlParameter("@GuiaR_Numero", objSFRRMBEN11.GuiaR_Numero);
                    sqlParams[2] = new SqlParameter("@NroMovimiento", objSFRRMBEN11.NroMovimiento);
                    sqlParams[3] = new SqlParameter("@Ped_Codigo", objSFRRMBEN11.Ped_Codigo);
                    sqlParams[4] = new SqlParameter("@Bie_Codigo", objSFRRMBEN11.Bie_Codigo);
                    sqlParams[5] = new SqlParameter("@GuiaRD_Cantidad", objSFRRMBEN11.GuiaRD_Cantidad);
                    sqlParams[6] = new SqlParameter("@GuiaRD_Adicional", objSFRRMBEN11.GuiaRD_Adicional);
                    sqlParams[7] = new SqlParameter("@GuiaR_Nuevo_Usuario", objSFRRMBEN11.GuiaR_Nuevo_Usuario);
                    sqlParams[8] = new SqlParameter("@GuiaR_Nuevo_Fecha", objSFRRMBEN11.GuiaR_Nuevo_Fecha);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", objSFRRMBEN11.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", objSFRRMBEN11.Fec_Upd);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN11UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string GuiaRD_Codi)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@GuiaRD_Codi", GuiaRD_Codi);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN11DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM02 llenarObjeto(SqlDataReader dr)
        {
            SFRRMCOM02 objSFRRMBEN13 = new SFRRMCOM02();
            objSFRRMBEN13.GuiaRD_Codi = Convert.ToInt32(dr["GuiaRD_Codi"]);
            objSFRRMBEN13.GuiaR_Numero = Convert.ToString(dr["GuiaR_Numero"]);
            objSFRRMBEN13.NroMovimiento = Convert.ToString(dr["NroMovimiento"]);
            objSFRRMBEN13.Ped_Codigo = Convert.ToString(dr["Ped_Codigo"]);
            objSFRRMBEN13.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"]);
            objSFRRMBEN13.GuiaRD_Cantidad = Convert.ToInt32(dr["GuiaRD_Cantidad"]);
            objSFRRMBEN13.GuiaRD_Adicional = Convert.ToString(dr["GuiaRD_Adicional"]);
            objSFRRMBEN13.GuiaR_Nuevo_Usuario = Convert.ToString(dr["GuiaR_Nuevo_Usuario"]);
            objSFRRMBEN13.GuiaR_Nuevo_Fecha = Convert.ToDateTime(dr["GuiaR_Nuevo_Fecha"]);
            objSFRRMBEN13.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN13.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);

            return objSFRRMBEN13;
        }
    }
}
