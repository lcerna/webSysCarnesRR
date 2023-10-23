using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessObjects.SFRRMADM;
using RCRR.BL.BusinessEntities.SFRRMADM;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Globalization;
using System.Reflection;

public partial class pages_Beneficio_frmNC_Nuevo : System.Web.UI.Page
{
    #region "Variables"

    //aLMACEN
    SFRRMBEN01 eSFRRMBEN01 = new SFRRMBEN01();
    SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();
    //
    SFRRMADM05 eSFRRMADM05 = new SFRRMADM05();
    SFRRMADM05BL lSFRRMADM05 = new SFRRMADM05BL();
    //Nota Compra Cabecera
    //SFRRMBEN14 eSFRRMBEN14 = new SFRRMBEN14();
    //SFRRMBEN14BL lSFRRMBEN14 = new SFRRMBEN14BL();
    ////Nota de Compra Detalle
    //SFRRMBEN15 eSFRRMBEN15 = new SFRRMBEN15();
    //SFRRMBEN15BL lSFRRMBEN15 = new SFRRMBEN15BL();
    ////Piezas
    //SFRRMBEN16 eSFRRMBEN16 = new SFRRMBEN16();
    //SFRRMBEN16BL lSFRRMBEN16 = new SFRRMBEN16BL();
    ////peoveedor
    //SFRRMBEN21 eSFRRMBEN21 = new SFRRMBEN21();
    //SFRRMBEN21_List eSFRRMBEN21_ = new SFRRMBEN21_List();
    //SFRRMBEN21BL lSFRRMBEN21 = new SFRRMBEN21BL();
    //Movimiento Cabecera
    SFRRMBEN05 eSFRRMBEN05 = new SFRRMBEN05();
    SFRRMBEN05BL lSFRRMBEN05 = new SFRRMBEN05BL();
    //Movimeinto Detalle
    SFRRMBEN06 eSFRRMBEN06 = new SFRRMBEN06();
    SFRRMBEN06BL lSFRRMBEN06BL = new SFRRMBEN06BL();
    SFRRMADM06 eSFRRMADM06 = new SFRRMADM06();
    SFRRMADM06BL lSFRRMADM06 = new SFRRMADM06BL();

    #endregion

