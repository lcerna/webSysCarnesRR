using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessObjects.SFRRMCOM;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.BL.BusinessObjects.SFRRMADM;
using RCRR.BL.BusinessEntities.SFRRMADM;
using System.Data;

public partial class pages_Proveedor : System.Web.UI.Page
{
    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtCont.Text = "";
            txtDirec.Text = "";
            txtemail.Text = "";
            txtNumDoc.Text = "";
            txtNumTelf.Text = "";
            txtObser.Text = "";           
            btnCancelar.Enabled = false;
        }
        CargarGrilla();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBusProvee.Disabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;
        txtCont.Enabled = true;
        txtDirec.Enabled = true;
        txtemail.Enabled = true;
        txtNumDoc.Enabled = true;
        txtNumTelf.Enabled = true;
        txtObser.Enabled = true;
        cmbTipDoc.Enabled = true;
        cmbTipTel.Enabled = true;
        cmbDepa.Enabled = true;
        cmbProv.Enabled = true;
        cmbDist.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnCancelar.Enabled = true;
        btnGuardar.Text = "Guardar";
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        SFRRMCOM10 eSFRRMBEN21 = new SFRRMCOM10();

        eSFRRMBEN21.Prov_Codigo = txtCodigo.Text;
        eSFRRMBEN21.Prov_Nombre = txtNombre.Text;
        eSFRRMBEN21.Tip_Doc = cmbTipDoc.SelectedValue;
        eSFRRMBEN21.Prov_NumDoc = txtNumDoc.Text;
        eSFRRMBEN21.Prov_Direccion = txtDirec.Text;
        eSFRRMBEN21.Prov_Telefono = txtNumTelf.Text;
        eSFRRMBEN21.Prov_TipTelf = cmbTipTel.SelectedValue;
        eSFRRMBEN21.Prov_Contacto = txtCont.Text;
        eSFRRMBEN21.Prov_email = txtemail.Text;
        eSFRRMBEN21.Prov_Observaciones = txtObser.Text;
        eSFRRMBEN21.Depa = cmbDepa.SelectedValue;
        eSFRRMBEN21.Prov = cmbProv.SelectedValue;
        eSFRRMBEN21.Dist = cmbDist.SelectedValue;
        eSFRRMBEN21.Prov_Estado = "1";
        eSFRRMBEN21.Usu_Crea = "";
        eSFRRMBEN21.Fec_Crea = DateTime.Now;
        eSFRRMBEN21.Usu_Upd = "";
        eSFRRMBEN21.Fec_upd = DateTime.Now;

        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        if (String.IsNullOrEmpty(txtCodigo.Text))
            txtCodigo.Text = leSFRRMBEN21.insertarRegistro(eSFRRMBEN21);
        else                    
            leSFRRMBEN21.actualizarRegistro(eSFRRMBEN21);

        btnGuardar.Text = "Actualizar";
        btnEliminar.Enabled = true;
        Message();
        CargarGrilla();
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        leSFRRMBEN21.eliminarRegistro(txtCodigo.Text.Trim());

        txtCodigo.Text = txtCont.Text = txtNombre.Text = txtDirec.Text = txtemail.Text = txtNumDoc.Text = txtNumTelf.Text = txtObser.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        cmbTipTel.SelectedValue = "0";
        cmbDepa.SelectedValue = "0";
        cmbProv.SelectedValue = "0";
        cmbDist.SelectedValue = "0";
        btnBusProvee.Disabled = false;
        btnGuardar.Enabled = btnEliminar.Enabled = false;
        btnNuevo.Enabled = btnCancelar.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        cmbTipDoc.Enabled = false;
        txtNombre.Enabled = false;
        txtDirec.Enabled = false;
        txtemail.Enabled = false;
        txtNumDoc.Enabled = false;
        txtNumTelf.Enabled = false;
        btnCancelar.Enabled = false;
        txtObser.Enabled = false;
        txtCont.Enabled = false;
        cmbTipTel.Enabled = false;
        cmbDepa.Enabled = false;
        cmbProv.Enabled = false;
        cmbDist.Enabled = false;
        btnGuardar.Text = "Guardar";


        CargarGrilla();
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBusProvee.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtCont.Enabled = false;
        txtDirec.Enabled = false;
        txtemail.Enabled = false;
        txtNumDoc.Enabled = false;
        txtNumTelf.Enabled = false;
        txtObser.Enabled = false;
        cmbTipDoc.Enabled = false;
        cmbTipTel.Enabled = false;
        cmbDepa.Enabled = false;
        cmbProv.Enabled = false;
        cmbDist.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        btnCancelar.Enabled = false;
        txtCodigo.Text = txtCont.Text = txtNombre.Text = txtDirec.Text = txtemail.Text = txtNumDoc.Text = txtNumTelf.Text = txtObser.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        cmbTipTel.SelectedValue = "0";
        cmbDepa.SelectedValue = "0";
        cmbProv.SelectedValue = "0";
        cmbDist.SelectedValue = "0";
        btnGuardar.Text = "Guardar";
    }

    protected void dgvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
        SFRRMCOM10 entidad = new SFRRMCOM10();
        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        entidad = leSFRRMBEN21.obtenerRegistros(this.dgvProveedor.SelectedRow.Cells[0].Text.Trim());

        if (entidad != null)
        {
            txtCodigo.Text = entidad.Prov_Codigo;
            cmbTipDoc.SelectedValue = entidad.Tip_Doc;
            txtNumDoc.Text = entidad.Prov_NumDoc;
            txtNombre.Text = entidad.Prov_Nombre;
            txtDirec.Text = entidad.Prov_Direccion;
            txtNumTelf.Text = entidad.Prov_Telefono;
            cmbTipTel.SelectedValue = entidad.Prov_TipTelf;
            txtCont.Text = entidad.Prov_Contacto;
            txtemail.Text = entidad.Prov_email;
            txtObser.Text = entidad.Prov_Observaciones;
            cmbDepa.SelectedValue = entidad.Depa;
            cmbProv.SelectedValue = entidad.Prov;
            cmbDist.SelectedValue = entidad.Dist;
            txtEstado.Text = entidad.Prov_Estado;
            btnGuardar.Text = "Actualizar";
            btnBusProvee.Disabled = true;
            btnEliminar.Enabled = btnCancelar.Enabled = btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            txtCodigo.Enabled = false;
            txtEstado.Enabled = false;
            txtNombre.Enabled = true;
            txtCont.Enabled = true;
            txtDirec.Enabled = true;
            txtemail.Enabled = true;
            txtNumDoc.Enabled = true;
            txtNumTelf.Enabled = true;
            txtObser.Enabled = true;
            cmbTipDoc.Enabled = true;
            cmbTipTel.Enabled = true;
            cmbDepa.Enabled = true;
            cmbProv.Enabled = true;
            cmbDist.Enabled = true;
        }
    }

    protected void dgvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void cmbTipDoc_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtNumDoc.ReadOnly = false;
        txtNumDoc.Text = String.Empty;

        if (cmbTipDoc.SelectedValue == "0")
            txtNumDoc.ReadOnly = true;
        else if (cmbTipDoc.SelectedValue == "1")
            txtNumDoc.MaxLength = 8;
        else
            txtNumDoc.MaxLength = 12;
    }

    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        SFRRMCOM10BL leSFRRMBEN21 = new SFRRMCOM10BL();
        List<SFRRMCOM10_List> listProv = new List<SFRRMCOM10_List>();
        listProv = leSFRRMBEN21.ListarRegistros(null);
        dgvProveedor.DataSource = listProv;
        dgvProveedor.DataBind();
    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion "Metodos_Fin"          
}