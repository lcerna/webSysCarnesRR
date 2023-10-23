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
    public class SFRRMBEN10DA
    {
        public List<SFRRMBEN10> obtenerDatosId(string GuiaR_Numero)
        {
            List<SFRRMBEN10> objSFRRMBEN10 = new List<SFRRMBEN10>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@GuiaR_Numero", GuiaR_Numero);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN10SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN10.Add(llenarObjeto(dr));
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

            return objSFRRMBEN10;
        }

        public void insertarRegistro(SFRRMBEN10 objSFRRMBEN10)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[28];

                    sqlParams[0] = new SqlParameter("@GuiaR_Numero", objSFRRMBEN10.GuiaR_Numero);
                    sqlParams[1] = new SqlParameter("@GuiaR_Fecha", objSFRRMBEN10.GuiaR_Fecha);
                    sqlParams[2] = new SqlParameter("@Semana", objSFRRMBEN10.Semana);
                    sqlParams[3] = new SqlParameter("@CodMovimiento", objSFRRMBEN10.CodMovimiento);
                    sqlParams[4] = new SqlParameter("@Cli_Codigo", objSFRRMBEN10.Cli_Codigo);
                    sqlParams[5] = new SqlParameter("@Prov_Codigo", objSFRRMBEN10.Prov_Codigo);
                    sqlParams[6] = new SqlParameter("@Pllegada_Direcc", objSFRRMBEN10.Pllegada_Direcc);
                    sqlParams[7] = new SqlParameter("@Pllegada_Distrito", objSFRRMBEN10.Pllegada_Distrito);
                    sqlParams[8] = new SqlParameter("@PLLegada", objSFRRMBEN10.PLLegada);
                    sqlParams[9] = new SqlParameter("@GuiaR_Llegada", objSFRRMBEN10.GuiaR_Llegada);
                    sqlParams[10] = new SqlParameter("@GuiaR_RUC", objSFRRMBEN10.GuiaR_RUC);
                    sqlParams[11] = new SqlParameter("@GuiaR_Factura", objSFRRMBEN10.GuiaR_Factura);
                    sqlParams[12] = new SqlParameter("@CPartida", objSFRRMBEN10.CPartida);
                    sqlParams[13] = new SqlParameter("@GuiaR_Partida", objSFRRMBEN10.GuiaR_Partida);
                    sqlParams[14] = new SqlParameter("@GuiaR_FTraslado", objSFRRMBEN10.GuiaR_FTraslado);
                    sqlParams[15] = new SqlParameter("@Glosa", objSFRRMBEN10.Glosa);
                    sqlParams[16] = new SqlParameter("@GuiaR_Marca", objSFRRMBEN10.GuiaR_Marca);
                    sqlParams[17] = new SqlParameter("@GuiaR_Placa", objSFRRMBEN10.GuiaR_Placa);
                    sqlParams[18] = new SqlParameter("@GuiaR_CInscripcion", objSFRRMBEN10.GuiaR_CInscripcion);
                    sqlParams[19] = new SqlParameter("@GuiaR_LConducir", objSFRRMBEN10.GuiaR_LConducir);
                    sqlParams[20] = new SqlParameter("@GuiaR_Usuario", objSFRRMBEN10.GuiaR_Usuario);
                    sqlParams[21] = new SqlParameter("@GuiaR_Estado", objSFRRMBEN10.GuiaR_Estado);
                    sqlParams[22] = new SqlParameter("@GuiaR_UsuCierre", objSFRRMBEN10.GuiaR_UsuCierre);
                    sqlParams[23] = new SqlParameter("@GuiaR_FCierre", objSFRRMBEN10.GuiaR_FCierre);
                    sqlParams[24] = new SqlParameter("@Usu_Crea", objSFRRMBEN10.Usu_Crea);
                    sqlParams[25] = new SqlParameter("@Fec_Crea", objSFRRMBEN10.Fec_Crea);
                    sqlParams[26] = new SqlParameter("@Usu_Upd", objSFRRMBEN10.Usu_Upd);
                    sqlParams[27] = new SqlParameter("@Fec_Upd", objSFRRMBEN10.Fec_Upd);   

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN10InsProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMBEN10 objSFRRMBEN10)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[28];

                    sqlParams[0] = new SqlParameter("@GuiaR_Numero", objSFRRMBEN10.GuiaR_Numero);
                    sqlParams[1] = new SqlParameter("@GuiaR_Fecha", objSFRRMBEN10.GuiaR_Fecha);
                    sqlParams[2] = new SqlParameter("@Semana", objSFRRMBEN10.Semana);
                    sqlParams[3] = new SqlParameter("@CodMovimiento", objSFRRMBEN10.CodMovimiento);
                    sqlParams[4] = new SqlParameter("@Cli_Codigo", objSFRRMBEN10.Cli_Codigo);
                    sqlParams[5] = new SqlParameter("@Prov_Codigo", objSFRRMBEN10.Prov_Codigo);
                    sqlParams[6] = new SqlParameter("@Pllegada_Direcc", objSFRRMBEN10.Pllegada_Direcc);
                    sqlParams[7] = new SqlParameter("@Pllegada_Distrito", objSFRRMBEN10.Pllegada_Distrito);
                    sqlParams[8] = new SqlParameter("@PLLegada", objSFRRMBEN10.PLLegada);
                    sqlParams[9] = new SqlParameter("@GuiaR_Llegada", objSFRRMBEN10.GuiaR_Llegada);
                    sqlParams[10] = new SqlParameter("@GuiaR_RUC", objSFRRMBEN10.GuiaR_RUC);
                    sqlParams[11] = new SqlParameter("@GuiaR_Factura", objSFRRMBEN10.GuiaR_Factura);
                    sqlParams[12] = new SqlParameter("@CPartida", objSFRRMBEN10.CPartida);
                    sqlParams[13] = new SqlParameter("@GuiaR_Partida", objSFRRMBEN10.GuiaR_Partida);
                    sqlParams[14] = new SqlParameter("@GuiaR_FTraslado", objSFRRMBEN10.GuiaR_FTraslado);
                    sqlParams[15] = new SqlParameter("@Glosa", objSFRRMBEN10.Glosa);
                    sqlParams[16] = new SqlParameter("@GuiaR_Marca", objSFRRMBEN10.GuiaR_Marca);
                    sqlParams[17] = new SqlParameter("@GuiaR_Placa", objSFRRMBEN10.GuiaR_Placa);
                    sqlParams[18] = new SqlParameter("@GuiaR_CInscripcion", objSFRRMBEN10.GuiaR_CInscripcion);
                    sqlParams[19] = new SqlParameter("@GuiaR_LConducir", objSFRRMBEN10.GuiaR_LConducir);
                    sqlParams[20] = new SqlParameter("@GuiaR_Usuario", objSFRRMBEN10.GuiaR_Usuario);
                    sqlParams[21] = new SqlParameter("@GuiaR_Estado", objSFRRMBEN10.GuiaR_Estado);
                    sqlParams[22] = new SqlParameter("@GuiaR_UsuCierre", objSFRRMBEN10.GuiaR_UsuCierre);
                    sqlParams[23] = new SqlParameter("@GuiaR_FCierre", objSFRRMBEN10.GuiaR_FCierre);
                    sqlParams[24] = new SqlParameter("@Usu_Crea", objSFRRMBEN10.Usu_Crea);
                    sqlParams[25] = new SqlParameter("@Fec_Crea", objSFRRMBEN10.Fec_Crea);
                    sqlParams[26] = new SqlParameter("@Usu_Upd", objSFRRMBEN10.Usu_Upd);
                    sqlParams[27] = new SqlParameter("@Fec_Upd", objSFRRMBEN10.Fec_Upd);   
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN10UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string GuiaR_Numero)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@GuiaR_Numero", GuiaR_Numero);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN10DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMBEN10 llenarObjeto(SqlDataReader dr)
        {
            SFRRMBEN10 objSFRRMBEN10 = new SFRRMBEN10();
            objSFRRMBEN10.GuiaR_Numero = Convert.ToString(dr["GuiaR_Numero"]);
            objSFRRMBEN10.GuiaR_Fecha = Convert.ToDateTime(dr["GuiaR_Fecha"]);
            objSFRRMBEN10.Semana = Convert.ToInt32(dr["Semana"]);
            objSFRRMBEN10.CodMovimiento = Convert.ToString(dr["CodMovimiento"]);
            objSFRRMBEN10.Cli_Codigo = Convert.ToString(dr["Cli_Codigo"]);
            objSFRRMBEN10.Prov_Codigo = Convert.ToString(dr["Prov_Codigo"]);
            objSFRRMBEN10.Pllegada_Direcc = Convert.ToString(dr["Pllegada_Direcc"]);
            objSFRRMBEN10.Pllegada_Distrito = Convert.ToString(dr["Pllegada_Distrito"]);
            objSFRRMBEN10.PLLegada = Convert.ToInt32(dr["PLLegada"]);
            objSFRRMBEN10.GuiaR_Llegada = Convert.ToString(dr["GuiaR_Llegada"]);
            objSFRRMBEN10.GuiaR_RUC = Convert.ToString(dr["GuiaR_RUC"]);
            objSFRRMBEN10.GuiaR_Factura = Convert.ToString(dr["GuiaR_Factura"]);
            objSFRRMBEN10.CPartida = Convert.ToString(dr["CPartida"]);
            objSFRRMBEN10.GuiaR_Partida = Convert.ToString(dr["GuiaR_Partida"]);
            objSFRRMBEN10.GuiaR_FTraslado = Convert.ToDateTime(dr["GuiaR_FTraslado"]);
            objSFRRMBEN10.Glosa = Convert.ToString(dr["Glosa"]);
            objSFRRMBEN10.GuiaR_Marca = Convert.ToString(dr["GuiaR_Marca"]);
            objSFRRMBEN10.GuiaR_Placa = Convert.ToString(dr["GuiaR_Placa"]);
            objSFRRMBEN10.GuiaR_CInscripcion = Convert.ToString(dr["GuiaR_CInscripcion"]);
            objSFRRMBEN10.GuiaR_LConducir = Convert.ToString(dr["GuiaR_LConducir"]);
            objSFRRMBEN10.GuiaR_Usuario = Convert.ToString(dr["GuiaR_Usuario"]);
            objSFRRMBEN10.GuiaR_Estado = Convert.ToString(dr["GuiaR_Estado"]);
            objSFRRMBEN10.GuiaR_UsuCierre = Convert.ToString(dr["GuiaR_UsuCierre"]);
            objSFRRMBEN10.GuiaR_FCierre = Convert.ToDateTime(dr["GuiaR_FCierre"]);
            objSFRRMBEN10.Usu_Crea = Convert.ToString(dr["Usu_Crea"]);
            objSFRRMBEN10.Fec_Crea = Convert.ToDateTime(dr["Fec_Crea"]);
            objSFRRMBEN10.Usu_Upd = Convert.ToString(dr["Usu_Upd"]);
            objSFRRMBEN10.Fec_Upd = Convert.ToDateTime(dr["Fec_Upd"]);

            return objSFRRMBEN10;
        }
    }
}
