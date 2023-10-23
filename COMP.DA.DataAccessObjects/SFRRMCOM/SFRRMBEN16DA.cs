using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMBEN16DA
    {
        public List<SFRRMCOM05_List> ListarRegistros(string codigo)
        {
            List<SFRRMCOM05_List> objSFRRMBEN16 = new List<SFRRMCOM05_List>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Bie_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN16SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN16.Add(llenarObjeto2(dr));
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

            return objSFRRMBEN16;
        }

        public SFRRMCOM05 obtenerDatosId(string codigo)
        {
            SFRRMCOM05 objSFRRMBEN16 = new SFRRMCOM05();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Bie_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN16SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN16 = llenarObjeto1(dr);
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

            return objSFRRMBEN16;
        }

        public String insertarRegistro(SFRRMCOM05 objSFRRMBEN16)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[7];
                    
                    sqlParams[0] = new SqlParameter("@Bie_Codigo", objSFRRMBEN16.Bie_Codigo);
                    sqlParams[1] = new SqlParameter("@Bie_Nombre", objSFRRMBEN16.Bie_Nombre);
                    sqlParams[2] = new SqlParameter("@Bie_Observaciones", objSFRRMBEN16.Bie_Observaciones);
                    sqlParams[3] = new SqlParameter("@Umd_Codigo", objSFRRMBEN16.Umd_Codigo);
                    sqlParams[4] = new SqlParameter("@Capacidad", objSFRRMBEN16.Capacidad);
                    sqlParams[5] = new SqlParameter("@TipCor_Cod", objSFRRMBEN16.TipCor_Cod);
                    sqlParams[6] = new SqlParameter("@Bie_Estado", objSFRRMBEN16.Bie_Estado);

                   String Codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN16InsProc", sqlParams).ToString();
                   return Codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public void actualizarRegistro(SFRRMCOM05 objSFRRMBEN16)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[7];

                    sqlParams[0] = new SqlParameter("@Bie_Codigo", objSFRRMBEN16.Bie_Codigo);
                    sqlParams[1] = new SqlParameter("@Bie_Nombre", objSFRRMBEN16.Bie_Nombre);
                    sqlParams[2] = new SqlParameter("@Bie_Observaciones", objSFRRMBEN16.Bie_Observaciones);
                    sqlParams[3] = new SqlParameter("@Umd_Codigo", objSFRRMBEN16.Umd_Codigo);
                    sqlParams[4] = new SqlParameter("@Capacidad", objSFRRMBEN16.Capacidad);
                    sqlParams[5] = new SqlParameter("@TipCor_Cod", objSFRRMBEN16.TipCor_Cod);
                    sqlParams[6] = new SqlParameter("@Bie_Estado", objSFRRMBEN16.Bie_Estado);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN16UpdProc", sqlParams);
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
                    sqlParams[0] = new SqlParameter("@Bie_Codigo", codigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN16DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM05_List llenarObjeto2(SqlDataReader dr)
        {
            SFRRMCOM05_List objSFRRMBEN16 = new SFRRMCOM05_List();
            objSFRRMBEN16.Bie_Codigo = dr["Bie_Codigo"].ToString().Trim();
            objSFRRMBEN16.Bie_Nombre = dr["Bie_Nombre"].ToString().Trim();

            return objSFRRMBEN16;
        }

        private SFRRMCOM05 llenarObjeto1(SqlDataReader dr)
        {
            SFRRMCOM05 objSFRRMBEN16 = new SFRRMCOM05();
            objSFRRMBEN16.Bie_Codigo = dr["Bie_Codigo"].ToString().Trim();
            objSFRRMBEN16.Bie_Nombre = dr["Bie_Nombre"].ToString().Trim();
            objSFRRMBEN16.Bie_Observaciones = dr["Bie_Observaciones"].ToString().Trim();
            objSFRRMBEN16.Umd_Codigo = dr["Umd_Codigo"].ToString().Trim();
            objSFRRMBEN16.Unidades = 1;
            objSFRRMBEN16.Capacidad = dr["Capacidad"].ToString().Trim();
            objSFRRMBEN16.TipCor_Cod = dr["TipCor_Cod"].ToString().Trim();
            objSFRRMBEN16.Bie_Estado = dr["Bie_Estado"].ToString().Trim();
            objSFRRMBEN16.Usu_Crea = dr["Usu_Crea"].ToString().Trim();
            objSFRRMBEN16.Fec_Crea = dr["Fec_Crea"].ToString().Trim();
            objSFRRMBEN16.Usu_Upd = dr["Usu_Upd"].ToString().Trim();
            objSFRRMBEN16.Fec_Upd = dr["Fec_Upd"].ToString().Trim();
            objSFRRMBEN16.DeP_Codi = dr["DeP_Codi"].ToString().Trim();

            return objSFRRMBEN16;
        }
    }
}
