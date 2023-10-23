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
    public class SFRRMBEN05DA
    {
        public List<SFRRMBEN05> obtenerDatosMovimientoId(string NroMovimiento)
        {
            List<SFRRMBEN05> objSFRRMBEN05 = new List<SFRRMBEN05>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@NroMovimiento", NroMovimiento);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN05SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN05.Add(llenarObjetoTipoAlmacen(dr));
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

            return objSFRRMBEN05;
        }
        
        public String insertarRegistroMovimiento(SFRRMBEN05 objSFRRMBEN05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[25];

                    sqlParams[0] = new SqlParameter("@NroMovimiento", objSFRRMBEN05.CodAlmacen);
                    sqlParams[1] = new SqlParameter("@CodAlmacen", objSFRRMBEN05.CodAlmacen);
                    sqlParams[2] = new SqlParameter("@Fecha", objSFRRMBEN05.Fecha);
                    sqlParams[3] = new SqlParameter("@Semana", objSFRRMBEN05.Semana);
                    sqlParams[4] = new SqlParameter("@Prov_Codigo", objSFRRMBEN05.Prov_Codigo);
                    sqlParams[5] = new SqlParameter("@Estado", objSFRRMBEN05.Estado);
                    sqlParams[6] = new SqlParameter("@TipOper", objSFRRMBEN05.TipOper);
                    sqlParams[7] = new SqlParameter("@CodMovimiento", objSFRRMBEN05.CodMovimiento);
                    sqlParams[8] = new SqlParameter("@CDocumento", objSFRRMBEN05.CDocumento);
                    sqlParams[9] = new SqlParameter("@NroDocumento", objSFRRMBEN05.NroDocumento);
                    sqlParams[10] = new SqlParameter("@FecDocumento", objSFRRMBEN05.FecDocumento);
                    sqlParams[11] = new SqlParameter("@Destino", objSFRRMBEN05.Destino);
                    sqlParams[12] = new SqlParameter("@IncluyeIGV", objSFRRMBEN05.IncluyeIGV);
                    sqlParams[13] = new SqlParameter("@Total", objSFRRMBEN05.Total);
                    sqlParams[14] = new SqlParameter("@Moneda", objSFRRMBEN05.Moneda);
                    sqlParams[15] = new SqlParameter("@TipoCambio", objSFRRMBEN05.TipoCambio);
                    sqlParams[16] = new SqlParameter("@Observacion", objSFRRMBEN05.Observacion);
                    sqlParams[17] = new SqlParameter("@UsuarioFEC", objSFRRMBEN05.Fecha);
                    sqlParams[18] = new SqlParameter("@Anu_Motivo", objSFRRMBEN05.Anu_Motivo);
                    sqlParams[19] = new SqlParameter("@Anu_Usuario", objSFRRMBEN05.Anu_Usuario);
                    sqlParams[20] = new SqlParameter("@Anu_Fecha", objSFRRMBEN05.Fecha);
                    sqlParams[21] = new SqlParameter("@Usu_Crea", objSFRRMBEN05.Usu_Crea);
                    sqlParams[22] = new SqlParameter("@Fec_Crea", objSFRRMBEN05.Fecha);
                    sqlParams[23] = new SqlParameter("@Usu_Upd", objSFRRMBEN05.Usu_Upd);
                    sqlParams[24] = new SqlParameter("@Fec_Upd", objSFRRMBEN05.Fecha);

      
                   String Codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN05InsProc", sqlParams).ToString();
                   return Codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistroMovimiento(SFRRMBEN05 objSFRRMBEN05)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[24];

                    sqlParams[0] = new SqlParameter("@CodAlmacen", objSFRRMBEN05.CodAlmacen);
                    sqlParams[1] = new SqlParameter("@Fecha", objSFRRMBEN05.Fecha);
                    sqlParams[2] = new SqlParameter("@Semana", objSFRRMBEN05.Semana);
                    sqlParams[3] = new SqlParameter("@Prov_Codigo", objSFRRMBEN05.Prov_Codigo);
                    sqlParams[4] = new SqlParameter("@Estado", objSFRRMBEN05.Estado);
                    sqlParams[5] = new SqlParameter("@TipOper", objSFRRMBEN05.TipOper);
                    sqlParams[6] = new SqlParameter("@CodMovimiento", objSFRRMBEN05.CodMovimiento);
                    sqlParams[7] = new SqlParameter("@CDocumento", objSFRRMBEN05.CDocumento);
                    sqlParams[8] = new SqlParameter("@NroDocumento", objSFRRMBEN05.NroDocumento);
                    sqlParams[9] = new SqlParameter("@FecDocumento", objSFRRMBEN05.FecDocumento);
                    sqlParams[10] = new SqlParameter("@Destino", objSFRRMBEN05.Destino);
                    sqlParams[11] = new SqlParameter("@IncluyeIGV", objSFRRMBEN05.IncluyeIGV);
                    sqlParams[12] = new SqlParameter("@Total", objSFRRMBEN05.Total);
                    sqlParams[13] = new SqlParameter("@Moneda", objSFRRMBEN05.Moneda);
                    sqlParams[14] = new SqlParameter("@TipoCambio", objSFRRMBEN05.TipoCambio);
                    sqlParams[15] = new SqlParameter("@Observacion", objSFRRMBEN05.Observacion);
                    sqlParams[16] = new SqlParameter("@UsuarioFEC", objSFRRMBEN05.UsuarioFEC);
                    sqlParams[17] = new SqlParameter("@Anu_Motivo", objSFRRMBEN05.Anu_Motivo);
                    sqlParams[18] = new SqlParameter("@Anu_Usuario", objSFRRMBEN05.Anu_Usuario);
                    sqlParams[19] = new SqlParameter("@Anu_Fecha", objSFRRMBEN05.Fecha);
                    sqlParams[20] = new SqlParameter("@Usu_Crea", objSFRRMBEN05.Usu_Crea);
                    sqlParams[21] = new SqlParameter("@Fec_Crea", objSFRRMBEN05.Fecha);
                    sqlParams[22] = new SqlParameter("@Usu_Upd", objSFRRMBEN05.Usu_Upd);
                    sqlParams[23] = new SqlParameter("@Fec_Upd", objSFRRMBEN05.Fecha);  
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN05UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistroMovimiento(string NroMovimiento)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@NroMovimiento", NroMovimiento);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN05DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN05 llenarObjetoTipoAlmacen(SqlDataReader dr)
        {
            SFRRMBEN05 objSFRRMBEN05 = new SFRRMBEN05();
            objSFRRMBEN05.NroMovimiento = Convert.ToString(dr["NroMovimiento"]);
            objSFRRMBEN05.CodAlmacen = Convert.ToString(dr["CodAlmacen"]);
            objSFRRMBEN05.Fecha = Convert.ToDateTime(dr["Fecha"]);
            objSFRRMBEN05.Semana = Convert.ToInt32(dr["Semana"]);
            objSFRRMBEN05.Prov_Codigo = Convert.ToString(dr["Prov_Codigo"]);
            objSFRRMBEN05.Estado = Convert.ToString(dr["Estado"]);
            objSFRRMBEN05.TipOper = Convert.ToString(dr["TipOper"]);
            objSFRRMBEN05.CodMovimiento = Convert.ToString(dr["CodMovimiento"]);
            objSFRRMBEN05.CDocumento = Convert.ToString(dr["CDocumento"]);
            objSFRRMBEN05.NroDocumento = Convert.ToString(dr["NroDocumento"]);
            objSFRRMBEN05.FecDocumento = Convert.ToDateTime(dr["FecDocumento"]);
            objSFRRMBEN05.Destino = Convert.ToString(dr["Destino"]);
            objSFRRMBEN05.IncluyeIGV = Convert.ToString(dr["IncluyeIGV"]);
            objSFRRMBEN05.Total = Convert.ToInt32(dr["Total"]);
            objSFRRMBEN05.Moneda = Convert.ToString(dr["Moneda"]);
            objSFRRMBEN05.TipoCambio = Convert.ToInt32(dr["TipoCambio"]);
            objSFRRMBEN05.Observacion = Convert.ToString(dr["Observacion"]);
            objSFRRMBEN05.UsuarioFEC = Convert.ToDateTime(dr["UsuarioFEC"]);
            objSFRRMBEN05.Anu_Motivo = Convert.ToString(dr["Anu_Motivo"]);
            objSFRRMBEN05.Anu_Usuario = Convert.ToString(dr["Anu_Usuario"]);
            objSFRRMBEN05.Anu_Fecha = Convert.ToDateTime(dr["Anu_Fecha"]);
            objSFRRMBEN05.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN05.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN05.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN05.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);

            return objSFRRMBEN05;
        }
    }
}
