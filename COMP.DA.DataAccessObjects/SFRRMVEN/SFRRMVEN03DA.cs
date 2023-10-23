using System;
using System.Collections.Generic;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMVEN;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMVEN03DA
    {
        public List<SFRRMVEN03_List> listarRegistros(string codigo)
        {
            List<SFRRMVEN03_List> objSFRRMBEN11 = new List<SFRRMVEN03_List>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Cli_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN03SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN11.Add(llenarObjeto2(dr));
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
        public SFRRMVEN03 obtenerDatosId(string codigo)
        {
            SFRRMVEN03 objSFRRMBEN11 = new SFRRMVEN03();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Cli_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN03SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN11 = llenarObjeto(dr);
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

        public String insertarRegistro(SFRRMVEN03 eSFRRMVEN03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[21];

                    sqlParams[0] = new SqlParameter("@Cli_Codigo", eSFRRMVEN03.Cli_Codigo);
                    sqlParams[1] = new SqlParameter("@CDocumento", eSFRRMVEN03.CDocumento);
                    sqlParams[2] = new SqlParameter("@Cli_NumDocu", eSFRRMVEN03.Cli_NumDocu);
                    sqlParams[3] = new SqlParameter("@Cli_RazonSocial", eSFRRMVEN03.Cli_RazonSocial);
                    sqlParams[4] = new SqlParameter("@Cli_ApePat", String.Empty);
                    sqlParams[5] = new SqlParameter("@Cli_ApeMat", String.Empty);
                    sqlParams[6] = new SqlParameter("@Cli_Nombre", eSFRRMVEN03.Cli_Nombre);
                    sqlParams[7] = new SqlParameter("@Cli_Direccion", eSFRRMVEN03.Cli_Direccion);
                    sqlParams[8] = new SqlParameter("@Cli_Referencia", eSFRRMVEN03.Cli_Referencia);
                    sqlParams[9] = new SqlParameter("@Cli_Contacto", eSFRRMVEN03.Cli_Contacto);
                    sqlParams[10] = new SqlParameter("@Cli_email", eSFRRMVEN03.Cli_email);
                    sqlParams[11] = new SqlParameter("@Cli_TipTef", eSFRRMVEN03.Cli_TipTef);
                    sqlParams[12] = new SqlParameter("@Cli_NumTelf", eSFRRMVEN03.Cli_NumTelf);
                    sqlParams[13] = new SqlParameter("@Depa", eSFRRMVEN03.Depa);
                    sqlParams[14] = new SqlParameter("@Prov", eSFRRMVEN03.Prov);
                    sqlParams[15] = new SqlParameter("@Dist", eSFRRMVEN03.Dist);
                    sqlParams[16] = new SqlParameter("@Cli_Estado", eSFRRMVEN03.Cli_Estado);
                    sqlParams[17] = new SqlParameter("@Usu_Crea", eSFRRMVEN03.Usu_Crea);
                    sqlParams[18] = new SqlParameter("@Fec_Crea", eSFRRMVEN03.Fec_Crea);
                    sqlParams[19] = new SqlParameter("@Usu_Upd", eSFRRMVEN03.Usu_Upd);
                    sqlParams[20] = new SqlParameter("@Fec_Upd", eSFRRMVEN03.Fec_Upd);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN03InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMVEN03 eSFRRMVEN03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[21];

                    sqlParams[0] = new SqlParameter("@Cli_Codigo", eSFRRMVEN03.Cli_Codigo);
                    sqlParams[1] = new SqlParameter("@CDocumento", eSFRRMVEN03.CDocumento);
                    sqlParams[2] = new SqlParameter("@Cli_NumDocu", eSFRRMVEN03.Cli_NumDocu);
                    sqlParams[3] = new SqlParameter("@Cli_RazonSocial", eSFRRMVEN03.Cli_RazonSocial);
                    sqlParams[4] = new SqlParameter("@Cli_ApePat", String.Empty);
                    sqlParams[5] = new SqlParameter("@Cli_ApeMat", String.Empty);
                    sqlParams[6] = new SqlParameter("@Cli_Nombre", eSFRRMVEN03.Cli_Nombre);
                    sqlParams[7] = new SqlParameter("@Cli_Direccion", eSFRRMVEN03.Cli_Direccion);
                    sqlParams[8] = new SqlParameter("@Cli_Referencia", eSFRRMVEN03.Cli_Referencia);
                    sqlParams[9] = new SqlParameter("@Cli_Contacto", eSFRRMVEN03.Cli_Contacto);
                    sqlParams[10] = new SqlParameter("@Cli_email", eSFRRMVEN03.Cli_email);
                    sqlParams[11] = new SqlParameter("@Cli_TipTef", eSFRRMVEN03.Cli_TipTef);
                    sqlParams[12] = new SqlParameter("@Cli_NumTelf", eSFRRMVEN03.Cli_NumTelf);
                    sqlParams[13] = new SqlParameter("@Depa", eSFRRMVEN03.Depa);
                    sqlParams[14] = new SqlParameter("@Prov", eSFRRMVEN03.Prov);
                    sqlParams[15] = new SqlParameter("@Dist", eSFRRMVEN03.Dist);
                    sqlParams[16] = new SqlParameter("@Cli_Estado", eSFRRMVEN03.Cli_Estado);
                    sqlParams[17] = new SqlParameter("@Usu_Crea", eSFRRMVEN03.Usu_Crea);
                    sqlParams[18] = new SqlParameter("@Fec_Crea", eSFRRMVEN03.Fec_Crea);
                    sqlParams[19] = new SqlParameter("@Usu_Upd", eSFRRMVEN03.Usu_Upd);
                    sqlParams[20] = new SqlParameter("@Fec_Upd", eSFRRMVEN03.Fec_Upd);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN03UpdProc", sqlParams);
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

                    SqlParameter sqlParam = new SqlParameter("@Cli_Codigo", sCodigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMVEN03DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMVEN03 llenarObjeto(SqlDataReader dr)
        {
            SFRRMVEN03 eSFRRMVEN03 = new SFRRMVEN03();

            eSFRRMVEN03.Cli_Codigo = dr["Cli_Codigo"].ToString().Trim();
            eSFRRMVEN03.CDocumento = dr["CDocumento"].ToString().Trim();
            eSFRRMVEN03.Cli_NumDocu = dr["Cli_NumDocu"].ToString().Trim();
            eSFRRMVEN03.Cli_RazonSocial = dr["Cli_RazonSocial"].ToString().Trim();
            eSFRRMVEN03.Cli_ApePat = dr["Cli_ApePat"].ToString().Trim();
            eSFRRMVEN03.Cli_ApeMat = dr["Cli_ApeMat"].ToString().Trim();
            eSFRRMVEN03.Cli_Nombre = dr["Cli_Nombre"].ToString().Trim();
            eSFRRMVEN03.Cli_Direccion = dr["Cli_Direccion"].ToString().Trim();
            eSFRRMVEN03.Cli_Referencia = dr["Cli_Referencia"].ToString().Trim();
            eSFRRMVEN03.Cli_Contacto = dr["Cli_Contacto"].ToString().Trim();
            eSFRRMVEN03.Depa = dr["Depa"].ToString().Trim();
            eSFRRMVEN03.Prov = dr["Prov"].ToString().Trim();
            eSFRRMVEN03.Dist = dr["Dist"].ToString().Trim();
            eSFRRMVEN03.Cli_email = dr["Cli_email"].ToString().Trim();
            eSFRRMVEN03.Cli_TipTef = dr["Cli_TipTef"].ToString().Trim();
            eSFRRMVEN03.Cli_NumTelf = dr["Cli_NumTelf"].ToString().Trim();
            eSFRRMVEN03.Cli_Estado = dr["Cli_Estado"].ToString().Trim();
            eSFRRMVEN03.Usu_Crea = dr["Usu_Crea"].ToString().Trim();
            eSFRRMVEN03.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"].ToString().Trim());
            eSFRRMVEN03.Usu_Upd = dr["Usu_Upd"].ToString().Trim();
            eSFRRMVEN03.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"].ToString().Trim());

            return eSFRRMVEN03;
        }


        private SFRRMVEN03_List llenarObjeto2(SqlDataReader dr)
        {
            SFRRMVEN03_List eSFRRMVEN03 = new SFRRMVEN03_List();

            eSFRRMVEN03.Cli_Codigo = dr["Cli_Codigo"].ToString().Trim();
            eSFRRMVEN03.Cli_NumDocu = dr["Cli_NumDocu"].ToString().Trim();
            eSFRRMVEN03.Cli_RazonSocial = dr["Cli_RazonSocial"].ToString().Trim();

            return eSFRRMVEN03;
        }
    }
}
