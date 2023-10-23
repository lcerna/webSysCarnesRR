using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessObjects.SFRRMCOM;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.BL.BusinessEntities.SFRRMVEN;
using RCRR.BL.BusinessObjects.SFRRMVEN;

public partial class pages_Ventas_Cliente : System.Web.UI.Page
{
    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {        
            
            btnBusAlmacen.Disabled = true;
            btnBuPrv.Disabled = true;
        }

        //CargarGrilla();
        //CargaAlmacen();
        //CargarProveedor();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBuscarCli.Disabled = true;
        txtEmail.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;        
        txtDirec.Enabled = true;
        txtRango.Enabled = true;
        txtNumDoc.Enabled = true;
        txtSexoPor.Enabled = true;
        txtObserva.Enabled = true;
        cmbTipDoc.Enabled = true;
        txtXContac.Enabled = true;
        cmbDepa.Enabled = true;
        cmbProv.Enabled = true;
        cmbDist.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnCancelar.Enabled = true;
        btnBusAlmacen.Disabled = false;
        btnBuPrv.Disabled = false;
        dblTipTelf.Enabled = true;
        txtNumTel.Enabled = true;
        btnGuardar.Text = "Guardar";
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        SFRRMVEN03 eSFRRMVEN03 = new SFRRMVEN03();

        eSFRRMVEN03.Cli_Codigo = txtCodigo.Text;
        eSFRRMVEN03.CDocumento = cmbTipDoc.SelectedValue;
        eSFRRMVEN03.Cli_NumDocu = txtNumDoc.Text;        
        eSFRRMVEN03.Cli_RazonSocial = txtNombre.Text;
        eSFRRMVEN03.Cli_Direccion = txtDirec.Text;
        eSFRRMVEN03.Cli_Nombre = !String.IsNullOrEmpty(txtAlmacen.Text) ? txtAlmacen.Text.ToString().Split('-')[0].ToString().Trim() : String.Empty;
        eSFRRMVEN03.Cli_Referencia = !String.IsNullOrEmpty(txtPrefProv.Text) ? txtPrefProv.Text.ToString().Split('-')[0].ToString().Trim() : String.Empty; 
        eSFRRMVEN03.Cli_Contacto = txtXContac.Text;
        eSFRRMVEN03.Depa = cmbDepa.SelectedValue;
        eSFRRMVEN03.Prov = cmbProv.SelectedValue;
        eSFRRMVEN03.Dist = cmbDist.SelectedValue;        
        eSFRRMVEN03.Cli_email = txtEmail.Text;
        eSFRRMVEN03.Cli_TipTef = dblTipTelf.SelectedValue;
        eSFRRMVEN03.Cli_ApePat = txtRango.Text;
        eSFRRMVEN03.Cli_ApeMat = txtSexoPor.Text;
        //eSFRRMVEN03.cl
        eSFRRMVEN03.Cli_NumTelf = txtNumTel.Text;        
        eSFRRMVEN03.Cli_Estado = "1";
        eSFRRMVEN03.Usu_Crea = "";
        eSFRRMVEN03.Fec_Crea = DateTime.Now;
        eSFRRMVEN03.Usu_Upd = "";
        eSFRRMVEN03.Fec_Upd = DateTime.Now;
       
        SFRRMVEN03BL leSFRRMBEN21 = new SFRRMVEN03BL();
        if (String.IsNullOrEmpty(txtCodigo.Text))
            txtCodigo.Text = leSFRRMBEN21.insertarRegistro(eSFRRMVEN03);
        else
            leSFRRMBEN21.actualizarRegistro(eSFRRMVEN03);

        btnGuardar.Text = "Actualizar";
        btnEliminar.Enabled = true;
        Message();
        CargarGrilla();
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        leSFRRMBEN21.eliminarRegistro(txtCodigo.Text.Trim());

