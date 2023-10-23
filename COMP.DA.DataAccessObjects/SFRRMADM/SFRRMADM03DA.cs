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
    public class SFRRMADM03DA
    {
        public List<SFRRMADM03> obtenerDatos(int Id_Opcion)
        {
            List<SFRRMADM03> objSFRRMADM03 = new List<SFRRMADM03>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Id_Opcion", Id_Opcion);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "OpcionSelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMADM03.Add(llenarObjeto(dr));
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

            return objSFRRMADM03;
        }

        public void insertarRegistro(SFRRMADM03 objSFRRMADM03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@Id_Opcion", objSFRRMADM03.Id_Opcion);
                    sqlParams[1] = new SqlParameter("@padre", objSFRRMADM03.padre);
                    sqlParams[2] = new SqlParameter("@orden", objSFRRMADM03.orden);
                    sqlParams[3] = new SqlParameter("@url", objSFRRMADM03.url);
                    sqlParams[4] = new SqlParameter("@Descripcion", objSFRRMADM03.Descripcion);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "OpcionInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMADM03 objSFRRMADM03)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@Id_Opcion", objSFRRMADM03.Id_Opcion);
                    sqlParams[1] = new SqlParameter("@padre", objSFRRMADM03.padre);
                    sqlParams[2] = new SqlParameter("@orden", objSFRRMADM03.orden);
                    sqlParams[3] = new SqlParameter("@url", objSFRRMADM03.url);
                    sqlParams[4] = new SqlParameter("@Descripcion", objSFRRMADM03.Descripcion);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "OpcionUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(int Id_Opcion)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Id_Opcion", Id_Opcion);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "OpcionDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMADM03 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM03 objSFRRMADM03 = new SFRRMADM03();
            objSFRRMADM03.Id_Opcion = Convert.ToInt32(dr["Id_Opcion"]);
            objSFRRMADM03.padre = Convert.ToInt32(dr["padre"]);
            objSFRRMADM03.orden = Convert.ToInt32(dr["orden"]);
            objSFRRMADM03.url = Convert.ToString(dr["url"]);
            objSFRRMADM03.Descripcion = Convert.ToString(dr["Descripcion"]);

            return objSFRRMADM03;
        }
    }
}
