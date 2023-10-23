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
    public class SFRRMADM02DA
    {
        public List<SFRRMADM02> obtenerDatos(int Id_Tipo_Usuaio)
        {
            List<SFRRMADM02> objSFRRMADM02 = new List<SFRRMADM02>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Id_Tipo_Usuaio", Id_Tipo_Usuaio);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "Tipo_usuarioSelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMADM02.Add(llenarObjeto(dr));
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

            return objSFRRMADM02;
        }

        public List<SFRRMADM02> obtenerDatos_V2()
        {
            List<SFRRMADM02> objSFRRMADM02 = new List<SFRRMADM02>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,"Tipo_usuarioSelProcGet");

                    while (dr.Read())
                    {
                        objSFRRMADM02.Add(llenarObjeto(dr));
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

            return objSFRRMADM02;
        }

        public void insertarRegistro(SFRRMADM02 objSFRRMADM02)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Id_Tipo_Usuaio", objSFRRMADM02.Id_Tipo_Usuario);
                    sqlParams[1] = new SqlParameter("@Nombre_Tipo", objSFRRMADM02.Nombre_Tipo);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM02.Estado); 

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tipo_usuarioInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMADM02 objSFRRMADM02)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[3];

                    sqlParams[0] = new SqlParameter("@Id_Tipo_Usuaio", objSFRRMADM02.Id_Tipo_Usuario);
                    sqlParams[1] = new SqlParameter("@Nombre_Tipo", objSFRRMADM02.Nombre_Tipo);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM02.Estado); 

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tipo_usuarioUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(int Id_Tipo_Usuaio)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Id_Tipo_Usuaio", Id_Tipo_Usuaio);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tipo_usuarioDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SFRRMADM02> obtenerDatos2(string desc)
        {
            List<SFRRMADM02> objSFRRMADM02 = new List<SFRRMADM02>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMADM02SelProc");

                    while (dr.Read())
                    {
                        objSFRRMADM02.Add(llenarObjeto(dr));
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

            return objSFRRMADM02;
        }


        private SFRRMADM02 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM02 objSFRRMADM02 = new SFRRMADM02();
            objSFRRMADM02.Id_Tipo_Usuario = Convert.ToInt32(dr["Id_Tipo_Usuario"]);
            objSFRRMADM02.Nombre_Tipo = Convert.ToString(dr["Nombre_Tipo"]);
            objSFRRMADM02.Estado = Convert.ToString(dr["Estado"]); 

            return objSFRRMADM02;
        }
    }
}