    #region "Eventos"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtFecha.Text = DateTime.Today.ToString("yyyy-MM-dd");
            txtEstado.Text = "";
            txtNombrePro.Text = "";
            txtGlosa.Text = "";
            txtFecCie.Text = DateTime.Today.ToString("yyyy-MM-dd");
            ViewState["Accion"] = string.Empty;
            ViewState["CodProv"] = string.Empty;
            ViewState["CodBie"] = string.Empty;
            txtSubTotal.Enabled = false;
            txtIgv.Enabled = false;
            txtTotal.Enabled = false;
            btnAgregaProv.Disabled = true;
            btnBuscaProvee.Disabled = true;
            chkIgv.Enabled = false;
            dbrAlmacen.Enabled = false;
            btnCancelarNC.Enabled = false;
            btnCerrarNC.Enabled = false;
            CargarCombos();
        }
        CargarGrilla();
    }

    protected void drvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(drvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void drvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["CodProv"] = this.drvProveedor.SelectedRow.Cells[0].Text;
        txtNombrePro.Text = this.drvProveedor.SelectedRow.Cells[0].Text + " - " + this.drvProveedor.SelectedRow.Cells[1].Text;
    }

    protected void btnNuevoNC_Click(object sender, EventArgs e)
    {
        CargarCombos();
        txtFecha.Text = DateTime.Today.ToString("yyyy-MM-dd");
        txtFecha.Enabled = true;
        txtFecCie.Text = DateTime.Today.ToString("yyyy-MM-dd");
        txtFecCie.Enabled = true;
        txtNombrePro.Enabled = false;
        btnBuscaProvee.Disabled = false;
        btnBuscar.Disabled = true;
        dbrMoneda.Enabled = true;
        txtTipoC.Enabled = false;
        txtFecCie.Enabled = true;
        txtGlosa.Enabled = true;
        chkIgv.Enabled = true;
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        btnNuevoNC.Enabled = false;
        btnCancelarNC.Enabled = true;
        btnGuardarNC.Enabled = true;
        dbrAlmacen.Enabled = true;
    }

    protected void btnGuardarNC_Click(object sender, EventArgs e)
    {        
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            DateTime v2 = new DateTime(Convert.ToInt32(DateTime.Now.Year.ToString()), Convert.ToInt32(DateTime.Now.Month.ToString()), Convert.ToInt32(DateTime.Now.Day.ToString()));
            int semana = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek);

            //eSFRRMBEN14.NotCom_Id = txtCodigo.Text;
            //eSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(txtFecha.Text);
            //eSFRRMBEN14.Ped_Codigo = txtNombrePro.Text.Split('-')[0].ToString().Trim();
            //eSFRRMBEN14.Requerido = "";
            //eSFRRMBEN14.CDestino = dbrAlmacen.SelectedValue;
            //eSFRRMBEN14.Tcambio = Convert.ToDecimal(txtTipoC.Text);
            //if (chkIgv.Checked == true)
            //{
            //    eSFRRMBEN14.Incluye_Igv = 1;
            //}
            //else
            //{
            //    eSFRRMBEN14.Incluye_Igv = 0;
            //}
            //eSFRRMBEN14.Moneda = Convert.ToInt32(dbrMoneda.SelectedValue);
            //eSFRRMBEN14.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            //eSFRRMBEN14.Igv = Convert.ToDecimal(txtIgv.Text);
            //eSFRRMBEN14.Monto = Convert.ToDecimal(txtTotal.Text);
            //eSFRRMBEN14.Observacion = txtGlosa.Text;
            //eSFRRMBEN14.semana = Convert.ToString(semana);

            //txtCodigo.Text = lSFRRMBEN14.insertarRegistro(eSFRRMBEN14);
            btnEliminarNC.Enabled = true;
        }
        else
        {
            DateTime v2 = new DateTime(Convert.ToInt32(DateTime.Now.Year.ToString()), Convert.ToInt32(DateTime.Now.Month.ToString()), Convert.ToInt32(DateTime.Now.Day.ToString()));
            int semana = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek);

            //eSFRRMBEN14.NotCom_Id = txtCodigo.Text;
            //eSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(txtFecha.Text);
            //eSFRRMBEN14.Ped_Codigo = txtNombrePro.Text.Split('-')[0].ToString().Trim();
            //eSFRRMBEN14.Requerido = "";
            //eSFRRMBEN14.CDestino = dbrAlmacen.SelectedValue;
            //eSFRRMBEN14.Tcambio = Convert.ToDecimal(txtTipoC.Text);
            //if (chkIgv.Checked == true)
            //{
            //    eSFRRMBEN14.Incluye_Igv = 1;
            //}
            //else
            //{
            //    eSFRRMBEN14.Incluye_Igv = 0;
            //}
            //eSFRRMBEN14.Moneda = Convert.ToInt32(dbrMoneda.SelectedValue);
            //eSFRRMBEN14.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            //eSFRRMBEN14.Igv = Convert.ToDecimal(txtIgv.Text);
            //eSFRRMBEN14.Monto = Convert.ToDecimal(txtTotal.Text);
            //eSFRRMBEN14.Observacion = txtGlosa.Text;
            //eSFRRMBEN14.Tcambio = Convert.ToDecimal("3.261");
            //if (chkIgv.Checked == true)
            //{
            //    eSFRRMBEN14.Incluye_Igv = 1;
            //}
            //else
            //{
            //    eSFRRMBEN14.Incluye_Igv = 0;
            //}
            //eSFRRMBEN14.Moneda = Convert.ToInt32(dbrMoneda.SelectedValue);
            //eSFRRMBEN14.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            //eSFRRMBEN14.Igv = Convert.ToDecimal(txtIgv.Text);
            //eSFRRMBEN14.Monto = Convert.ToDecimal(txtTotal.Text);
            //eSFRRMBEN14.Observacion = txtGlosa.Text;
            //eSFRRMBEN14.semana = Convert.ToString(semana);
            //lSFRRMBEN14.actualizarRegistro(eSFRRMBEN14);
        }

        txtEstado.Text = "Registrado";
        btnGuardarNC.Text = "Actualizar";
        btnBuscaProvee.Disabled = true;
        btnAgregaProv.Disabled = false;
        btnPieza.Disabled = false;
        txtPrecio.Enabled = true;
        txtCantidad.Enabled = true;
        btnNuevoDet.Enabled = true;
        btnImportarDet.Enabled = true;
        FileDetalle.Enabled = true;
        Message();
        CargarGrilla();
        btnGuardarNC.Enabled = true;
        btnBuscaProvee.Disabled = false;
    }

    protected void dgvPieza_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvPieza, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvPieza_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtFamiliaPieza.Text = this.dgvPieza.SelectedRow.Cells[0].Text.ToString().Trim() + " - " + this.dgvPieza.SelectedRow.Cells[1].Text.ToString().Trim();
    }

    protected void btnEliminarNC_Click(object sender, EventArgs e)
    {
        //eSFRRMBEN14.NotCom_Id = txtCodigo.Text;
        //lSFRRMBEN14.eliminarRegistro(eSFRRMBEN14.NotCom_Id);
        txtFecha.Text = System.DateTime.Today.ToShortDateString();
        txtFecha.Enabled = true;
        txtEstado.Text = "Registrado";
        txtNombrePro.Enabled = false;
        btnBuscaProvee.Disabled = false;
        btnBuscar.Disabled = true;
        dbrMoneda.Enabled = true;
        txtTipoC.Enabled = false;
        txtFecCie.Enabled = true;
        txtGlosa.Enabled = true;
        chkIgv.Enabled = true;
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        txtFecCie.Text = System.DateTime.Today.ToShortDateString();
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        btnNuevoNC.Enabled = false;
        btnCancelarNC.Enabled = true;
        btnGuardarNC.Enabled = true;
        dbrAlmacen.Enabled = true;

    }

    protected void btnCancelarNC_Click(object sender, EventArgs e)
    {
        btnNuevoNC.Enabled = true;
        btnCancelarNC.Enabled = false;
        btnGuardarNC.Enabled = false;
        txtGlosa.Enabled = false;
        dbrMoneda.Enabled = false;
        txtFecCie.Enabled = false;
        txtFecha.Enabled = false;
        btnBuscaProvee.Disabled = true;
        btnBuscar.Disabled = false;
        btnEliminarNC.Enabled = false;
        txtNombrePro.Text = txtCodigo.Text = String.Empty;
        btnGuardarNC.Text = "Guardar";
        dbrAlmacen.SelectedValue = "0";
        dbrMoneda.SelectedValue = "0";
        btnGuardarDet.Enabled = false;
        btnNuevoDet.Enabled = false;
        FileDetalle.Enabled = false;
        btnImportarDet.Enabled = false;
    }

    protected void btnImportar_Click(object sender, EventArgs e)
    {
        //string sTemporal = "";
        //if (FileDetalle != null)
        //{
        //    if (!string.IsNullOrEmpty(FileDetalle.FileName))
        //    {
        //        sTemporal = string.Format("{0}{1}", Path.GetTempPath(), Path.GetFileName(FileDetalle.FileName));
        //        FileDetalle.SaveAs(sTemporal);
        //    }
        //}

        //if (File.Exists(sTemporal))
        //{
        //    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook book = null;
        //    Microsoft.Office.Interop.Excel.Worksheet sheet = null;
        //    Microsoft.Office.Interop.Excel.Range range = null;

        //    book = app.Workbooks.Open(sTemporal, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, true, 0, true, 1, 0);
        //    sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets[1];


        //    range = sheet.UsedRange;

        //    int rCnt = 0;
        //    int cCnt = 0;


        //    System.Data.DataTable dtDatos = new System.Data.DataTable();

        //    //Se crean las columnas
        //    for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
        //    {
        //        String sColumna = Convert.ToString((range.Cells[1, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2).Trim();//@02
        //        if (!string.IsNullOrEmpty(sColumna)) //@02
        //        {
        //            DataColumn dcColumna = new DataColumn(sColumna);
        //            dtDatos.Columns.Add(dcColumna);
        //        }
        //    }

        //    for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
        //    {
        //        DataRow drFila = dtDatos.NewRow();
        //        for (cCnt = 1; cCnt <= dtDatos.Columns.Count; cCnt++)
        //        {
        //            String str = "";
        //            if ((range.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2 != null)
        //                str = (string)(range.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
        //            drFila[cCnt - 1] = str;
        //        }
        //        dtDatos.Rows.Add(drFila);
        //    }

        //    range = null;
        //    sheet = null;
        //    if (book != null)
        //    {
        //        book.Close(false, Missing.Value, Missing.Value);

        //        book = null;
        //    }
        //    if (app != null)
        //    {
        //        app.Quit();
        //        app = null;
        //    }

        //    foreach (DataRow dr in dtDatos.Rows)
        //    {
        //        SFRRMBEN15 oEntidad = new SFRRMBEN15();
        //        SFRRMBEN15BL oMetodos = new SFRRMBEN15BL();
        //        oEntidad.NotCom_Id = txtCodigo.Text;
        //        oEntidad.Bie_Codigo = dr["Bie_Codigo"].ToString();
        //        oEntidad.CodId = dr["CodId"].ToString();
        //        oEntidad.Cantidad = dr["Cantidad"].ToString();
        //        oEntidad.Precio = dr["Precio"].ToString();
        //        oMetodos.insertarRegistro(oEntidad);
                
        //    }
            
        //    List<SFRRMBEN15> list = lSFRRMBEN15.obtenerRegistros(txtCodigo.Text);
        //    gdrDetalle.DataSource = list;
        //    gdrDetalle.DataBind();
        //}
    }

    protected void btnAgregarDet_Click(object sender, EventArgs e)
    {
        //SFRRMBEN15 oEntidad = new SFRRMBEN15();
        //SFRRMBEN15BL oMetodos = new SFRRMBEN15BL();
        //oEntidad.CodId = txtCodDetalle.Text;
        //oEntidad.NotCom_Id = txtCodigo.Text;
        //oEntidad.Bie_Codigo = txtFamiliaPieza.Text.Split('-')[0].ToString().Trim();
        //oEntidad.Ped_Codigo = "";
        //oEntidad.Cantidad = txtCantidad.Text;
        //oEntidad.Precio = txtPrecio.Text;
        //if (!String.IsNullOrEmpty(oEntidad.CodId))
        //    oMetodos.actualizarRegistro(oEntidad);
        //else
        //    oMetodos.insertarRegistro(oEntidad);
        //txtCodDetalle.Text = txtFamiliaPieza.Text = txtCantidad.Text = txtPrecio.Text = String.Empty;
        //List<SFRRMBEN15> oList = oMetodos.obtenerRegistros(txtCodigo.Text);
        //gdrDetalle.DataSource = oList;
        //gdrDetalle.DataBind();
    }

    protected void dgvNotCompra_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvNotCompra, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvNotCompra_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarCombos();

        //SFRRMBEN14 eSFRRMBEN14 = new SFRRMBEN14();
        //SFRRMBEN14BL leSFRRMBEN14 = new SFRRMBEN14BL();

        //eSFRRMBEN14 = leSFRRMBEN14.obtenerRegistros(this.dgvNotCompra.SelectedRow.Cells[0].Text.Trim());

        //if (eSFRRMBEN14 != null)
        //{
        //    btnNuevoNC.Enabled = false;
        //    btnCerrarNC.Enabled = true;
        //    txtEstado.Text = "Registrado";
        //    txtCodigo.Text = eSFRRMBEN14.NotCom_Id;
        //    txtFecha.Text = Convert.ToString(eSFRRMBEN14.Not_Com_Fecha);            
        //    dbrAlmacen.SelectedValue = eSFRRMBEN14.CDestino;
        //    dbrMoneda.SelectedValue = eSFRRMBEN14.Moneda.ToString();
        //    txtNombrePro.Text = eSFRRMBEN14.Ped_Codigo;
        //    txtTipoC.Text = Convert.ToString(eSFRRMBEN14.Tcambio);
        //    btnGuardarNC.Text = "Actualizar";
        //    btnGuardarNC.Enabled = true;
        //    btnEliminarNC.Enabled = true;
        //    btnCancelarNC.Enabled = true;
        //    btnBuscar.Disabled = true;
        //    btnBuscaProvee.Disabled = false;
        //    dbrAlmacen.Enabled = true;
        //    txtGlosa.Enabled = true;
        //    dbrMoneda.Enabled = true;
        //    btnNuevoDet.Enabled = true;
        //    SFRRMBEN15BL oMetodos = new SFRRMBEN15BL();
        //    List<SFRRMBEN15> oList = oMetodos.obtenerRegistros(txtCodigo.Text);
        //    gdrDetalle.DataSource = oList;
        //    gdrDetalle.DataBind();
        //}        
    }
    
    protected void gdrDetalle_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodDetalle.Text = this.gdrDetalle.SelectedRow.Cells[0].Text.Trim();
        txtFamiliaPieza.Text = this.gdrDetalle.SelectedRow.Cells[1].Text.Trim() + " - " + this.gdrDetalle.SelectedRow.Cells[2].Text.Trim();
        txtPrecio.Text = this.gdrDetalle.SelectedRow.Cells[3].Text.Trim();
        txtCantidad.Text = this.gdrDetalle.SelectedRow.Cells[4].Text.Trim();
        btnGuardarDet.Enabled = true;
    }

    protected void gdrDetalle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(gdrDetalle, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void btnNuevoDet_Click(object sender, EventArgs e)
    {
        txtCodDetalle.Text = String.Empty;
        txtFamiliaPieza.Text = String.Empty;
        txtPrecio.Text = String.Empty;
        txtCantidad.Text = String.Empty;
        btnGuardarDet.Enabled = true;
        FileDetalle.Enabled = true;
        btnImportarDet.Enabled = true;
        btnPieza.Disabled = false;
        txtCantidad.Enabled = true;
        txtPrecio.Enabled = true;
    }

    protected void btnCerrarNC_Click(object sender, EventArgs e)
    {        
        eSFRRMBEN05.NroMovimiento = "";
        eSFRRMBEN05.Fecha = Convert.ToDateTime(DateTime.Now.ToString());
        eSFRRMBEN05.Prov_Codigo = txtNombrePro.Text.Split('-')[0].ToString().Trim();
        eSFRRMBEN05.TipOper = "1";
        eSFRRMBEN05.Observacion = "Ingreso desde Nota de Compra" + txtCodigo.Text;
        eSFRRMBEN05.CDocumento = "NC-" + txtCodigo.Text;
        eSFRRMBEN05.NroDocumento = "NC-" + txtCodigo.Text;
        eSFRRMBEN05.Destino = dbrAlmacen.SelectedValue;
        eSFRRMBEN05.CodAlmacen = dbrAlmacen.SelectedValue;
        eSFRRMBEN05.Moneda = dbrMoneda.SelectedValue;
        if (chkIgv.Checked == true)
        {
            eSFRRMBEN05.IncluyeIGV = "1";
        }
        else
        {
            eSFRRMBEN05.IncluyeIGV = "0";
        }
        eSFRRMBEN05.FecDocumento = Convert.ToDateTime(txtFecha.Text); ;
        eSFRRMBEN05.Semana = Convert.ToDecimal(DateTime.Today.Day.ToString());
        eSFRRMBEN05.Total = Convert.ToDecimal(txtTotal.Text);
        string nroMov = lSFRRMBEN05.insertarRegistro(eSFRRMBEN05);

        for (int i = 0; i < gdrDetalle.Rows.Count; i++)
        {
            eSFRRMBEN06 = new SFRRMBEN06();
            eSFRRMBEN06.Nro = 0;
            eSFRRMBEN06.NroMovimiento = nroMov;
            eSFRRMBEN06.NumeroOC = txtCodigo.Text;
            eSFRRMBEN06.Bie_Codigo = gdrDetalle.DataKeys[i].Values["Bie_Codigo"].ToString();
            eSFRRMBEN06.Ingreso = 1; //Convert.ToInt32(gdrDetalle.DataKeys[i].Values["Cantidad"].ToString());
            eSFRRMBEN06.Precio = 1;//Convert.ToDecimal(gdrDetalle.DataKeys[i].Values["Precio"].ToString());

            lSFRRMBEN06BL.insertarRegistro(eSFRRMBEN06);

        }

        btnGuardarNC.Enabled = false;        
        Message();
    }

    #endregion "Eventos"

    #region "Metodos"
    private void CargarGrilla()
    {
        ////Cabecera de Nota de Compra
        //List<SFRRMBEN14_List> lNotCompra = new List<SFRRMBEN14_List>();
        //lNotCompra = lSFRRMBEN14.ListarRegistros(null);
        //dgvNotCompra.DataSource = lNotCompra;
        //dgvNotCompra.DataBind();

        ////Piezas
        //List<SFRRMBEN16_List> oList = lSFRRMBEN16.ListarRegistros(null);
        //dgvPieza.DataSource = oList;
        //dgvPieza.DataBind();
    }

    private void CargarCombos()
    {
        //Proveedor 
        //List<SFRRMBEN21_List> lpROVEE = lSFRRMBEN21.ListarRegistros(null);
        //drvProveedor.DataSource = lpROVEE;
        //drvProveedor.DataBind();

        //Almacenes
        List<SFRRMBEN01> ListAlma = new List<SFRRMBEN01>();
        ListAlma = lSFRRMBEN01.obtenerRegistros(null);
        ListAlma.Add(new SFRRMBEN01() { CodAlmacen = "0", DscAlmacen = "Seleccione" });
        dbrAlmacen.DataSource = ListAlma.OrderBy(t => int.Parse(t.CodAlmacen)).ToList();
        dbrAlmacen.DataBind();
    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion "Metodos"        

    protected void dbrAlmacen_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}