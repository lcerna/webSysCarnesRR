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
    public class SFRRMBEN08DA
    {
        public List<SFRRMBEN08> obtenerDatosId(string invd_codIde)
        {
            List<SFRRMBEN08> objSFRRMBEN08 = new List<SFRRMBEN08>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@invd_codIde", invd_codIde);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN08SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN08.Add(llenarObjeto(dr));
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

            return objSFRRMBEN08;
        }

        public void insertarRegistro(SFRRMBEN08 objSFRRMBEN08)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[13];

                    sqlParams[0] = new SqlParameter("@inv_codIde", objSFRRMBEN08.inv_codIde);
                    sqlParams[1] = new SqlParameter("@CodAlmacen", objSFRRMBEN08.CodAlmacen);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN08.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@invd_estado", objSFRRMBEN08.invd_estado);
                    sqlParams[4] = new SqlParameter("@invd_stockDoc", objSFRRMBEN08.invd_stockDoc);
                    sqlParams[5] = new SqlParameter("@invd_stockDocAnterior", objSFRRMBEN08.invd_stockDocAnterior);
                    sqlParams[6] = new SqlParameter("@invd_stockReal", objSFRRMBEN08.invd_stockReal);
                    sqlParams[7] = new SqlParameter("@invd_stockRealAnterior", objSFRRMBEN08.invd_stockRealAnterior);
                    sqlParams[8] = new SqlParameter("@invd_valor", objSFRRMBEN08.invd_valor);
                    sqlParams[9] = new SqlParameter("@Usu_Crea", objSFRRMBEN08.Usu_Crea);
                    sqlParams[10] = new SqlParameter("@Fec_Crea", objSFRRMBEN08.Fec_Crea);
                    sqlParams[11] = new SqlParameter("@Usu_Upd", objSFRRMBEN08.Usu_Upd);
                    sqlParams[12] = new SqlParameter("@Fec_Upd", objSFRRMBEN08.Fec_Upd);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN08InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMBEN08 objSFRRMBEN08)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[13];

                    sqlParams[0] = new SqlParameter("@inv_codIde", objSFRRMBEN08.inv_codIde);
                    sqlParams[1] = new SqlParameter("@CodAlmacen", objSFRRMBEN08.CodAlmacen);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN08.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@invd_estado", objSFRRMBEN08.invd_estado);
                    sqlParams[4] = new SqlParameter("@invd_stockDoc", objSFRRMBEN08.invd_stockDoc);
                    sqlParams[5] = new SqlParameter("@invd_stockDocAnterior", objSFRRMBEN08.invd_stockDocAnterior);
                    sqlParams[6] = new SqlParameter("@invd_stockReal", objSFRRMBEN08.invd_stockReal);
                    sqlParams[7] = new SqlParameter("@invd_stockRealAnterior", objSFRRMBEN08.invd_stockRealAnterior);
                    sqlParams[8] = new SqlParameter("@invd_valor", objSFRRMBEN08.invd_valor);
                    sqlParams[9] = new SqlParameter("@Usu_Crea", objSFRRMBEN08.Usu_Crea);
                    sqlParams[10] = new SqlParameter("@Fec_Crea", objSFRRMBEN08.Fec_Crea);
                    sqlParams[11] = new SqlParameter("@Usu_Upd", objSFRRMBEN08.Usu_Upd);
                    sqlParams[12] = new SqlParameter("@Fec_Upd", objSFRRMBEN08.Fec_Upd);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN08UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string invd_codIde)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@invd_codIde", invd_codIde);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN08DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN08 llenarObjeto(SqlDataReader dr)
        {
            SFRRMBEN08 objSFRRMBEN08 = new SFRRMBEN08();
            objSFRRMBEN08.inv_codIde = Convert.ToInt32(dr["inv_codIde"]);
            objSFRRMBEN08.CodAlmacen = Convert.ToString(dr["CodAlmacen"]);
            objSFRRMBEN08.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"]);
            objSFRRMBEN08.invd_estado = Convert.ToInt32(dr["invd_estado"]);
            objSFRRMBEN08.invd_stockDoc = Convert.ToInt32(dr["invd_stockDoc"]);
            objSFRRMBEN08.invd_stockDocAnterior = Convert.ToInt32(dr["invd_stockDocAnterior"]);
            objSFRRMBEN08.invd_stockReal = Convert.ToInt32(dr["invd_stockReal"]);
            objSFRRMBEN08.invd_stockRealAnterior = Convert.ToInt32(dr["invd_stockRealAnterior"]);
            objSFRRMBEN08.invd_valor = Convert.ToInt32(dr["invd_valor"]);
            objSFRRMBEN08.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN08.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN08.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN08.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);

            return objSFRRMBEN08;
        }
    }
}
