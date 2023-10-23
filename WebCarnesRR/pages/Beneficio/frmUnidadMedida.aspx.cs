using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.BL.BusinessObjects.SFRRMCOM;
using System.Data.SqlClient;
using System.Data;

public partial class pages_Beneficio_frmUnidadMedida : System.Web.UI.Page
{
    #region "Variables_Ini"

    SFRRMCOM06 eSFRRMBEN17 = new SFRRMCOM06();
    SFRRMCOM06BL lSFRRMBEN17 = new SFRRMCOM06BL();

    #endregion "Variables_Fin"

    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtSunat.Text = "";
            txtAbrev.Text = "";
            txtObservaciones.Text = "";
            btnCancelarNC.Enabled = false;
        }
        CargarGrilla();
    }

    protected void btnNuevoNC_Click(object sender, EventArgs e)
    {
        btnCancelarNC.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;
        txtSunat.Enabled = true;
        txtAbrev.Enabled = true;
        txtObservaciones.Enabled = true;
        btnNuevoNC.Enabled = false;
        btnEliminarNC.Enabled = false;
        btnGuardarNC.Enabled = true;
        btnUnidadM.Disabled = true;

    }

    protected void btnGuardarNC_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMBEN17.Cod_Udm = txtCodigo.Text.Trim();
            eSFRRMBEN17.Nombre = txtNombre.Text.Trim();
            eSFRRMBEN17.Abreviatura = txtSunat.Text.Trim();
            eSFRRMBEN17.Codigo_Sunat = txtAbrev.Text.Trim();
            eSFRRMBEN17.Observacion = txtObservaciones.Text.Trim();
            txtCodigo.Text = lSFRRMBEN17.insertarRegistro(eSFRRMBEN17);
            txtEstado.Text = "Registrado";
        }
        else
        {
            //eSFRRMBEN17.Cod_Udm = txtCodigo.Text.Trim();
            //eSFRRMBEN17.Nombre = txtNombre.Text.Trim();
            //eSFRRMBEN17.Abreviatura = txtSunat.Text.Trim();
            //eSFRRMBEN17.Codigo_Sunat = txtAbrev.Text.Trim();
            //eSFRRMBEN17.Observacion = txtObservaciones.Text.Trim();
            //lSFRRMBEN17.actualizarRegistro(eSFRRMBEN17);
        }

        Message();
        btnGuardarNC.Text = "Actualizar";
        btnEliminarNC.Enabled = true;
        CargarGrilla();
    }

    protected void btnEliminarNC_Click(object sender, EventArgs e)
    {
        //lSFRRMBEN17.eliminarRegistro(txtCodigo.Text.Trim());

        //txtCodigo.Text = txtEstado.Text = txtNombre.Text = txtSunat.Text = txtAbrev.Text = txtObservaciones.Text = String.Empty;
        //btnGuardarNC.Enabled = btnEliminarNC.Enabled = false;
        btnNuevoNC.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtSunat.Enabled = false;
        txtAbrev.Enabled = false;
        txtObservaciones.Enabled = false;
        btnUnidadM.Disabled = false;
        btnCancelarNC.Enabled = false;
        btnGuardarNC.Text = "Guardar";
        CargarGrilla();
    }

    protected void btnCancelarNC_Click(object sender, EventArgs e)
    {
        txtEstado.Text = txtNombre.Text = txtSunat.Text = txtCodigo.Text = txtObservaciones.Text = txtAbrev.Text = String.Empty;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtSunat.Enabled = false;
        txtAbrev.Enabled = false;
        txtObservaciones.Enabled = false;
        btnNuevoNC.Enabled = true;
        btnEliminarNC.Enabled = false;
        btnGuardarNC.Enabled = false;
        btnUnidadM.Disabled = false;
        btnCancelarNC.Enabled = false;
        btnGuardarNC.Text = "Guardar";
    }

    protected void gdrUnidadM_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigo.Text = this.gdrUnidadM.SelectedRow.Cells[0].Text;
        txtCodigo.Enabled = false;
        txtNombre.Enabled = true;
        txtNombre.Enabled = true;
        txtSunat.Enabled = true;
        txtAbrev.Enabled = true;
        txtObservaciones.Enabled = true;
        txtNombre.Text = this.gdrUnidadM.SelectedRow.Cells[1].Text;
        txtSunat.Text = this.gdrUnidadM.SelectedRow.Cells[2].Text;
        txtAbrev.Text = this.gdrUnidadM.SelectedRow.Cells[3].Text;
        txtObservaciones.Text = this.gdrUnidadM.SelectedRow.Cells[4].Text;
        txtEstado.Text = "Registrado";
        btnGuardarNC.Text = "Actualizar";
        btnNuevoNC.Enabled = false;
        btnGuardarNC.Enabled = true;
        btnEliminarNC.Enabled = true;
        btnCancelarNC.Enabled = true;   
    }

    protected void gdrUnidadM_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(gdrUnidadM, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    private void CargarGrilla()
    {
        //List<SFRRMCOM09> listUMD = new List<SFRRMCOM09>();
        //listUMD = lSFRRMBEN17.obtenerRegistros(null);
        //gdrUnidadM.DataSource = listUMD;
        //gdrUnidadM.DataBind();
    }

    #endregion "Metodos_Fin"
}