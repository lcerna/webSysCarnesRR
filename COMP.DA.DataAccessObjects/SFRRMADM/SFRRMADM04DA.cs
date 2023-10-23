using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RCRR.BL.BusinessEntities.SFRRMADM;
using Microsoft.ApplicationBlocks.Data;
using RCRR.IT.Utils;

namespace RCRR.DA.DataAccessObjects.SFRRMADM
{
    public class SFRRMADM04DA
    {
        public List<SFRRMADM04> obtenerDatos(int Opcion_Userld)
        {
            List<SFRRMADM04> objSFRRMADM04 = new List<SFRRMADM04>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Opcion_Userld", Opcion_Userld);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "Opcion_por_UsuarioSelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMADM04.Add(llenarObjeto(dr));
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

            return objSFRRMADM04;
        }

        public void insertarRegistro(SFRRMADM04 objSFRRMADM04)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Opcion_Userld", objSFRRMADM04.Opcion_Userld);
                    sqlParams[1] = new SqlParameter("@Id_Opcion", objSFRRMADM04.Id_Opcion);
                    sqlParams[2] = new SqlParameter("@Usuario", objSFRRMADM04.Usuario);  

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Opcion_por_UsuarioInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMADM04 objSFRRMADM04)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Opcion_Userld", objSFRRMADM04.Opcion_Userld);
                    sqlParams[1] = new SqlParameter("@Id_Opcion", objSFRRMADM04.Id_Opcion);
                    sqlParams[2] = new SqlParameter("@Usuario", objSFRRMADM04.Usuario);  

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Opcion_por_UsuarioUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(int Opcion_Userld)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Opcion_Userld", Opcion_Userld);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Opcion_por_UsuarioDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMADM04 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM04 objSFRRMADM04 = new SFRRMADM04();
            objSFRRMADM04.Opcion_Userld = Convert.ToInt32(dr["Opcion_Userld"]);
            objSFRRMADM04.Id_Opcion = Convert.ToInt32(dr["Id_Opcion"]);
            objSFRRMADM04.Usuario = Convert.ToString(dr["Usuario"]);   

            return objSFRRMADM04;
        }
    }
}
