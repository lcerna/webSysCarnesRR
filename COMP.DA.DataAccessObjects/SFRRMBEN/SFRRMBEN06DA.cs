using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.IT.Utils;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace RCRR.DA.DataAccessObjects.SFRRMBEN
{
    public class SFRRMBEN06DA
    {
        public List<SFRRMBEN06> obtenerDatosMovimientoBienId(int Nro, string Bien_Codigo)
        {
            List<SFRRMBEN06> objSFRRMBEN06 = new List<SFRRMBEN06>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@NroMovimiento", Nro);
                    SqlParameter sqlParam1 = new SqlParameter("@Bien_Codigo", Bien_Codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN06SelProc", sqlParam, sqlParam1);

                    while (dr.Read())
                    {
                        objSFRRMBEN06.Add(llenarObjeto(dr));
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

            return objSFRRMBEN06;
        }

        public String insertarRegistroMovimiento_Bien(SFRRMBEN06 objSFRRMBEN06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[20];

                    sqlParams[0] = new SqlParameter("@Nro", objSFRRMBEN06.Nro);
                    sqlParams[1] = new SqlParameter("@Bien_Codigo", objSFRRMBEN06.Bien_Codigo);
                    sqlParams[2] = new SqlParameter("@NroMovimiento", objSFRRMBEN06.NroMovimiento);
                    sqlParams[3] = new SqlParameter("@Ingreso", objSFRRMBEN06.Ingreso);
                    sqlParams[4] = new SqlParameter("@Solicita", objSFRRMBEN06.Solicita);
                    sqlParams[5] = new SqlParameter("@Despacho", objSFRRMBEN06.Despacho);
                    sqlParams[6] = new SqlParameter("@Precio", objSFRRMBEN06.Precio);
                    sqlParams[7] = new SqlParameter("@PrecioUS", objSFRRMBEN06.PrecioUS);
                    sqlParams[8] = new SqlParameter("@PrecioUD", objSFRRMBEN06.PrecioUD);
                    sqlParams[9] = new SqlParameter("@Moneda", objSFRRMBEN06.Moneda);
                    sqlParams[10] = new SqlParameter("@TipoCambio", objSFRRMBEN06.TipoCambio);
                    sqlParams[11] = new SqlParameter("@Observacion", objSFRRMBEN06.Observacion);
                    sqlParams[12] = new SqlParameter("@NumeroOC", objSFRRMBEN06.NumeroOC);
                    sqlParams[13] = new SqlParameter("@Ped_Codigo", objSFRRMBEN06.Ped_Codigo);
                    sqlParams[14] = new SqlParameter("@Estado", objSFRRMBEN06.Estado);
                    sqlParams[15] = new SqlParameter("@Usu_Crea", objSFRRMBEN06.Usu_Crea);
                    sqlParams[16] = new SqlParameter("@Fec_Crea", objSFRRMBEN06.Fec_Crea);
                    sqlParams[17] = new SqlParameter("@Usu_Upd", objSFRRMBEN06.Usu_Upd);
                    sqlParams[18] = new SqlParameter("@Fec_Upd", objSFRRMBEN06.Fec_Upd);
                    sqlParams[19] = new SqlParameter("@Bie_Codigo", objSFRRMBEN06.Bie_Codigo); 

                   String Codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN06InsProc", sqlParams).ToString();
                   return Codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroMovimiento_Bien(SFRRMBEN06 objSFRRMBEN06)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[20];

                    sqlParams[0] = new SqlParameter("@Nro", objSFRRMBEN06.Nro);
                    sqlParams[1] = new SqlParameter("@Bien_Codigo", objSFRRMBEN06.Bien_Codigo);
                    sqlParams[2] = new SqlParameter("@NroMovimiento", objSFRRMBEN06.NroMovimiento);
                    sqlParams[3] = new SqlParameter("@Ingreso", objSFRRMBEN06.Ingreso);
                    sqlParams[4] = new SqlParameter("@Solicita", objSFRRMBEN06.Solicita);
                    sqlParams[5] = new SqlParameter("@Despacho", objSFRRMBEN06.Despacho);
                    sqlParams[6] = new SqlParameter("@Precio", objSFRRMBEN06.Precio);
                    sqlParams[7] = new SqlParameter("@PrecioUS", objSFRRMBEN06.PrecioUS);
                    sqlParams[8] = new SqlParameter("@PrecioUD", objSFRRMBEN06.PrecioUD);
                    sqlParams[9] = new SqlParameter("@Moneda", objSFRRMBEN06.Moneda);
                    sqlParams[10] = new SqlParameter("@TipoCambio", objSFRRMBEN06.TipoCambio);
                    sqlParams[11] = new SqlParameter("@Observacion", objSFRRMBEN06.Observacion);
                    sqlParams[12] = new SqlParameter("@NumeroOC", objSFRRMBEN06.NumeroOC);
                    sqlParams[13] = new SqlParameter("@Ped_Codigo", objSFRRMBEN06.Ped_Codigo);
                    sqlParams[14] = new SqlParameter("@Estado", objSFRRMBEN06.Estado);
                    sqlParams[15] = new SqlParameter("@Usu_Crea", objSFRRMBEN06.Usu_Crea);
                    sqlParams[16] = new SqlParameter("@Fec_Crea", objSFRRMBEN06.Fec_Crea);
                    sqlParams[17] = new SqlParameter("@Usu_Upd", objSFRRMBEN06.Usu_Upd);
                    sqlParams[18] = new SqlParameter("@Fec_Upd", objSFRRMBEN06.Fec_Upd);
                    sqlParams[19] = new SqlParameter("@Bie_Codigo", objSFRRMBEN06.Bie_Codigo); 
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN06UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroMovimiento_Bien(int Nro, string Bien_Codigo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@NroMovimiento", Nro);
                    SqlParameter sqlParam1 = new SqlParameter("@Bien_Codigo", Bien_Codigo);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN06DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN06 llenarObjeto(SqlDataReader dr)
        {
            SFRRMBEN06 objSFRRMBEN06 = new SFRRMBEN06();
            objSFRRMBEN06.Nro = Convert.ToInt32(dr["Nro"]);
            objSFRRMBEN06.Bien_Codigo = Convert.ToString(dr["Bien_Codigo"]);
            objSFRRMBEN06.NroMovimiento = Convert.ToString(dr["NroMovimiento"]);
            objSFRRMBEN06.Ingreso = Convert.ToInt32(dr["Ingreso"]);
            objSFRRMBEN06.Solicita = Convert.ToInt32(dr["Solicita"]);
            objSFRRMBEN06.Despacho = Convert.ToInt32(dr["Despacho"]);
            objSFRRMBEN06.Precio = Convert.ToDecimal(dr["Precio"]);
            objSFRRMBEN06.PrecioUS = Convert.ToDecimal(dr["PrecioUS"]);
            objSFRRMBEN06.PrecioUD = Convert.ToDecimal(dr["PrecioUD"]);
            objSFRRMBEN06.Moneda = Convert.ToString(dr["Moneda"]);
            objSFRRMBEN06.TipoCambio = Convert.ToInt32(dr["TipoCambio"]);
            objSFRRMBEN06.Observacion = Convert.ToString(dr["Observacion"]);
            objSFRRMBEN06.NumeroOC = Convert.ToString(dr["NumeroOC"]);
            objSFRRMBEN06.Ped_Codigo = Convert.ToString(dr["Ped_Codigo"]);
            objSFRRMBEN06.Estado = Convert.ToString(dr["Estado"]);
            objSFRRMBEN06.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN06.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN06.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN06.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);
            objSFRRMBEN06.Bie_Codigo = Convert.ToString(dr["Bie_Codigo"]);   

            return objSFRRMBEN06;
        }


    }
}
