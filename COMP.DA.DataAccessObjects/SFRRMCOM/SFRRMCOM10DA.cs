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
    public class SFRRMCOM10DA
    {
        public List<SFRRMCOM10_List> ListarRegistros(string codigo)
        {
            List<SFRRMCOM10_List> objSFRRMBEN21 = new List<SFRRMCOM10_List>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Prov_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN21SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN21.Add(llenarObjeto2(dr));
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

            return objSFRRMBEN21;
        }

        public SFRRMCOM10 obtenerDatosId(string codigo)
        {
            SFRRMCOM10 objSFRRMBEN11 = new SFRRMCOM10();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Prov_Codigo", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN21SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN11 = llenarObjeto(dr);
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

        public String insertarRegistro(SFRRMCOM10 eSFRRMBEN21)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[18];

                    //sqlParams[0] = new SqlParameter("@Prov_Codigo", eSFRRMBEN21.Prov_Codigo);
                    //sqlParams[1] = new SqlParameter("@Tip_Doc", eSFRRMBEN21.Tip_Doc);
                    //sqlParams[2] = new SqlParameter("@Prov_NumDoc", eSFRRMBEN21.Prov_NumDoc);
                    //sqlParams[3] = new SqlParameter("@Prov_Nombre", eSFRRMBEN21.Prov_Nombre);
                    //sqlParams[4] = new SqlParameter("@Prov_Direccion", eSFRRMBEN21.Prov_Direccion);
                    //sqlParams[5] = new SqlParameter("@Prov_Telefono", eSFRRMBEN21.Prov_Telefono);
                    //sqlParams[6] = new SqlParameter("@Prov_TipTelf", eSFRRMBEN21.Prov_TipTelf);
                    //sqlParams[7] = new SqlParameter("@Prov_Contacto", eSFRRMBEN21.Prov_Contacto);
                    //sqlParams[8] = new SqlParameter("@Prov_email", eSFRRMBEN21.Prov_email);
                    //sqlParams[9] = new SqlParameter("@Prov_Observaciones", eSFRRMBEN21.Prov_Observaciones);
                    //sqlParams[10] = new SqlParameter("@Depa", eSFRRMBEN21.Depa);
                    //sqlParams[11] = new SqlParameter("@Prov", eSFRRMBEN21.Prov);
                    //sqlParams[12] = new SqlParameter("@Dist", eSFRRMBEN21.Dist);
                    //sqlParams[13] = new SqlParameter("@Prov_Estado", eSFRRMBEN21.Prov_Estado);
                    //sqlParams[14] = new SqlParameter("@Usu_Crea", eSFRRMBEN21.Usu_Crea);
                    //sqlParams[15] = new SqlParameter("@Fec_Crea", eSFRRMBEN21.Fec_Crea);
                    //sqlParams[16] = new SqlParameter("@Usu_Upd", eSFRRMBEN21.Usu_Upd);
                    //sqlParams[17] = new SqlParameter("@Fec_upd", eSFRRMBEN21.Fec_upd);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN21InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMCOM10 eSFRRMBEN21)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[18];

                    //sqlParams[0] = new SqlParameter("@Prov_Codigo", eSFRRMBEN21.Prov_Codigo);
                    //sqlParams[1] = new SqlParameter("@Tip_Doc", eSFRRMBEN21.Tip_Doc);
                    //sqlParams[2] = new SqlParameter("@Prov_NumDoc", eSFRRMBEN21.Prov_NumDoc);
                    //sqlParams[3] = new SqlParameter("@Prov_Nombre", eSFRRMBEN21.Prov_Nombre);
                    //sqlParams[4] = new SqlParameter("@Prov_Direccion", eSFRRMBEN21.Prov_Direccion);
                    //sqlParams[5] = new SqlParameter("@Prov_Telefono", eSFRRMBEN21.Prov_Telefono);
                    //sqlParams[6] = new SqlParameter("@Prov_TipTelf", eSFRRMBEN21.Prov_TipTelf);
                    //sqlParams[7] = new SqlParameter("@Prov_Contacto", eSFRRMBEN21.Prov_Contacto);
                    //sqlParams[8] = new SqlParameter("@Prov_email", eSFRRMBEN21.Prov_email);
                    //sqlParams[9] = new SqlParameter("@Prov_Observaciones", eSFRRMBEN21.Prov_Observaciones);
                    //sqlParams[10] = new SqlParameter("@Depa", eSFRRMBEN21.Depa);
                    //sqlParams[11] = new SqlParameter("@Prov", eSFRRMBEN21.Prov);
                    //sqlParams[12] = new SqlParameter("@Dist", eSFRRMBEN21.Dist);
                    //sqlParams[13] = new SqlParameter("@Prov_Estado", eSFRRMBEN21.Prov_Estado);
                    //sqlParams[14] = new SqlParameter("@Usu_Crea", eSFRRMBEN21.Usu_Crea);
                    //sqlParams[15] = new SqlParameter("@Fec_Crea", eSFRRMBEN21.Fec_Crea);
                    //sqlParams[16] = new SqlParameter("@Usu_Upd", eSFRRMBEN21.Usu_Upd);
                    //sqlParams[17] = new SqlParameter("@Fec_upd", eSFRRMBEN21.Fec_upd);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN21UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string sCodigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];
                    sqlParams[0] = new SqlParameter("@Prov_Codigo", sCodigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN21DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM10 llenarObjeto(SqlDataReader dr)
        {
            SFRRMCOM10 eSFRRMBEN21 = new SFRRMCOM10();
            //eSFRRMBEN21.Prov_Codigo = dr["Prov_Codigo"].ToString().Trim();
            //eSFRRMBEN21.Tip_Doc = dr["Tip_Doc"].ToString().Trim();
            //eSFRRMBEN21.Prov_NumDoc = dr["Prov_NumDoc"].ToString().Trim();
            //eSFRRMBEN21.Prov_Nombre = dr["Prov_Nombre"].ToString().Trim();
            //eSFRRMBEN21.Prov_Direccion = dr["Prov_Direccion"].ToString().Trim();
            //eSFRRMBEN21.Prov_Telefono = dr["Prov_Telefono"].ToString().Trim();
            //eSFRRMBEN21.Prov_TipTelf = dr["Prov_TipTelf"].ToString().Trim();
            //eSFRRMBEN21.Prov_Contacto = dr["Prov_Contacto"].ToString().Trim();
            //eSFRRMBEN21.Prov_email = dr["Prov_email"].ToString().Trim();
            //eSFRRMBEN21.Prov_Observaciones = dr["Prov_Observaciones"].ToString().Trim();
            //eSFRRMBEN21.Depa = dr["Depa"].ToString().Trim();
            //eSFRRMBEN21.Prov = dr["Prov"].ToString().Trim();
            //eSFRRMBEN21.Dist = dr["Dist"].ToString().Trim();
            //eSFRRMBEN21.Prov_Estado = dr["Prov_Estado"].ToString().Trim();
            //eSFRRMBEN21.Usu_Crea = dr["Usu_Crea"].ToString().Trim();
            //eSFRRMBEN21.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"].ToString().Trim());
            //eSFRRMBEN21.Usu_Upd = dr["Usu_Upd"].ToString().Trim();
            //eSFRRMBEN21.Fec_upd = Convert.ToDateTime(dr["Fec_upd"].ToString().Trim());

            return eSFRRMBEN21;
        }

        private SFRRMCOM10_List llenarObjeto2(SqlDataReader dr)
        {
            SFRRMCOM10_List eSFRRMBEN21 = new SFRRMCOM10_List();
            eSFRRMBEN21.Prov_Codigo = dr["Prov_Codigo"].ToString().Trim();
            eSFRRMBEN21.Prov_NumDoc = dr["Prov_NumDoc"].ToString().Trim();
            eSFRRMBEN21.Prov_Nombre = dr["Prov_Nombre"].ToString().Trim();

            return eSFRRMBEN21;
        }
    }
}
