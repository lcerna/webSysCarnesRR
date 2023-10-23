using System;
using System.Collections.Generic;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMVEN;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMVEN06DA
    {
        public List<SFRRMVEN06> obtenerDatosId(string codigo)
        {
            List<SFRRMVEN06> objSFRRMBEN11 = new List<SFRRMVEN06>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Fac_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN06SelProc", sqlParam);

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

        public String insertarRegistro(SFRRMVEN06 eSFRRMVEN06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[12];

                    sqlParams[0] = new SqlParameter("@Fac_Codigo", eSFRRMVEN06.Fac_Codigo);
                    sqlParams[1] = new SqlParameter("@DetF_ISCodi", eSFRRMVEN06.DetF_ISCodi);
                    sqlParams[2] = new SqlParameter("@DetF_Orden", eSFRRMVEN06.DetF_Orden);
                    sqlParams[3] = new SqlParameter("@DetF_Cantida", eSFRRMVEN06.DetF_Cantida);
                    sqlParams[4] = new SqlParameter("@DetF_Precio", eSFRRMVEN06.DetF_Precio);
                    sqlParams[5] = new SqlParameter("@DetF_ValorVenta", eSFRRMVEN06.DetF_ValorVenta);
                    sqlParams[6] = new SqlParameter("@DetF_ValorCosto", eSFRRMVEN06.DetF_ValorCosto);
                    sqlParams[7] = new SqlParameter("@Usu_Crea", eSFRRMVEN06.Usu_Crea);
                    sqlParams[8] = new SqlParameter("@Fec_Crea", eSFRRMVEN06.Fec_Crea);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", eSFRRMVEN06.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", eSFRRMVEN06.Fec_Upd);
                    sqlParams[11] = new SqlParameter("@CodAlmacen", eSFRRMVEN06.CodAlmacen);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN06InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMVEN06 eSFRRMVEN06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[12];

                    sqlParams[0] = new SqlParameter("@Fac_Codigo", eSFRRMVEN06.Fac_Codigo);
                    sqlParams[1] = new SqlParameter("@DetF_ISCodi", eSFRRMVEN06.DetF_ISCodi);
                    sqlParams[2] = new SqlParameter("@DetF_Orden", eSFRRMVEN06.DetF_Orden);
                    sqlParams[3] = new SqlParameter("@DetF_Cantida", eSFRRMVEN06.DetF_Cantida);
                    sqlParams[4] = new SqlParameter("@DetF_Precio", eSFRRMVEN06.DetF_Precio);
                    sqlParams[5] = new SqlParameter("@DetF_ValorVenta", eSFRRMVEN06.DetF_ValorVenta);
                    sqlParams[6] = new SqlParameter("@DetF_ValorCosto", eSFRRMVEN06.DetF_ValorCosto);
                    sqlParams[7] = new SqlParameter("@Usu_Crea", eSFRRMVEN06.Usu_Crea);
                    sqlParams[8] = new SqlParameter("@Fec_Crea", eSFRRMVEN06.Fec_Crea);
                    sqlParams[9] = new SqlParameter("@Usu_Upd", eSFRRMVEN06.Usu_Upd);
                    sqlParams[10] = new SqlParameter("@Fec_Upd", eSFRRMVEN06.Fec_Upd);
                    sqlParams[11] = new SqlParameter("@CodAlmacen", eSFRRMVEN06.CodAlmacen);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN06UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string sCodigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@Fac_Codigo", sCodigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN06DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMVEN06 llenarObjeto(SqlDataReader dr)
        {
            SFRRMVEN06 eSFRRMVEN06 = new SFRRMVEN06();

            eSFRRMVEN06.Fac_Codigo = dr["Fac_Codigo"].ToString().Trim();
            eSFRRMVEN06.DetF_ISCodi = dr["DetF_ISCodi"].ToString().Trim();
            eSFRRMVEN06.DetF_Orden = dr["DetF_Orden"].ToString().Trim();
            eSFRRMVEN06.DetF_Cantida = Convert.ToDecimal(dr["DetF_Cantida"].ToString().Trim());
            eSFRRMVEN06.DetF_Precio = Convert.ToDecimal(dr["DetF_Precio"].ToString().Trim());
            eSFRRMVEN06.DetF_ValorVenta = Convert.ToDecimal(dr["DetF_ValorVenta"].ToString().Trim());
            eSFRRMVEN06.DetF_ValorCosto = Convert.ToDecimal(dr["DetF_ValorCosto"].ToString().Trim());
            eSFRRMVEN06.Usu_Crea = dr["Usu_Crea"].ToString().Trim();
            eSFRRMVEN06.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"].ToString().Trim());
            eSFRRMVEN06.Usu_Upd = dr["Usu_Upd"].ToString().Trim();
            eSFRRMVEN06.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"].ToString().Trim());
            eSFRRMVEN06.CodAlmacen = dr["CodAlmacen"].ToString().Trim();

            return eSFRRMVEN06;
        }
    }
}
