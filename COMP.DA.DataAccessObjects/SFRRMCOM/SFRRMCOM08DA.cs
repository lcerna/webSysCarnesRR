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
    public class SFRRMCOM08DA
    {
        public List<SFRRMCOM08> obtenerDatosAlmacenId(string codigo)
        {
            List<SFRRMCOM08> objSFRRMBEN19 = new List<SFRRMCOM08>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@TipCor_Cod", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN19SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN19.Add(llenarObjetoAlmacen(dr));
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

            return objSFRRMBEN19;
        }

        public String insertarRegistroAlmacen(SFRRMCOM08 objSFRRMBEN19)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@TipCor_Cod", objSFRRMBEN19.TipCor_Cod);
                    sqlParams[1] = new SqlParameter("@TipCor_Descrip", objSFRRMBEN19.TipCor_Descrip);
                    sqlParams[2] = new SqlParameter("@TipCor_Estado", objSFRRMBEN19.TipCor_Estado);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN19InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ValidaEliminar(String sCodigo)
        {
            using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
            {
                SqlParameter[] sqlParams = new SqlParameter[1];
                sqlParams[0] = new SqlParameter("@TipCor_Cod", sCodigo);

                int iVal = int.Parse(SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                      "sp_val_TipCorCod", sqlParams).ToString());

                return iVal;
            }
        }


        public void actualizarRegistroAlmacen(SFRRMCOM08 objSFRRMBEN19)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@TipCor_Cod", objSFRRMBEN19.TipCor_Cod);
                    sqlParams[1] = new SqlParameter("@TipCor_Descrip", objSFRRMBEN19.TipCor_Descrip);
                    sqlParams[2] = new SqlParameter("@TipCor_Estado", objSFRRMBEN19.TipCor_Estado);


                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN19UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroAlmance(string codigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@TipCor_Cod", codigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN19DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM08 llenarObjetoAlmacen(SqlDataReader dr)
        {
            SFRRMCOM08 objSFRRMBEN19 = new SFRRMCOM08();
            objSFRRMBEN19.TipCor_Cod = Convert.ToString(dr["TipCor_Cod"]);
            objSFRRMBEN19.TipCor_Descrip = Convert.ToString(dr["TipCor_Descrip"]);
            objSFRRMBEN19.TipCor_Estado = Convert.ToString(dr["TipCor_Estado"]);

            return objSFRRMBEN19;
        }
    }
}
