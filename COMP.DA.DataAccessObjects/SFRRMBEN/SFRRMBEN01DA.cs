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
    public class SFRRMBEN01DA
    {
        public List<SFRRMBEN01> obtenerDatosAlmacenId(string CodAlma)
        {
            List<SFRRMBEN01> objSFRRMBEN01 = new List<SFRRMBEN01>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@CodAlmacen", CodAlma);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN01SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN01.Add(llenarObjetoAlmacen(dr));
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

            return objSFRRMBEN01;
        }

        public String insertarRegistroAlmacen(SFRRMBEN01 objSFRRMBEN01)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@CodAlmacen", objSFRRMBEN01.CodAlmacen);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN01.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@TipAlmacen", objSFRRMBEN01.TipAlmacen);
                    sqlParams[3] = new SqlParameter("@Comentario", String.Empty);
                    sqlParams[4] = new SqlParameter("@Estado", 1);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN01InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroAlmacen(SFRRMBEN01 objSFRRMBEN01)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@CodAlmacen", objSFRRMBEN01.CodAlmacen);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN01.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@TipAlmacen", objSFRRMBEN01.TipAlmacen);
                    sqlParams[3] = new SqlParameter("@Comentario", String.Empty);
                    sqlParams[4] = new SqlParameter("@Estado", 1);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN01UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroAlmance(string CodAlmacen)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@CodAlmacen", CodAlmacen);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN01DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN01 llenarObjetoAlmacen(SqlDataReader dr)
        {
            SFRRMBEN01 objSFRRMBEN01 = new SFRRMBEN01();
            objSFRRMBEN01.CodAlmacen = Convert.ToString(dr["CodAlmacen"]);
            objSFRRMBEN01.DscAlmacen = Convert.ToString(dr["DscAlmacen"]);
            objSFRRMBEN01.TipAlmacen = Convert.ToString(dr["TipAlmacen"]);
            objSFRRMBEN01.Comentario = Convert.ToString(dr["Comentario"]);
            objSFRRMBEN01.Estado = Convert.ToString(dr["Estado"]);

            return objSFRRMBEN01;
        }


    }
}
