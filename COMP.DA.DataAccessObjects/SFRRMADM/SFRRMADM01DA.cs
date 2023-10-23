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
    public class SFRRMADM01DA
    {
        public static int LOGEAR_USUARIO(string IId_U, string IClave)
        {

            int resultado = -1;
            SqlDataReader dr = null;

            //using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
            //{
              //  SqlParameter sqlParam = new SqlParameter("@IId_U", IId_U);
              //  SqlParameter sqlParam1 = new SqlParameter("@IClave", IClave);


                //dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                  //   "LOGEAR_USUARIO", sqlParam, sqlParam1);

                //while (dr.Read())
                //{
                //    resultado = 50;
                //}

            //}
            return resultado;
        }

        public  List<SFRRMADM01> obtenerDatos(string Id_Usuario)
        {
            List<SFRRMADM01> objSFRRMADM01 = new List<SFRRMADM01>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@Id_Usuario", Id_Usuario);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "UsuarioSelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMADM01.Add(llenarObjeto(dr));
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

            return objSFRRMADM01;
        }

        public  void insertarRegistro(SFRRMADM01 objSFRRMADM01)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@Id_Usuario", objSFRRMADM01.Id_Usuario);
                    sqlParams[1] = new SqlParameter("@Id_Tipo_Usuaio", objSFRRMADM01.Id_Tipo_Usuaio);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM01.Estado);
                    sqlParams[3] = new SqlParameter("@Contraseña", objSFRRMADM01.Contraseña);
                    sqlParams[4] = new SqlParameter("@Nombre_Usuario", objSFRRMADM01.Nombre_Usuario);
                    sqlParams[5] = new SqlParameter("@Nombre", objSFRRMADM01.Nombre);      

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "UsuarioInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  void actualizarRegistro(SFRRMADM01 objSFRRMADM01)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@Id_Usuario", objSFRRMADM01.Id_Usuario);
                    sqlParams[1] = new SqlParameter("@Id_Tipo_Usuaio", objSFRRMADM01.Id_Tipo_Usuaio);
                    sqlParams[2] = new SqlParameter("@Estado", objSFRRMADM01.Estado);
                    sqlParams[3] = new SqlParameter("@Contraseña", objSFRRMADM01.Contraseña);
                    sqlParams[4] = new SqlParameter("@Nombre_Usuario", objSFRRMADM01.Nombre_Usuario);
                    sqlParams[5] = new SqlParameter("@Nombre", objSFRRMADM01.Nombre);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "UsuarioUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  void eliminarRegistro(string Id_Usuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Id_Usuario", Id_Usuario);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "UsuarioDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private  SFRRMADM01 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM01 objSFRRMADM01 = new SFRRMADM01();
            objSFRRMADM01.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
            objSFRRMADM01.Id_Tipo_Usuaio = Convert.ToInt32(dr["Id_Tipo_Usuaio"]);
            objSFRRMADM01.Estado = Convert.ToString(dr["Estado"]);
            objSFRRMADM01.Contraseña = Convert.ToString(dr["Contraseña"]);
            objSFRRMADM01.Nombre_Usuario = Convert.ToString(dr["Nombre_Usuario"]);
            objSFRRMADM01.Nombre = Convert.ToString(dr["Nombre"]); 

            return objSFRRMADM01;
        }

        public System.Data.DataTable obtenerDatos(string usuario, string contraseña)
        {
            throw new NotImplementedException();
        }


    }
}
