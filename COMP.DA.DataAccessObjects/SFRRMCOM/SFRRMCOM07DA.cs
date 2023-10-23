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
    public class SFRRMCOM07DA
    {
        public List<SFRRMCOM07> obtenerDatosAlmacenId(string PrecProv)
        {
            List<SFRRMCOM07> objSFRRMBEN18 = new List<SFRRMCOM07>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@CTarifario", PrecProv);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN18SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN18.Add(llenarObjetoAlmacen(dr));
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

            return objSFRRMBEN18;
        }

        public String insertarRegistroAlmacen(SFRRMCOM07 objSFRRMBEN18)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CTarifario", objSFRRMBEN18.CTarifario);
                    sqlParams[1] = new SqlParameter("@Descripcion", objSFRRMBEN18.Descripcion);
                    sqlParams[2] = new SqlParameter("@Prov_Codigo", objSFRRMBEN18.Prov_Codigo);
                    sqlParams[3] = new SqlParameter("@Bie_Codigo", objSFRRMBEN18.Bie_Codigo);
                    sqlParams[4] = new SqlParameter("@Precio", objSFRRMBEN18.Precio);
                    sqlParams[5] = new SqlParameter("@Estado", 1);

                    String sCodigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN18InsProc", sqlParams).ToString();

                    return sCodigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroAlmacen(SFRRMCOM07 objSFRRMBEN18)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[6];

                    sqlParams[0] = new SqlParameter("@CTarifario", objSFRRMBEN18.CTarifario);
                    sqlParams[1] = new SqlParameter("@Descripcion", objSFRRMBEN18.Descripcion);
                    sqlParams[2] = new SqlParameter("@Prov_Codigo", objSFRRMBEN18.Prov_Codigo);
                    sqlParams[3] = new SqlParameter("@Bie_Codigo", objSFRRMBEN18.Bie_Codigo);
                    sqlParams[4] = new SqlParameter("@Precio", objSFRRMBEN18.Precio);
                    sqlParams[5] = new SqlParameter("@Estado", 1);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN18UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroAlmance(string PrecProv)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    sqlParams[0] = new SqlParameter("@CTarifario", PrecProv);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN18DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM07 llenarObjetoAlmacen(SqlDataReader dr)
        {
            SFRRMCOM07 objSFRRMBEN18 = new SFRRMCOM07();
            objSFRRMBEN18.CTarifario = Convert.ToString(dr["CTarifario"]);
            objSFRRMBEN18.Descripcion = Convert.ToString(dr["Descripcion"]);
            objSFRRMBEN18.Prov_Codigo = Convert.ToString(dr["Prov_Codigo"]);
            objSFRRMBEN18.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"]);
            objSFRRMBEN18.Precio = Convert.ToString(dr["Precio"]);
            objSFRRMBEN18.Estado = Convert.ToString(dr["Estado"]);

            return objSFRRMBEN18;
        }
    }
}
