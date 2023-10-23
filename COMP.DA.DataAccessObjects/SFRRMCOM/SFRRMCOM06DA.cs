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
    public class SFRRMCOM06DA
    {
        public List<SFRRMCOM06> obtenerDatosId(string codigo)
        {
            List<SFRRMCOM06> objSFRRMBEN17 = new List<SFRRMCOM06>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Umd_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN17SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN17.Add(llenarObjeto(dr));
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

            return objSFRRMBEN17;
        }

        public String insertarRegistro(SFRRMCOM06 objSFRRMBEN17)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@Umd_Codigo", objSFRRMBEN17.Cod_Udm);
                    sqlParams[1] = new SqlParameter("@Umd_Nombre", objSFRRMBEN17.Nombre);
                    sqlParams[2] = new SqlParameter("@Umd_Estado", "1");
                    sqlParams[3] = new SqlParameter("@Abreviatura", objSFRRMBEN17.Abreviatura);
                    sqlParams[4] = new SqlParameter("@Observaciones", objSFRRMBEN17.Observacion);
                    sqlParams[5] = new SqlParameter("@CodigoSunat", objSFRRMBEN17.Codigo_Sunat);


                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN17InsProc", sqlParams).ToString();
                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMCOM06 objSFRRMBEN17)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@Umd_Codigo", objSFRRMBEN17.Cod_Udm);
                    sqlParams[1] = new SqlParameter("@Umd_Nombre", objSFRRMBEN17.Nombre);
                    sqlParams[2] = new SqlParameter("@Umd_Estado", "1");
                    sqlParams[3] = new SqlParameter("@Abreviatura", objSFRRMBEN17.Abreviatura);
                    sqlParams[4] = new SqlParameter("@Observaciones", objSFRRMBEN17.Observacion);
                    sqlParams[5] = new SqlParameter("@CodigoSunat", objSFRRMBEN17.Codigo_Sunat);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN17UpdProc", sqlParams);
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
                    sqlParams[0] = new SqlParameter("@Umd_Codigo", codigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN17DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM06 llenarObjeto(SqlDataReader dr)
        {
            SFRRMCOM06 objSFRRMBEN17 = new SFRRMCOM06();
            objSFRRMBEN17.Cod_Udm = Convert.ToString(dr["Umd_Codigo"]);
            objSFRRMBEN17.Nombre = Convert.ToString(dr["Umd_Nombre"]);
            objSFRRMBEN17.Abreviatura = Convert.ToString(dr["Abreviatura"]);
            objSFRRMBEN17.Observacion = Convert.ToString(dr["Observaciones"]);
            objSFRRMBEN17.Codigo_Sunat = Convert.ToString(dr["CodigoSunat"]);



            return objSFRRMBEN17;
        }
    }
}