        txtCodigo.Text = txtXContac.Text = txtNombre.Text = txtDirec.Text = txtEmail.Text = txtNumDoc.Text = txtNumTel.Text = txtAlmacen.Text = txtPrefProv.Text = txtObserva.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        dblTipTelf.SelectedValue = "0";
        cmbDepa.SelectedValue = "0";
        cmbProv.SelectedValue = "0";
        cmbDist.SelectedValue = "0";
        btnBuscarCli.Disabled = false;
        btnGuardar.Enabled = btnEliminar.Enabled = false;
        btnNuevo.Enabled = btnCancelar.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        cmbTipDoc.Enabled = false;
        dblTipTelf.Enabled = false;
        cmbDepa.Enabled = false;
        cmbProv.Enabled = false;
        cmbDist.Enabled = false;
        btnGuardar.Text = "Guardar";
        CargarGrilla();
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBuscarCli.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtXContac.Enabled = false;
        txtDirec.Enabled = false;
        txtEmail.Enabled = false;
        txtNumDoc.Enabled = false;
        txtNumTel.Enabled = false;
        txtObserva.Enabled = false;
        cmbTipDoc.Enabled = false;
        dblTipTelf.Enabled = false;
        cmbDepa.Enabled = false;
        cmbProv.Enabled = false;
        cmbDist.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        btnCancelar.Enabled = false;
        txtSexoPor.Enabled = false;
        txtRango.Enabled = false;
        txtCodigo.Text = txtXContac.Text = txtNombre.Text = txtDirec.Text = txtEmail.Text = txtNumDoc.Text = txtNumTel.Text = txtObserva.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        dblTipTelf.SelectedValue = "0";
        cmbDepa.SelectedValue = "0";
        cmbProv.SelectedValue = "0";
        cmbDist.SelectedValue = "0";
        btnGuardar.Text = "Guardar";
        btnBuPrv.Disabled = true;
        btnBusAlmacen.Disabled = true;
    }

    protected void grvCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        SFRRMVEN03 entidad = new SFRRMVEN03();
        SFRRMVEN03BL leSFRRMBEN03 = new SFRRMVEN03BL();
        entidad = leSFRRMBEN03.obtenerRegistros(this.grvCliente.SelectedRow.Cells[0].Text.Trim());

        if (entidad != null)
        {
        txtCodigo.Text = entidad.Cli_Codigo;
        txtNumDoc.Text = entidad.Cli_NumDocu;
        txtNombre.Text = entidad.Cli_RazonSocial;
        txtDirec.Text = entidad.Cli_Direccion;
        txtAlmacen.Text = entidad.Cli_Nombre;
        txtPrefProv.Text = entidad.Cli_Referencia;
        txtXContac.Text = entidad.Cli_Contacto;
        cmbDepa.SelectedValue = entidad.Depa;
        cmbProv.SelectedValue = entidad.Prov;
        cmbDist.SelectedValue = entidad.Dist;
        txtEmail.Text = entidad.Cli_email;
        dblTipTelf.SelectedValue = entidad.Cli_TipTef;
        txtNumTel.Text = entidad.Cli_NumTelf;
        cmbTipDoc.SelectedValue = entidad.Cli_TipTef;
        txtRango.Text = entidad.Cli_ApePat;
        txtSexoPor.Text = entidad.Cli_ApeMat;
        
        if (entidad.Cli_Estado=="1")
        {
            txtEstado.Text = "Registrado";
        }
        else {
            txtEstado.Text = "Guardado";
        }
        
        btnGuardar.Text = "Actualizar";
        //btnBusProvee.Disabled = true;
        btnEliminar.Enabled = btnCancelar.Enabled = btnGuardar.Enabled = true;
        btnNuevo.Enabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;
        //txtCont.Enabled = true;
        txtDirec.Enabled = true;
        txtEmail.Enabled = true;
        txtNumDoc.Enabled = true;
       txtNumTel.Enabled = true;
        //txtObser.Enabled = true;
       dblTipTelf.Enabled = true;
       txtRango.Enabled = true;
       txtSexoPor.Enabled = true;
       txtObserva.Enabled = true;
       txtXContac.Enabled = true;
       cmbTipDoc.Enabled = true;
        cmbDepa.Enabled = true;
        cmbProv.Enabled = true;
        cmbDist.Enabled = true;
        }
    }

    protected void grvCliente_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvCliente, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvAlmacen_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvAlmacen, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvAlmacen_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtAlmacen.Text = this.grvAlmacen.SelectedRow.Cells[0].Text + " - " + this.grvAlmacen.SelectedRow.Cells[1].Text;
    }

    protected void grvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtPrefProv.Text = this.grvProveedor.SelectedRow.Cells[0].Text + " - " + this.grvProveedor.SelectedRow.Cells[1].Text;
    }

    protected void grvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }
    
    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        SFRRMVEN03BL leSFRRMBEN03 = new SFRRMVEN03BL();
        List<SFRRMVEN03_List> listProv = new List<SFRRMVEN03_List>();
        listProv = leSFRRMBEN03.listarRegistros(null);
        grvCliente.DataSource = listProv;
        grvCliente.DataBind();
    }

    private void CargaAlmacen()
    {
        SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();
        List<SFRRMBEN01> list = new List<SFRRMBEN01>();
        list = lSFRRMBEN01.obtenerRegistros(null);
        grvAlmacen.DataSource = list;
        grvAlmacen.DataBind();
    }

    private void CargarProveedor()
    {
        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        List<SFRRMCOM10_List> listProv = new List<SFRRMCOM10_List>();
        listProv = leSFRRMBEN21.ListarRegistros(null);
        grvProveedor.DataSource = listProv;
        grvProveedor.DataBind();
    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion "Metodos_Fin"   
}