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
    public class SFRRMBEN02DA
    {
        public List<SFRRMBEN02> obtenerDatosTipAlmacenId(string TipAlma)
        {
            List<SFRRMBEN02> objSFRRMBEN02 = new List<SFRRMBEN02>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@TipAlmacen", TipAlma);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN02SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN02.Add(llenarObjetoTipoAlmacen(dr));
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

            return objSFRRMBEN02;
        }


        public void insertarRegistroTipoAlmacen(SFRRMBEN02 objSFRRMBEN02)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[4];

                    sqlParams[0] = new SqlParameter("@TipAlmacen", objSFRRMBEN02.TipAlmacen);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN02.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@Comentario", objSFRRMBEN02.Comentario);
                    sqlParams[3] = new SqlParameter("@Estado", objSFRRMBEN02.Estado);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN02InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroTipoAlmacen(SFRRMBEN02 objSFRRMBEN02)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[4];

                    sqlParams[0] = new SqlParameter("@TipAlmacen", objSFRRMBEN02.TipAlmacen);
                    sqlParams[1] = new SqlParameter("@DscAlmacen", objSFRRMBEN02.DscAlmacen);
                    sqlParams[2] = new SqlParameter("@Comentario", objSFRRMBEN02.Comentario);
                    sqlParams[3] = new SqlParameter("@Estado", objSFRRMBEN02.Estado);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN02UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroTipoAlmance(string TipAlma)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@TipAlmacen", TipAlma);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN02DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN02 llenarObjetoTipoAlmacen(SqlDataReader dr)
        {
            SFRRMBEN02 objSFRRMBEN02 = new SFRRMBEN02();
            objSFRRMBEN02.TipAlmacen = Convert.ToString(dr["TipAlmacen"]);
            objSFRRMBEN02.DscAlmacen = Convert.ToString(dr["DscAlmacen"]);
            objSFRRMBEN02.Comentario = Convert.ToString(dr["Comentario"]);
            objSFRRMBEN02.Estado = Convert.ToString(dr["Comentario"]);
           
            return objSFRRMBEN02;
        }
    }
}
