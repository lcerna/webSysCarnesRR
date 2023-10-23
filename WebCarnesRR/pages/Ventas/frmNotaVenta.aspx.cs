using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMVEN;
using RCRR.BL.BusinessEntities.SFRRMVEN;
using RCRR.BL.BusinessObjects.SFRRMADM;
using RCRR.BL.BusinessEntities.SFRRMADM;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class pages_Ventas_frmNotaVenta : System.Web.UI.Page
{

    //Movimiento Cabecera
    SFRRMVEN05 eSFRRMVEN05 = new SFRRMVEN05();
    SFRRMVEN05BL lSFRRMVEN05 = new SFRRMVEN05BL();

    //Movimeinto Detalle
    SFRRMVEN06 eSFRRMVEN06 = new SFRRMVEN06();
    SFRRMVEN06BL lSFRRMVEN06BL = new SFRRMVEN06BL();

    //CLIENTE
    SFRRMVEN03 eSFRRMVEN03 = new SFRRMVEN03();
    SFRRMVEN03BL lSFRRMVEN03 = new SFRRMVEN03BL();

    //MOVIMIENTO ALMACEN
    SFRRMBEN05 eSFRRMBEN05 = new SFRRMBEN05();
    SFRRMBEN05BL lSFRRMBEN05 = new SFRRMBEN05BL();


    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtFecha.Text = DateTime.Now.ToString("yyyy/mm/dd"); 
            txtEstado.Text = "";
            txtCliente.Text = "";
            txtTipCamb.Text = "";
            txtFecCie.Text = DateTime.Now.ToString("yyyy/mm/dd");
            ViewState["Accion"] = string.Empty;
            ViewState["CodCli"] = string.Empty;
            txtSubTotal.Enabled = false;
            txtIgv.Enabled = false;
            txtTotal.Enabled = false;
            chkIgv.Enabled = false;
            btnCancelarBan.Enabled = false;
            //List<SFRRMBEN16_List> oList = lSFRRMBEN16.ListarRegistros(null);
            //List<SFRRMBEN16_List> oList = new List<SFRRMBEN16_List>();
            //SFRRMBEN16_List eSFRRMBEN16_L = new SFRRMBEN16_List();
            //eSFRRMBEN16_L.Bie_Codigo = "0001";
            //eSFRRMBEN16_L.Bie_Nombre = "pieza1";
            //oList.Add(eSFRRMBEN16_L);
            //dgvPieza.DataSource = oList;
            //dgvPieza.DataBind();
            //List<SFRRMBEN21_List> lpROVEE = lSFRRMBEN21.ListarRegistros(null);
            //List<SFRRMBEN21_List> lpROVEE = new List<SFRRMBEN21_List>();
            //SFRRMBEN21_List SFRRMBEN21_List = new SFRRMBEN21_List();
            //eSFRRMBEN21_.Prov_Codigo = "0001";
            //eSFRRMBEN21_.Prov_Nombre = "real carnes rr";
            //eSFRRMBEN21_.Prov_NumDoc = "45594329544";
            //lpROVEE.Add(eSFRRMBEN21_);
            //drvProveedor.DataSource = lpROVEE;
            //drvProveedor.DataBind();
            //List<SFRRMBEN01> ListAlma = new List<SFRRMBEN01>();
            //ListAlma.Add(new SFRRMBEN01() { CodAlmacen = "0", DscAlmacen = "Seleccione" });
            //dbrAlmacen.DataSource = ListAlma;
            //dbrAlmacen.DataBind();
            //List<SFRRMADM06> lTipCam = new List<SFRRMADM06>();
            //SFRRMADM06 SFRRMADM06 = new SFRRMADM06();
            //SFRRMADM06.Id_Moneda = "0001";
            //eSFRRMBEN21_.Prov_Nombre = "real carnes rr";
            //eSFRRMBEN21_.Prov_NumDoc = "45594329544";
            //lpROVEE.Add(eSFRRMBEN21_);
            //drvProveedor.DataSource = lpROVEE;
            txtTipCamb.Text = "3.261";


        }
        CargarGrilla();

    }

    private void CargarGrilla()
    {
        List<SFRRMVEN05> lNoVenta = new List<SFRRMVEN05>();
        //lNotCompra = lSFRRMBEN14.obtenerRegistros(null);
        SFRRMVEN05 sSFRRMBEN05 = new SFRRMVEN05();
        sSFRRMBEN05.Fac_Codigo= "0001";
        sSFRRMBEN05.Cli_Codigo = "00001";
        sSFRRMBEN05.Fac_Fecha = Convert.ToDateTime("10/02/2017");
        sSFRRMBEN05.Fac_Subtotal = Convert.ToDecimal("300.26");
        sSFRRMBEN05.Fac_Igv = Convert.ToDecimal("30.26");
        sSFRRMBEN05.Fac_Total = Convert.ToDecimal("330.26");
        sSFRRMBEN05.Fac_Glosa = "pruebas1";
        lNoVenta.Add(sSFRRMBEN05);
        dgvNotVen.DataSource = lNoVenta;
        dgvNotVen.DataBind();
    }
    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }
    protected void dgvCliente_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvCliente, "select$" + e.Row.RowIndex.ToString()));
        }
    }
    protected void dgvCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["CodCli"] = this.dgvCliente.SelectedRow.Cells[0].Text;
        txtCliente.Text = this.dgvCliente.SelectedRow.Cells[0].Text + " - " + this.dgvCliente.SelectedRow.Cells[1].Text;

    }
    protected void btnNuevoBan_Click(object sender, EventArgs e)
    {
        List<SFRRMVEN05> ListAlma = new List<SFRRMVEN05>();
        //ListAlma = lSFRRMBEN01.obtenerRegistros(null);
        SFRRMVEN05 sSFRRMVEN05 = new SFRRMVEN05();
        sSFRRMVEN05.Fac_Codigo = "0001";
        sSFRRMVEN05.Cli_Codigo = "Principal";
        sSFRRMVEN05.Fac_Fecha = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
        ListAlma.Add(sSFRRMVEN05);
        dgvNotVen.DataSource = ListAlma;
        dgvNotVen.DataBind();
        txtFecha.Text = DateTime.Today.ToString("yyyy-MM-dd");
        txtFecha.Enabled = true;
        txtFecCie.Text = DateTime.Today.ToString("yyyy-MM-dd");
        txtFecCie.Enabled = true;
        txtEstado.Text = "Registrado";
        txtCliente.Enabled = false;
        btnClien.Disabled = false;
        btnBusNV.Disabled = true;
        bdoTipMon.Enabled = true;
        txtTipCamb.Enabled = false;
        txtFecCie.Enabled = true;
        txtObservacion.Enabled = true;
        chkIgv.Enabled = true;
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        btnNuevoBan.Enabled = false;
        btnCancelarBan.Enabled = true;
        btnGuardarBan.Enabled = true;
       

    }
    protected void btnGuardarBan_Click(object sender, EventArgs e)
    {
        if (btnGuardarBan.Text == "Cerrar_NV")
        {
            eSFRRMBEN05.NroMovimiento = "";
            eSFRRMBEN05.Fecha = Convert.ToDateTime(DateTime.Now.ToString());
            eSFRRMBEN05.Prov_Codigo = ViewState["CodCli"].ToString();
            eSFRRMBEN05.TipOper = "1";
            eSFRRMBEN05.Observacion = "Ingreso desde Nota de Compra" + txtCodigo.Text;
            eSFRRMBEN05.CDocumento = "NC-" + txtCodigo.Text;
            eSFRRMBEN05.Destino = "000001";
            eSFRRMBEN05.CodAlmacen = "000001";
            eSFRRMBEN05.Moneda = bdoTipMon.SelectedValue;
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
            // lSFRRMBEN05.insertarRegistro(eSFRRMBEN05);


            //int i =0;
            //foreach (var i in Entidad)
            //{

            //}

            btnGuardarBan.Enabled = false;
            Message();
        }
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMVEN05.Fac_Codigo = txtCodigo.Text;
            eSFRRMVEN05.Fac_Fecha = Convert.ToDateTime(txtFecha.Text);
            eSFRRMVEN05.Cli_Codigo = ViewState["CodCli"].ToString();
            eSFRRMVEN05.Fac_Descuento = Convert.ToDecimal("0.00");
            eSFRRMVEN05.Fac_TCambio = Convert.ToDecimal("3.261");
            if (chkIgv.Checked == true)
            {
                eSFRRMVEN05.IncluyeIGV = "1";
            }
            else
            {
                eSFRRMVEN05.IncluyeIGV = "0";
            }
            eSFRRMVEN05.Fac_Moneda = bdoTipMon.SelectedValue;
            eSFRRMVEN05.Fac_Subtotal = Convert.ToDecimal(txtSubTotal.Text);
            eSFRRMVEN05.Fac_Igv = Convert.ToDecimal(txtIgv.Text);
            eSFRRMVEN05.Fac_Total = Convert.ToDecimal(txtTotal.Text);
            eSFRRMVEN05.Fac_Glosa = txtObservacion.Text;

            //txtCodigo.Text = lSFRRMBEN01.insertarRegistro(eSFRRMBEN01);
            btnEliminarBan.Enabled = true;
        }
        else
        {
            eSFRRMVEN05.Fac_Codigo = txtCodigo.Text;
            eSFRRMVEN05.Fac_Fecha = Convert.ToDateTime(txtFecha.Text);
            eSFRRMVEN05.Cli_Codigo = ViewState["CodCli"].ToString();
            eSFRRMVEN05.Fac_Descuento = Convert.ToDecimal("0.00");
            eSFRRMVEN05.Fac_TCambio = Convert.ToDecimal("3.261");
            if (chkIgv.Checked == true)
            {
                eSFRRMVEN05.IncluyeIGV = "1";
            }
            else
            {
                eSFRRMVEN05.IncluyeIGV = "0";
            }
            eSFRRMVEN05.Fac_Moneda = bdoTipMon.SelectedValue;
            eSFRRMVEN05.Fac_Subtotal = Convert.ToDecimal(txtSubTotal.Text);
            eSFRRMVEN05.Fac_Igv = Convert.ToDecimal(txtIgv.Text);
            eSFRRMVEN05.Fac_Total = Convert.ToDecimal(txtTotal.Text);
            eSFRRMVEN05.Fac_Glosa = txtObservacion.Text;
            //lSFRRMBEN14.actualizarRegistro(eSFRRMBEN14);

        }
        btnGuardarBan.Text = "Cerrar_NV";
        Message();
        CargarGrilla();

        if (btnGuardarBan.Text == "Cerrar_NC")
        {
            btnGuardarBan.Enabled = true;
        }
        else
        {
            btnGuardarBan.Enabled = false;
        }
    }
    protected void btnEliminarBan_Click(object sender, EventArgs e)
    {

    }
    protected void btnCancelarBan_Click(object sender, EventArgs e)
    {

    }
}