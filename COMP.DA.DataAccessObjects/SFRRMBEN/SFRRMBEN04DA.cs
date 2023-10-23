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
    public class SFRRMBEN04DA
    {
        public List<SFRRMBEN04> obtenerDatosMovimientoId(string CodMovimiento)
        {
            List<SFRRMBEN04> objSFRRMBEN04 = new List<SFRRMBEN04>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@CodMovimiento", CodMovimiento);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN04SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN04.Add(llenarObjetoTipoAlmacen(dr));
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

            return objSFRRMBEN04;
        }


        public String insertarRegistroMovimiento(SFRRMBEN04 objSFRRMBEN04)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CodMovimiento", objSFRRMBEN04.CodMovimiento);
                    sqlParams[1] = new SqlParameter("@DscMovimiento", objSFRRMBEN04.DscMovimiento);
                    sqlParams[2] = new SqlParameter("@DscCorto", objSFRRMBEN04.DscCorto);
                    sqlParams[3] = new SqlParameter("@CodigoSunat", objSFRRMBEN04.CodigoSunat);
                    sqlParams[4] = new SqlParameter("@TipOper", objSFRRMBEN04.TipOper);
                    sqlParams[5] = new SqlParameter("@Estado", objSFRRMBEN04.Estado);

                   String Codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN04InsProc", sqlParams).ToString();

                   return Codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroMovimiento(SFRRMBEN04 objSFRRMBEN04)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CodMovimiento", objSFRRMBEN04.CodMovimiento);
                    sqlParams[1] = new SqlParameter("@DscMovimiento", objSFRRMBEN04.DscMovimiento);
                    sqlParams[2] = new SqlParameter("@DscCorto", objSFRRMBEN04.DscCorto);
                    sqlParams[3] = new SqlParameter("@CodigoSunat", objSFRRMBEN04.CodigoSunat);
                    sqlParams[4] = new SqlParameter("@TipOper", objSFRRMBEN04.TipOper);
                    sqlParams[5] = new SqlParameter("@Estado", objSFRRMBEN04.Estado);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN04UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroMovimiento(string CodMovimiento)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@CodMovimiento", CodMovimiento);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN04DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN04 llenarObjetoTipoAlmacen(SqlDataReader dr)
        {
            SFRRMBEN04 objSFRRMBEN04 = new SFRRMBEN04();
            objSFRRMBEN04.CodMovimiento = Convert.ToString(dr["CodMovimiento"]);
            objSFRRMBEN04.DscMovimiento = Convert.ToString(dr["DscMovimiento"]);
            objSFRRMBEN04.DscCorto = Convert.ToString(dr["DscCorto"]);
            objSFRRMBEN04.CodigoSunat = Convert.ToString(dr["CodigoSunat"]);
            objSFRRMBEN04.TipOper = Convert.ToString(dr["TipOper"]);
            objSFRRMBEN04.Estado = Convert.ToInt32(dr["Estado"]);

            return objSFRRMBEN04;
        }
    }
}
