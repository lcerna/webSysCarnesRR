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
    public class SFRRMADM06DA
    {
        public List<SFRRMADM06> obtenerDatos(int Id_Tasa_Cambio, int Id_Moneda, DateTime Fecha)
        {
            List<SFRRMADM06> objSFRRMADM06 = new List<SFRRMADM06>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {


                    SqlParameter sqlParam = new SqlParameter("@Id_Tasa_Cambio", Id_Tasa_Cambio);
                    SqlParameter sqlParam1 = new SqlParameter("@Id_Tasa_Cambio", Id_Moneda);
                    SqlParameter sqlParam2 = new SqlParameter("@Id_Tasa_Cambio", Fecha);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "Tasa_de_cambioSelProc", sqlParam, sqlParam1, sqlParam2);

                    while (dr.Read())
                    {
                        objSFRRMADM06.Add(llenarObjeto(dr));
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

            return objSFRRMADM06;
        }

        public void insertarRegistro(SFRRMADM06 objSFRRMADM06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@Id_Moneda", objSFRRMADM06.Id_Moneda);
                    sqlParams[1] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.Id_Tasa_Cambio);
                    sqlParams[2] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.tip_compra);
                    sqlParams[3] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.tip_venta);
                    sqlParams[4] = new SqlParameter("@Estado", objSFRRMADM06.Estado);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tasa_de_cambioInsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMADM06 objSFRRMADM06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[5];

                    sqlParams[0] = new SqlParameter("@Id_Moneda", objSFRRMADM06.Id_Moneda);
                    sqlParams[1] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.Id_Tasa_Cambio);
                    sqlParams[2] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.tip_compra);
                    sqlParams[3] = new SqlParameter("@Nombre_Moneda", objSFRRMADM06.tip_venta);
                    sqlParams[4] = new SqlParameter("@Estado", objSFRRMADM06.Estado);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tasa_de_cambioUpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(int Id_Tasa_Cambio)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@Id_Tasa_Cambio", Id_Tasa_Cambio);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "Tasa_de_cambioDelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMADM06 llenarObjeto(SqlDataReader dr)
        {
            SFRRMADM06 objSFRRMADM06 = new SFRRMADM06();
            objSFRRMADM06.Id_Moneda = Convert.ToInt32(dr["Id_Moneda"]);
            objSFRRMADM06.Id_Tasa_Cambio = Convert.ToInt32(dr["Nombre_Moneda"]);
            objSFRRMADM06.tip_compra = Convert.ToDouble(dr["tip_compra"]);
            objSFRRMADM06.tip_venta = Convert.ToDouble(dr["tip_venta"]);
            objSFRRMADM06.Estado = Convert.ToInt32(dr["Estado"]);

            return objSFRRMADM06;
        }
    }
}
