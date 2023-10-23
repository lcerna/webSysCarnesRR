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
    public class SFRRMCOM03DA
    {
        public List<SFRRMCOM03_List> ListarRegistros(string codigo)
        {
            List<SFRRMCOM03_List> objSFRRMBEN21 = new List<SFRRMCOM03_List>();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@NumeroOC", codigo);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN14SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN21.Add(llenarObjeto2(dr));
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

            return objSFRRMBEN21;
        }

        public SFRRMCOM03 obtenerDatosId(string GuiaRD_Codi)
        {
            SFRRMCOM03 objSFRRMBEN11 = new SFRRMCOM03();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter sqlParam = new SqlParameter("@NumeroOC", GuiaRD_Codi);
                    dr = SqlHelper.ExecuteReader(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN14SelProc", sqlParam);

                    while (dr.Read())
                    {
                        objSFRRMBEN11 = llenarObjeto(dr);
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

            return objSFRRMBEN11;
        }

        public String insertarRegistro(SFRRMCOM03 objSFRRMBEN14)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[15];

                    sqlParams[0] = new SqlParameter("@NumeroOC", objSFRRMBEN14.NotCom_Id);
                    sqlParams[1] = new SqlParameter("@FechaOC ", objSFRRMBEN14.Not_Com_Fecha);
                    sqlParams[2] = new SqlParameter("@Semana  ", objSFRRMBEN14.semana);
                    sqlParams[3] = new SqlParameter("@Proveedor", objSFRRMBEN14.Ped_Codigo);
                    sqlParams[4] = new SqlParameter("@Requerido", objSFRRMBEN14.Requerido);
                    sqlParams[5] = new SqlParameter("@CDestino", objSFRRMBEN14.CDestino);
                    sqlParams[6] = new SqlParameter("@TCambio ", objSFRRMBEN14.Tcambio);
                    sqlParams[7] = new SqlParameter("@VIGV", objSFRRMBEN14.Incluye_Igv);
                    sqlParams[8] = new SqlParameter("@IncluyeIGV", objSFRRMBEN14.Incluye_Igv);
                    sqlParams[9] = new SqlParameter("@Moneda", objSFRRMBEN14.Moneda);
                    sqlParams[10] = new SqlParameter("@SubTotal", objSFRRMBEN14.SubTotal);
                    sqlParams[11] = new SqlParameter("@IGV ", objSFRRMBEN14.Igv);
                    sqlParams[12] = new SqlParameter("@Monto ", objSFRRMBEN14.Monto);
                    sqlParams[13] = new SqlParameter("@Descripcion", "");
                    sqlParams[14] = new SqlParameter("@Observaciones", objSFRRMBEN14.Observacion);

                    String Codigo = SqlHelper.ExecuteScalar(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN14InsProc", sqlParams).ToString();

                    return Codigo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarRegistro(SFRRMCOM03 objSFRRMBEN14)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[15];

                    sqlParams[0] = new SqlParameter("@NumeroOC", objSFRRMBEN14.NotCom_Id);
                    sqlParams[1] = new SqlParameter("@FechaOC ", objSFRRMBEN14.Not_Com_Fecha);
                    sqlParams[2] = new SqlParameter("@Semana  ", objSFRRMBEN14.semana);
                    sqlParams[3] = new SqlParameter("@Proveedor", objSFRRMBEN14.Ped_Codigo);
                    sqlParams[4] = new SqlParameter("@Requerido", objSFRRMBEN14.Requerido);
                    sqlParams[5] = new SqlParameter("@CDestino", objSFRRMBEN14.CDestino);
                    sqlParams[6] = new SqlParameter("@TCambio ", objSFRRMBEN14.Tcambio);
                    sqlParams[7] = new SqlParameter("@VIGV", objSFRRMBEN14.Incluye_Igv);
                    sqlParams[8] = new SqlParameter("@IncluyeIGV", objSFRRMBEN14.Incluye_Igv);
                    sqlParams[9] = new SqlParameter("@Moneda", objSFRRMBEN14.Moneda);
                    sqlParams[10] = new SqlParameter("@SubTotal", objSFRRMBEN14.SubTotal);
                    sqlParams[11] = new SqlParameter("@IGV ", objSFRRMBEN14.Igv);
                    sqlParams[12] = new SqlParameter("@Monto ", objSFRRMBEN14.Monto);
                    sqlParams[13] = new SqlParameter("@Descripcion", "");
                    sqlParams[14] = new SqlParameter("@Observaciones", objSFRRMBEN14.Observacion);
                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN14UpdProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarRegistro(string GuiaRD_Codi)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Configuracion.conexion))
                {
                    SqlParameter[] sqlParams = new SqlParameter[1];

                    SqlParameter sqlParam = new SqlParameter("@NumeroOC", GuiaRD_Codi);

                    SqlHelper.ExecuteNonQuery(cn, System.Data.CommandType.StoredProcedure,
                        "SFRRMBEN14DelProc", sqlParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SFRRMCOM03 llenarObjeto(SqlDataReader dr)
        {
            SFRRMCOM03 objSFRRMBEN14 = new SFRRMCOM03();

            objSFRRMBEN14.NotCom_Id = Convert.ToString(dr["NumeroOC"]);
            objSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(dr["FechaOC"]);
            objSFRRMBEN14.Ped_Codigo = Convert.ToString(dr["Proveedor"]);
            objSFRRMBEN14.CDestino = Convert.ToString(dr["CDestino"]);
            objSFRRMBEN14.Moneda = Convert.ToInt32(dr["Moneda"]);
            objSFRRMBEN14.Observacion = Convert.ToString(dr["Observaciones"]);
            objSFRRMBEN14.Requerido = Convert.ToString(dr["Requerido"]);
            objSFRRMBEN14.Incluye_Igv = Convert.ToInt32(dr["IncluyeIGV"]);
            objSFRRMBEN14.Tcambio = Convert.ToDecimal(dr["TCambio"]);
            objSFRRMBEN14.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
            objSFRRMBEN14.Igv = Convert.ToDecimal(dr["IGV"]);
            objSFRRMBEN14.Monto = Convert.ToDecimal(dr["Monto"]);

            return objSFRRMBEN14;
        }

        private SFRRMCOM03_List llenarObjeto2(SqlDataReader dr)
        {
            SFRRMCOM03_List eSFRRMBEN14 = new SFRRMCOM03_List();
            eSFRRMBEN14.NotCom_Id = dr["NumeroOC"].ToString().Trim();
            eSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(dr["FechaOC"].ToString().Trim());
            eSFRRMBEN14.Monto = Convert.ToDecimal(dr["Monto"].ToString().Trim());

            return eSFRRMBEN14;
        }

    }
}
