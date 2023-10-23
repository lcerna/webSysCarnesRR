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
   public class SFRRMBEN07DA
    {
       public List<SFRRMBEN07> obtenerDatosMovimientoId(string inv_codIde)
        {
            List<SFRRMBEN07> objSFRRMBEN07 = new List<SFRRMBEN07>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@inv_codIde", inv_codIde);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN07SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN07.Add(llenarObjeto(dr));
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

            return objSFRRMBEN07;
        }

        public void insertarRegistroMovimiento(SFRRMBEN07 objSFRRMBEN07)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[10];

                    sqlParams[0] = new SqlParameter("@inv_codIde", objSFRRMBEN07.inv_codIde);
                    sqlParams[1] = new SqlParameter("@inv_descripcion", objSFRRMBEN07.inv_descripcion);
                    sqlParams[2] = new SqlParameter("@inv_fecha", objSFRRMBEN07.inv_fecha);
                    sqlParams[3] = new SqlParameter("@inv_tipo", objSFRRMBEN07.inv_tipo);
                    sqlParams[4] = new SqlParameter("@inv_estado", objSFRRMBEN07.inv_estado);
                    sqlParams[5] = new SqlParameter("@Usu_Crea", objSFRRMBEN07.Usu_Crea);
                    sqlParams[6] = new SqlParameter("@Fec_Crea", objSFRRMBEN07.Fec_Crea);
                    sqlParams[7] = new SqlParameter("@Usu_Upd", objSFRRMBEN07.Usu_Upd);
                    sqlParams[8] = new SqlParameter("@Fec_Upd", objSFRRMBEN07.Fec_Upd);
                    sqlParams[9] = new SqlParameter("@aud_status", objSFRRMBEN07.aud_status);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN07InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroMovimiento(SFRRMBEN07 objSFRRMBEN07)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[10];

                    sqlParams[0] = new SqlParameter("@inv_codIde", objSFRRMBEN07.inv_codIde);
                    sqlParams[1] = new SqlParameter("@inv_descripcion", objSFRRMBEN07.inv_descripcion);
                    sqlParams[2] = new SqlParameter("@inv_fecha", objSFRRMBEN07.inv_fecha);
                    sqlParams[3] = new SqlParameter("@inv_tipo", objSFRRMBEN07.inv_tipo);
                    sqlParams[4] = new SqlParameter("@inv_estado", objSFRRMBEN07.inv_estado);
                    sqlParams[5] = new SqlParameter("@Usu_Crea", objSFRRMBEN07.Usu_Crea);
                    sqlParams[6] = new SqlParameter("@Fec_Crea", objSFRRMBEN07.Fec_Crea);
                    sqlParams[7] = new SqlParameter("@Usu_Upd", objSFRRMBEN07.Usu_Upd);
                    sqlParams[8] = new SqlParameter("@Fec_Upd", objSFRRMBEN07.Fec_Upd);
                    sqlParams[9] = new SqlParameter("@aud_status", objSFRRMBEN07.aud_status);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN07UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroMovimiento(string inv_codIde)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@NroMovimiento", inv_codIde);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN07DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN07 llenarObjeto(SqlDataReader dr)
        {
            SFRRMBEN07 objSFRRMBEN07 = new SFRRMBEN07();
            objSFRRMBEN07.inv_codIde = Convert.ToInt32(dr["inv_codIde"]);
            objSFRRMBEN07.inv_descripcion = Convert.ToString(dr["inv_descripcion"]);
            objSFRRMBEN07.inv_fecha = Convert.ToDateTime(dr["inv_fecha"]);
            objSFRRMBEN07.inv_tipo = Convert.ToInt32(dr["inv_tipo"]);
            objSFRRMBEN07.inv_estado = Convert.ToInt32(dr["inv_estado"]);
            objSFRRMBEN07.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN07.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN07.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN07.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);
            objSFRRMBEN07.aud_status = Convert.ToInt32(dr["aud_status"]);

            return objSFRRMBEN07;
        }

    }
}
