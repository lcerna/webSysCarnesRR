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
    public class SFRRMCOM04DA
    {
        public List<SFRRMCOM04> obtenerDatosId(string codigo)
        {
            List<SFRRMCOM04> objSFRRMBEN11 = new List<SFRRMCOM04>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@CodigoItem", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN15SelProc", sqlParam);

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

        public void insertarRegistro(SFRRMCOM04 objSFRRMBEN11)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CodigoItem", objSFRRMBEN11.CodId);
                    sqlParams[1] = new SqlParameter("@NumeroOC", objSFRRMBEN11.NotCom_Id);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN11.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@Cantidad", Convert.ToDecimal(objSFRRMBEN11.Cantidad));
                    sqlParams[4] = new SqlParameter("@Ped_Codigo", objSFRRMBEN11.Ped_Codigo);
                    sqlParams[5] = new SqlParameter("@Precio", Convert.ToDecimal(objSFRRMBEN11.Precio));

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN15InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMCOM04 objSFRRMBEN11)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CodigoItem", objSFRRMBEN11.CodId);
                    sqlParams[1] = new SqlParameter("@NumeroOC", objSFRRMBEN11.NotCom_Id);
                    sqlParams[2] = new SqlParameter("@Bie_Codigo", objSFRRMBEN11.Bie_Codigo);
                    sqlParams[3] = new SqlParameter("@Cantidad", Convert.ToDecimal(objSFRRMBEN11.Cantidad));
                    sqlParams[4] = new SqlParameter("@Ped_Codigo", objSFRRMBEN11.Ped_Codigo);
                    sqlParams[5] = new SqlParameter("@Precio", Convert.ToDecimal(objSFRRMBEN11.Precio));

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN15UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string codigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@CodigoItem", codigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN15DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM04 llenarObjeto(SqlDataReader dr)
        {
            SFRRMCOM04 objSFRRMBEN15 = new SFRRMCOM04();
            objSFRRMBEN15.CodId = dr["CodigoItem"].ToString().Trim();
            objSFRRMBEN15.NotCom_Id = Convert.ToString(dr["NumeroOC"].ToString().Trim());
            objSFRRMBEN15.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"].ToString().Trim());
            objSFRRMBEN15.Ped_Codigo = Convert.ToString(dr["Ped_Codigo"].ToString().Trim());
            objSFRRMBEN15.Cantidad = Convert.ToString(dr["Cantidad"].ToString().Trim());
            objSFRRMBEN15.Precio = Convert.ToString(dr["Precio"].ToString().Trim());
            objSFRRMBEN15.DES_BIEN = Convert.ToString(dr["DES_BIEN"].ToString().Trim());

            return objSFRRMBEN15;
        }
    }
}
