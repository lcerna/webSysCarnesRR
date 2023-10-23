using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;

public partial class pages_Beneficio_Proveedor : System.Web.UI.Page
{
    #region "Variables_Ini"

    SFRRMBEN03 eSFRRMBEN03 = new SFRRMBEN03();
    SFRRMBEN03BL lSFRRMBEN03 = new SFRRMBEN03BL();
    SFRRMBEN04 eSFRRMBEN04 = new SFRRMBEN04();
    SFRRMBEN04BL lSFRRMBEN04 = new SFRRMBEN04BL();

    #endregion "Variables_Fin"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtComentario.Text = "";
            txtEstado.Text = "";
            txtCodigoMot.Text = "";
            txtEstadoMot.Text = "";
            txtDescMot.Text = "";
            txtDesCorMot.Text = "";
            txtSunatMot.Text = "";
            txtDesCorMot.Text = "";


        }
        CargarGrilla();
        CargarGrillaMov();
    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBuscarAlm.Disabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtDescripcion.Enabled = true;
        txtComentario.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = true;

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMBEN03.TipOper = txtCodigo.Text;
            eSFRRMBEN03.DscAlmacen = txtDescripcion.Text;
            eSFRRMBEN03.Estado = 1;
            eSFRRMBEN03.Comentario = txtComentario.Text;
            txtCodigo.Text = lSFRRMBEN03.insertarRegistro(eSFRRMBEN03);
            btnEliminar.Enabled = true;
        }
        else
        {
            eSFRRMBEN03.TipOper = txtCodigo.Text;
            eSFRRMBEN03.DscAlmacen = txtDescripcion.Text;
            eSFRRMBEN03.Estado = 2;
            eSFRRMBEN03.Comentario = txtComentario.Text;
            lSFRRMBEN03.actualizarRegistro(eSFRRMBEN03);

        }
        btnGuardar.Text = "Actualizar";
        Message();
        CargarGrilla();
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        eSFRRMBEN03.TipOper = txtCodigo.Text;
        lSFRRMBEN03.eliminarRegistro(eSFRRMBEN03.TipOper);
        txtCodigo.Text = txtDescripcion.Text = txtComentario.Text = txtEstado.Text = String.Empty;
        btnBuscarAlm.Disabled = false;
        btnGuardar.Enabled = btnEliminar.Enabled = false;
        btnNuevo.Enabled = btnCancelar.Enabled = true;
        txtCodigo.Enabled = false;
        txtDescripcion.Enabled = false;
        txtComentario.Enabled = false;
        txtEstado.Enabled = false;
        CargarGrilla();
        btnGuardar.Text = "Guardar";
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBuscarAlm.Disabled = false;
        txtCodigo.Enabled = false;
        txtDescripcion.Enabled = false;
        txtComentario.Enabled = false;
        txtEstado.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        txtCodigo.Text = txtDescripcion.Text = txtComentario.Text = txtEstado.Text = String.Empty;
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = false;

    }
    protected void dgvTipoMotivo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvTipoMotivo, "select$" + e.Row.RowIndex.ToString()));
        }
    }
    protected void dgvTipoMotivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigo.Text = this.dgvTipoMotivo.SelectedRow.Cells[0].Text;
        txtCodigo.Enabled = false;
        txtDescripcion.Text = this.dgvTipoMotivo.SelectedRow.Cells[1].Text;
        txtDescripcion.Enabled = true;
        txtComentario.Text = this.dgvTipoMotivo.SelectedRow.Cells[2].Text;
        txtComentario.Enabled = true;
        if (this.dgvTipoMotivo.SelectedRow.Cells[3].Text == Convert.ToString(1))
       {
           txtEstado.Text = "Registrado";
        }
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Actualizar";
        
    }
   
    
    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    private void CargarGrilla()
    {
        List<SFRRMBEN03> list = new List<SFRRMBEN03>();
        list = lSFRRMBEN03.obtenerRegistros(null);
        dgvTipoMotivo.DataSource = list;
        dgvTipoMotivo.DataBind();
        
    }

    private void CargarGrillaMov()
    {
        List<SFRRMBEN04> list = new List<SFRRMBEN04>();
        list = lSFRRMBEN04.obtenerRegistros(null);
        dgvTipoMotivo.DataSource = list;
        dgvTipoMotivo.DataBind();

    }
    protected void btnNuevoMov_Click(object sender, EventArgs e)
    {
        btnMov.Disabled = true;
        txtCodigoMot.Enabled = false;
        txtEstadoMot.Enabled = false;
        txtDescMot.Enabled = true;
        txtDesCorMot.Enabled = true;
        cmbTipMoti.SelectedValue = "0";
        txtSunatMot.Text = "";
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = true;
    }
    protected void btnGuardarMov_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigoMot.Text))
        {
            eSFRRMBEN04.CodMovimiento = txtCodigoMot.Text;
            eSFRRMBEN04.DscMovimiento = txtDescMot.Text;
            eSFRRMBEN04.Estado = 1;
            eSFRRMBEN04.DscCorto = txtComentario.Text;
            eSFRRMBEN04.CodigoSunat = txtSunatMot.Text;
            eSFRRMBEN04.TipOper= "1";
            txtCodigo.Text = lSFRRMBEN04.insertarRegistro(eSFRRMBEN04);
            btnEliminar.Enabled = true;
        }
        else
        {
            eSFRRMBEN04.CodMovimiento = txtCodigoMot.Text;
            eSFRRMBEN04.DscMovimiento = txtDescMot.Text;
            eSFRRMBEN04.Estado = 1;
            eSFRRMBEN04.DscCorto = txtComentario.Text;
            eSFRRMBEN04.CodigoSunat = txtSunatMot.Text;
            eSFRRMBEN04.TipOper = cmbTipMoti.SelectedValue;
            lSFRRMBEN04.actualizarRegistro(eSFRRMBEN04);

        }
        btnGuardar.Text = "Actualizar";
        Message();
        CargarGrillaMov();

    }
    protected void btnEliminarMov_Click(object sender, EventArgs e)
    {
        eSFRRMBEN04.CodMovimiento = txtCodigoMot.Text;
        lSFRRMBEN04.eliminarRegistro(eSFRRMBEN04.CodMovimiento);
        txtCodigoMot.Text = txtDescMot.Text = txtComentario.Text = txtSunatMot.Text = txtEstadoMot.Text = String.Empty;
        btnMov.Disabled = false;
        btnGuardarMov.Enabled = btnEliminarMov.Enabled = false;
        btnNuevoMov.Enabled = btnCancelarMov.Enabled = true;
        txtCodigoMot.Enabled = false;
        txtDescMot.Enabled = false;
        txtSunatMot.Enabled = false;
        txtEstadoMot.Enabled = false;
        CargarGrillaMov();
        btnGuardar.Text = "Guardar";

    }
    protected void btnCancelarMov_Click(object sender, EventArgs e)
    {
        btnMov.Disabled = false;
        btnGuardarMov.Enabled = btnEliminarMov.Enabled = false;
        btnNuevoMov.Enabled = btnCancelarMov.Enabled = true;
        txtCodigoMot.Enabled = false;
        txtDescMot.Enabled = false;
        txtSunatMot.Enabled = false;
        txtEstadoMot.Enabled = false;
        CargarGrillaMov();
        btnGuardar.Text = "Guardar";
        txtCodigoMot.Text = txtDescMot.Text = txtComentario.Text = txtSunatMot.Text = txtEstadoMot.Text = String.Empty;
        btnCancelar.Enabled = false;

    }
    protected void dgvMotivo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvMotivo, "select$" + e.Row.RowIndex.ToString()));
        }
    }
    protected void dgvMotivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigoMot.Text = this.dgvTipoMotivo.SelectedRow.Cells[0].Text;
        txtCodigoMot.Enabled = false;
        txtDescMot.Text = this.dgvTipoMotivo.SelectedRow.Cells[1].Text;
        txtDescMot.Enabled = true;
        txtSunatMot.Text = this.dgvTipoMotivo.SelectedRow.Cells[2].Text;
        txtSunatMot.Enabled = true;
        if (this.dgvTipoMotivo.SelectedRow.Cells[3].Text == Convert.ToString(1))
        {
            txtEstadoMot.Text = "Registrado";
        }
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Actualizar";
        

    }

}