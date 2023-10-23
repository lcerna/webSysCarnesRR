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
    public class SFRRMADM05DA
    {
        public List<SFRRMADM05> obtenerDatos(int Id_Moneda)
        {
            List<SFRRMADM05> objSFRRMADM05 = new List<SFRRMADM05>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Id_Moneda", Id_Moneda);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "MonedaSelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMADM05.Add(llenarObjeto(dr));
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

            return objSFRRMADM05;
        }

        public void insertarRegistro(SFRRMADM05 objSFRRMADM05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Id_Moneda", objSFRRMADM05.Id_Moneda);
                    sqlParams[1] = new SqlParameter("@Nombre_Moneda", objSFRRMADM05.Nombre_Moneda);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM05.Estado);  

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "MonedaInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMADM05 objSFRRMADM05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Id_Moneda", objSFRRMADM05.Id_Moneda);
                    sqlParams[1] = new SqlParameter("@Nombre_Moneda", objSFRRMADM05.Nombre_Moneda);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM05.Estado);  

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "MonedaUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(int Id_Moneda)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Id_Moneda", Id_Moneda);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "MonedaDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMADM05 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM05 objSFRRMADM05 = new SFRRMADM05();
            objSFRRMADM05.Id_Moneda = Convert.ToInt32(dr["Id_Moneda"]);
            objSFRRMADM05.Nombre_Moneda = Convert.ToString(dr["Nombre_Moneda"]);
            objSFRRMADM05.Estado = Convert.ToString(dr["Estado"]);  

            return objSFRRMADM05;
        }
    }
}
