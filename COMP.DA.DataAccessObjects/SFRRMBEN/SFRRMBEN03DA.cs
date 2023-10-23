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
    public class SFRRMBEN03DA
    {
        public List<SFRRMBEN03> obtenerDatosTipOperId(string TipOper)
        {
            List<SFRRMBEN03> objSFRRMBEN03 = new List<SFRRMBEN03>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@TipOper", TipOper);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN03SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN03.Add(llenarObjetoTipoAlmacen(dr));
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

            return objSFRRMBEN03;
        }


        public String insertarRegistroTipOperacion(SFRRMBEN03 objSFRRMBEN03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[4];

                    sqlParams[0] = new SqlParameter("@TipOper", objSFRRMBEN03.TipOper);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN03.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@Comentario", objSFRRMBEN03.Comentario);
                    sqlParams[3] = new SqlParameter("@Estado", objSFRRMBEN03.Estado);


                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN03InsProc", sqlParams).ToString();
                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroTipoAlmacen(SFRRMBEN03 objSFRRMBEN03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[4];

                    sqlParams[0] = new SqlParameter("@TipOper", objSFRRMBEN03.TipOper);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN03.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@Comentario", objSFRRMBEN03.Comentario);
                    sqlParams[3] = new SqlParameter("@Estado", objSFRRMBEN03.Estado);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN03UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroTipoAlmance(string TipOper)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@TipOper", TipOper);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN03DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN03 llenarObjetoTipoAlmacen(SqlDataReader dr)
        {
            SFRRMBEN03 objSFRRMBEN03 = new SFRRMBEN03();
            objSFRRMBEN03.TipOper = Convert.ToString(dr["TipOper"]);
            objSFRRMBEN03.DscAlmacen = Convert.ToString(dr["DesOpe"]);
            objSFRRMBEN03.Comentario = Convert.ToString(dr["Comentario"]);
            objSFRRMBEN03.Estado = Convert.ToInt32(dr["Estado"]);

            return objSFRRMBEN03;
        }
    }
}
