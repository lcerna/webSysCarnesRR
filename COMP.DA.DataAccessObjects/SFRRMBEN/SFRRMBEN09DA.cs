using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMBEN09DA
    {
        public List<SFRRMBEN09> obtenerDatosId(string stk_codIde)
        {
            List<SFRRMBEN09> objSFRRMBEN09 = new List<SFRRMBEN09>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@stk_codIde", stk_codIde);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN09SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN09.Add(llenarObjeto(dr));
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

            return objSFRRMBEN09;
        }

        public void insertarRegistro(SFRRMBEN09 objSFRRMBEN09)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[11];

                    sqlParams[0] = new SqlParameter("@stk_codIde", objSFRRMBEN09.stk_codIde);
                    sqlParams[1] = new SqlParameter("@CodAlmacen", objSFRRMBEN09.CodAlmacen);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN09.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@stk_cantMin", objSFRRMBEN09.stk_cantMin);
                    sqlParams[4] = new SqlParameter("@stk_canMax", objSFRRMBEN09.stk_canMax);
                    sqlParams[5] = new SqlParameter("@stk_stockDocs", objSFRRMBEN09.stk_stockDocs);
                    sqlParams[6] = new SqlParameter("@stk_stockReal", objSFRRMBEN09.stk_stockReal);
                    sqlParams[7] = new SqlParameter("@Usu_Crea", objSFRRMBEN09.Usu_Crea);
                    sqlParams[8] = new SqlParameter("@Fec_Crea", objSFRRMBEN09.Fec_Crea);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", objSFRRMBEN09.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", objSFRRMBEN09.Fec_Upd);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN09InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMBEN09 objSFRRMBEN09)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[11];

                    sqlParams[0] = new SqlParameter("@stk_codIde", objSFRRMBEN09.stk_codIde);
                    sqlParams[1] = new SqlParameter("@CodAlmacen", objSFRRMBEN09.CodAlmacen);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN09.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@stk_cantMin", objSFRRMBEN09.stk_cantMin);
                    sqlParams[4] = new SqlParameter("@stk_canMax", objSFRRMBEN09.stk_canMax);
                    sqlParams[5] = new SqlParameter("@stk_stockDocs", objSFRRMBEN09.stk_stockDocs);
                    sqlParams[6] = new SqlParameter("@stk_stockReal", objSFRRMBEN09.stk_stockReal);
                    sqlParams[7] = new SqlParameter("@Usu_Crea", objSFRRMBEN09.Usu_Crea);
                    sqlParams[8] = new SqlParameter("@Fec_Crea", objSFRRMBEN09.Fec_Crea);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", objSFRRMBEN09.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", objSFRRMBEN09.Fec_Upd);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN09UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string stk_codIde)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@stk_codIde", stk_codIde);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN09DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN09 llenarObjeto(SqlDataReader dr)
        {
            SFRRMBEN09 objSFRRMBEN09 = new SFRRMBEN09();
            objSFRRMBEN09.stk_codIde = Convert.ToInt32(dr["stk_codIde"]);
            objSFRRMBEN09.CodAlmacen = Convert.ToString(dr["CodAlmacen"]);
            objSFRRMBEN09.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"]);
            objSFRRMBEN09.stk_cantMin = Convert.ToInt32(dr["stk_cantMin"]);
            objSFRRMBEN09.stk_canMax = Convert.ToInt32(dr["stk_canMax"]);
            objSFRRMBEN09.stk_stockDocs = Convert.ToInt32(dr["stk_stockDocs"]);
            objSFRRMBEN09.stk_stockReal = Convert.ToInt32(dr["stk_stockReal"]);
            objSFRRMBEN09.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN09.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN09.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN09.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);

            return objSFRRMBEN09;
        }
    }
}
