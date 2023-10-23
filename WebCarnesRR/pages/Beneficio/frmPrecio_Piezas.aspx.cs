using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.BL.BusinessObjects.SFRRMCOM;
using System.Data.SqlClient;
using System.Data;

public partial class pages_Beneficio_PrecioPiezas : System.Web.UI.Page
{
    #region "Variables_Ini"
    //Precio por piezas proveedor
    SFRRMCOM07 eSFRRMBEN18 = new SFRRMCOM07();
    SFRRMCOM07BL lSFRRMBEN18 = new SFRRMCOM07BL();
    //Proveedor
    SFRRMCOM10 eSFRRMBEN21 = new SFRRMCOM10();
    SFRRMCOM10BL lSFRRMBEN21 = new SFRRMCOM10BL();
    //Piezas
    SFRRMCOM05 eSFRRMBEN16 = new SFRRMCOM05();
    SFRRMCOM05BL lSFRRMBEN16 = new SFRRMCOM05BL();

    public string codProv = "";
    public string codPie = "";
    #endregion "Variables_Fin"

    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            txtDescripcion.Text = "";
            //txtPrecio.Text = "";
           // txtProvee.Text = "";
            txtPieza.Text = "";
            txtObservacion.Text = "";
            drbTipPiezas.SelectedValue = "0";
            //btnProvee.Disabled = true;
            btnPieza.Disabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        CargarGrilla();

       

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBusPrePie.Disabled = true;
        //btnProvee.Disabled = false;
        btnPieza.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtDescripcion.Enabled = true;
        
        
        //txtPrecio.Enabled = true;
        //txtProvee.Enabled = true;
        txtPieza.Enabled = true;
        txtObservacion.Enabled = true;
        drbTipPiezas.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = true;
        btnGuardar.Enabled = true;
        //btnProvee.Disabled = false;
        btnPieza.Disabled = false;
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
    
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                eSFRRMBEN18.CTarifario = txtCodigo.Text;
                eSFRRMBEN18.Descripcion = txtDescripcion.Text;
                eSFRRMBEN18.Prov_Codigo = codProv;
               // eSFRRMBEN18.Bie_Codigo = txtPrecio.Text;
                eSFRRMBEN18.Precio = codPie; 
                eSFRRMBEN18.Observacion = drbTipPiezas.SelectedValue;
                txtCodigo.Text = lSFRRMBEN18.insertarRegistro(eSFRRMBEN18);
            }
            else
            {
                eSFRRMBEN18.CTarifario = txtCodigo.Text;
                eSFRRMBEN18.Descripcion = txtDescripcion.Text;
                eSFRRMBEN18.Prov_Codigo = codProv;
                //eSFRRMBEN18.Bie_Codigo = txtPrecio.Text;
                eSFRRMBEN18.Precio  = codPie;
                eSFRRMBEN18.Observacion = drbTipPiezas.SelectedValue;
                lSFRRMBEN18.actualizarRegistro(eSFRRMBEN18);
            }
            CargarGrilla();
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        eSFRRMBEN18.CTarifario = txtCodigo.Text;
        lSFRRMBEN18.eliminarRegistro(eSFRRMBEN18.CTarifario);
        txtCodigo.Text = txtEstado.Text = txtDescripcion.Text =  txtPieza.Text = txtObservacion.Text =  String.Empty;
        drbTipPiezas.SelectedValue = "0";
        btnBusPrePie.Disabled = true;
        btnPieza.Disabled = true;
       // btnProvee.Disabled = true;
        btnGuardar.Enabled = btnEliminar.Enabled = false;
        btnNuevo.Enabled = btnCancelar.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtDescripcion.Enabled = false;
        //txtPrecio.Enabled = false;
        //txtProvee.Enabled = false;
        txtPieza.Enabled = false;
        txtObservacion.Enabled = false;
        drbTipPiezas.Enabled = false;
        CargarGrilla();
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        //btnProvee.Disabled = true;
        btnPieza.Disabled = true;
        btnBusPrePie.Disabled = false;
        btnPieza.Disabled = false;
        //btnProvee.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtDescripcion.Enabled = false;
        //txtPrecio.Enabled = false;
        //txtProvee.Enabled = false;
        txtPieza.Enabled = false;
        txtObservacion.Enabled = false;
        drbTipPiezas.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        txtCodigo.Text = txtEstado.Text = txtDescripcion.Text = txtPieza.Text = txtObservacion.Text = String.Empty;
        drbTipPiezas.SelectedValue = "0";
    }

    protected void dgvPrePie_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigo.Text = this.dgvPrePie.SelectedRow.Cells[0].Text;
        txtCodigo.Enabled = false;
        txtDescripcion.Enabled = true;
        txtDescripcion.Text = this.dgvPrePie.SelectedRow.Cells[1].Text;

        if (this.dgvPrePie.SelectedRow.Cells[6].Text == "1")
        {
            txtEstado.Text = "Registrado";
        }
        //txtPrecio.Text = this.dgvPrePie.SelectedRow.Cells[2].Text;
        //txtPrecio.Enabled = true;
        //txtProvee.Text = this.dgvPrePie.SelectedRow.Cells[3].Text;
        //txtProvee.Enabled = true;
        txtPieza.Text = this.dgvPrePie.SelectedRow.Cells[4].Text;
        txtPieza.Enabled = true;
        txtObservacion.Text = this.dgvPrePie.SelectedRow.Cells[5].Text;
        txtObservacion.Enabled = true;
        drbTipPiezas.SelectedValue = this.dgvPrePie.SelectedRow.Cells[7].Text;
        drbTipPiezas.Enabled = true;
        btnNuevo.Enabled = false;
        btnGuardar.Enabled = true;
        btnEliminar.Enabled = true;

    }
    protected void dgvPrePie_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvPrePie, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
        codProv = this.grvProveedor.SelectedRow.Cells[0].Text;
        //txtProvee.Text = codProv + " " + this.grvProveedor.SelectedRow.Cells[1].Text;
        //txtProvee.Enabled = false;
    }

    protected void grvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvPieza_SelectedIndexChanged(object sender, EventArgs e)
    {
        codPie = this.grvPieza.SelectedRow.Cells[0].Text;
        txtPieza.Text = codPie + this.grvPieza.SelectedRow.Cells[1].Text;
        txtPieza.Enabled = false;
    }

    protected void grvPieza_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvPieza, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        //List<SFRRMCOM10_List> listP = new List<SFRRMCOM10_List>();
        //listP = lSFRRMBEN21.ListarRegistros(null);
        //grvProveedor.DataSource = listP;
        //grvProveedor.DataBind();

        //List<SFRRMCOM07> listPi = new List<SFRRMCOM07>();
        //listPi = lSFRRMCOM07.obtenerRegistros(null);
        //dgvPrePie.DataSource = listPi;
        //grvProveedor.DataBind();

        //List<SFRRMBEN16> list = new List<SFRRMBEN16>();
        //list = lSFRRMBEN16.obtenerRegistro(null); 
        //grvPieza.DataSource = list;
        //grvPieza.DataBind();
    }
    
    #endregion "Metodos_Fin"


}