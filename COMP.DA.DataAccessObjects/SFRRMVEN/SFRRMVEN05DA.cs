using System;
using System.Collections.Generic;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMVEN;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMVEN05DA
    {
        public List<SFRRMVEN05> obtenerDatosId(string codigo)
        {
            List<SFRRMVEN05> objSFRRMBEN11 = new List<SFRRMVEN05>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Fac_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN05SelProc", sqlParam);

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

        public String insertarRegistro(SFRRMVEN05 eSFRRMVEN05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    
                    SqlParameter[] sqlParams = new SqlParameter[23];

                    sqlParams[0] = new SqlParameter("@Fac_Codigo", eSFRRMVEN05.Fac_Codigo);
                    sqlParams[1] = new SqlParameter("@Cli_Codigo", eSFRRMVEN05.Cli_Codigo);
                    sqlParams[2] = new SqlParameter("@Fac_Fecha", eSFRRMVEN05.Fac_Fecha);
                    sqlParams[3] = new SqlParameter("@Fac_Semana", eSFRRMVEN05.Fac_Semana);
                    sqlParams[4] = new SqlParameter("@Fac_Tdocu", eSFRRMVEN05.Fac_Tdocu);
                    sqlParams[5] = new SqlParameter("@Fac_Ndocu", eSFRRMVEN05.Fac_Ndocu);
                    sqlParams[6] = new SqlParameter("@Fac_Subtotal", eSFRRMVEN05.Fac_Subtotal);
                    sqlParams[7] = new SqlParameter("@Fac_Igv", eSFRRMVEN05.Fac_Igv);
                    sqlParams[8] = new SqlParameter("@Fac_Total", eSFRRMVEN05.Fac_Total);
                    sqlParams[9] = new SqlParameter("@Fac_Saldo", eSFRRMVEN05.Fac_Saldo);
                    sqlParams[10] = new SqlParameter("@Fac_Descuento", eSFRRMVEN05.Fac_Descuento);
                    sqlParams[11] = new SqlParameter("@Fac_Estado", eSFRRMVEN05.Fac_Estado);
                    sqlParams[12] = new SqlParameter("@Fac_Glosa", eSFRRMVEN05.Fac_Glosa);
                    sqlParams[13] = new SqlParameter("@IncluyeIGV", eSFRRMVEN05.IncluyeIGV);
                    sqlParams[14] = new SqlParameter("@Fac_Moneda", eSFRRMVEN05.Fac_Moneda);
                    sqlParams[15] = new SqlParameter("@Fac_TCambio", eSFRRMVEN05.Fac_TCambio);
                    sqlParams[16] = new SqlParameter("@Fac_MotAnulacion", eSFRRMVEN05.Fac_MotAnulacion);
                    sqlParams[17] = new SqlParameter("@Usu_Crea", eSFRRMVEN05.Usu_Crea);
                    sqlParams[18] = new SqlParameter("@Fec_Crea", eSFRRMVEN05.Fec_Crea);
                    sqlParams[19] = new SqlParameter("@Usu_Upd", eSFRRMVEN05.Usu_Upd);
                    sqlParams[20] = new SqlParameter("@Fec_Upd", eSFRRMVEN05.Fec_Upd);
                    sqlParams[21] = new SqlParameter("@FAnulada", eSFRRMVEN05.FAnulada);
                    sqlParams[22] = new SqlParameter("@UsuAnulo", eSFRRMVEN05.UsuAnulo);

                    string codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                         "SFRRMVEN05InsProc", sqlParams).ToString();
                    return codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void actualizarRegistro(SFRRMVEN05 eSFRRMVEN05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[23];

                    sqlParams[0] = new SqlParameter("@Fac_Codigo", eSFRRMVEN05.Fac_Codigo);
                    sqlParams[1] = new SqlParameter("@Cli_Codigo", eSFRRMVEN05.Cli_Codigo);
                    sqlParams[2] = new SqlParameter("@Fac_Fecha", eSFRRMVEN05.Fac_Fecha);
                    sqlParams[3] = new SqlParameter("@Fac_Semana", eSFRRMVEN05.Fac_Semana);
                    sqlParams[4] = new SqlParameter("@Fac_Tdocu", eSFRRMVEN05.Fac_Tdocu);
                    sqlParams[5] = new SqlParameter("@Fac_Ndocu", eSFRRMVEN05.Fac_Ndocu);
                    sqlParams[6] = new SqlParameter("@Fac_Subtotal", eSFRRMVEN05.Fac_Subtotal);
                    sqlParams[7] = new SqlParameter("@Fac_Igv", eSFRRMVEN05.Fac_Igv);
                    sqlParams[8] = new SqlParameter("@Fac_Total", eSFRRMVEN05.Fac_Total);
                    sqlParams[9] = new SqlParameter("@Fac_Saldo", eSFRRMVEN05.Fac_Saldo);
                    sqlParams[10] = new SqlParameter("@Fac_Descuento", eSFRRMVEN05.Fac_Descuento);
                    sqlParams[11] = new SqlParameter("@Fac_Estado", eSFRRMVEN05.Fac_Estado);
                    sqlParams[12] = new SqlParameter("@Fac_Glosa", eSFRRMVEN05.Fac_Glosa);
                    sqlParams[13] = new SqlParameter("@IncluyeIGV", eSFRRMVEN05.IncluyeIGV);
                    sqlParams[14] = new SqlParameter("@Fac_Moneda", eSFRRMVEN05.Fac_Moneda);
                    sqlParams[15] = new SqlParameter("@Fac_TCambio", eSFRRMVEN05.Fac_TCambio);
                    sqlParams[16] = new SqlParameter("@Fac_MotAnulacion", eSFRRMVEN05.Fac_MotAnulacion);
                    sqlParams[17] = new SqlParameter("@Usu_Crea", eSFRRMVEN05.Usu_Crea);
                    sqlParams[18] = new SqlParameter("@Fec_Crea", eSFRRMVEN05.Fec_Crea);
                    sqlParams[19] = new SqlParameter("@Usu_Upd", eSFRRMVEN05.Usu_Upd);
                    sqlParams[20] = new SqlParameter("@Fec_Upd", eSFRRMVEN05.Fec_Upd);
                    sqlParams[21] = new SqlParameter("@FAnulada", eSFRRMVEN05.FAnulada);
                    sqlParams[22] = new SqlParameter("@UsuAnulo", eSFRRMVEN05.UsuAnulo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN05UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            
     public  void eliminarRegistro(string sCodigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@Fac_Codigo", sCodigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN05DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMVEN05 llenarObjeto(SqlDataReader dr)
        {
            SFRRMVEN05 eSFRRMVEN05 = new SFRRMVEN05();


            eSFRRMVEN05.Fac_Codigo= dr["Cli_Codigo"].ToString().Trim();
            eSFRRMVEN05.Cli_Codigo = dr["Cli_Codigo"].ToString().Trim();
            eSFRRMVEN05.Fac_Fecha = Convert.ToDateTime(dr["Fac_Fecha"].ToString().Trim());
            eSFRRMVEN05.Fac_Semana = Convert.ToDecimal(dr["Fac_Semana"].ToString().Trim());
            eSFRRMVEN05.Fac_Tdocu = dr["Fac_Tdocu"].ToString().Trim();
            eSFRRMVEN05.Fac_Ndocu = dr["Fac_Ndocu"].ToString().Trim();
            eSFRRMVEN05.Fac_Subtotal = Convert.ToDecimal(dr["Fac_Subtotal"].ToString().Trim());
            eSFRRMVEN05.Fac_Igv = Convert.ToDecimal(dr["Fac_Igv"].ToString().Trim());
            eSFRRMVEN05.Fac_Total = Convert.ToDecimal(dr["Fac_Total"].ToString().Trim());
            eSFRRMVEN05.Fac_Saldo = Convert.ToDecimal(dr["Fac_Saldo"].ToString().Trim());
            eSFRRMVEN05.Fac_Descuento = Convert.ToDecimal(dr["Fac_Descuento"].ToString().Trim());
            eSFRRMVEN05.Fac_Estado = dr["Fac_Estado"].ToString().Trim();
            eSFRRMVEN05.Fac_Glosa = dr["Fac_Glosa"].ToString().Trim();
            eSFRRMVEN05.IncluyeIGV = dr["IncluyeIGV"].ToString().Trim();
            eSFRRMVEN05.Fac_Moneda = dr["Fac_Moneda"].ToString().Trim();
            eSFRRMVEN05.Fac_TCambio = Convert.ToDecimal(dr["Fac_TCambio"].ToString().Trim());
            eSFRRMVEN05.Fac_MotAnulacion = dr["Fac_MotAnulacion"].ToString().Trim();
            eSFRRMVEN05.Usu_Crea = dr["Usu_Crea"].ToString().Trim();
            eSFRRMVEN05.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"].ToString().Trim());
            eSFRRMVEN05.Usu_Upd = dr["Usu_Upd"].ToString().Trim();
            eSFRRMVEN05.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"].ToString().Trim());
            eSFRRMVEN05.FAnulada = Convert.ToDateTime(dr["FAnulada"].ToString().Trim());
            eSFRRMVEN05.UsuAnulo = dr["UsuAnulo"].ToString().Trim();

            return eSFRRMVEN05;
        }
    }
}
