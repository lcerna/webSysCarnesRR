using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;//using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;

using RCRR.BL.BusinessObjects.SFRRMCOM;
using RCRR.BL.BusinessEntities.SFRRMCOM;

public partial class pages_Beneficio_Proveedor : System.Web.UI.Page
{
    #region "Variables_Ini"

    SFRRMCOM08 eSFRRMBEN19 = new SFRRMCOM08();
    SFRRMCOM08BL lSFRRMBEN19 = new SFRRMCOM08BL();

    #endregion "Variables_Fin"

    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = "";
            
        }
        CargarGrilla();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBuscarCortes.Disabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnCancelar.Enabled = true;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMBEN19.TipCor_Cod = txtCodigo.Text;
            eSFRRMBEN19.TipCor_Descrip = txtNombre.Text;
            eSFRRMBEN19.TipCor_Estado = "1";
            //txtCodigo.Text = lSFRRMBEN19.insertarRegistro(eSFRRMBEN19);
        }
        else
        {
            eSFRRMBEN19.TipCor_Cod = txtCodigo.Text;
            eSFRRMBEN19.TipCor_Descrip = txtNombre.Text;
            eSFRRMBEN19.TipCor_Estado = "2";
            //lSFRRMBEN19.actualizarRegistro(eSFRRMBEN19);
        }
        txtEstado.Text = "Registrado";
        btnGuardar.Text = "Actualizar";
        btnEliminar.Enabled = true;
        Message();
        CargarGrilla();
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        int valEli = lSFRRMBEN19.ValidaEliminar(txtCodigo.Text);

        if (valEli == 0)
        {
            eSFRRMBEN19.TipCor_Cod = txtCodigo.Text;
            eSFRRMBEN19.TipCor_Descrip = txtNombre.Text;
            eSFRRMBEN19.TipCor_Estado = "1";
            lSFRRMBEN19.eliminarRegistro(eSFRRMBEN19.TipCor_Cod);
            txtCodigo.Text = txtEstado.Text = txtNombre.Text = String.Empty;
            btnBuscarCortes.Disabled = false;
            btnGuardar.Enabled = btnEliminar.Enabled = btnCancelar.Enabled = false;
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = true;
            txtCodigo.Enabled = false;
            txtEstado.Enabled = false;
            CargarGrilla();
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBuscarCortes.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        txtCodigo.Text = txtEstado.Text = txtNombre.Text =  String.Empty;
        btnCancelar.Enabled = false;
        btnGuardar.Text = "Guardar";
    }

    protected void dgvTipCortes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvTipCortes, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvTipCortes_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigo.Text = this.dgvTipCortes.SelectedRow.Cells[0].Text;
        txtCodigo.Enabled = false;
        txtNombre.Enabled = true;
        txtNombre.Text = this.dgvTipCortes.SelectedRow.Cells[1].Text;
        if (this.dgvTipCortes.SelectedRow.Cells[2].Text == "1")
        {
            txtEstado.Text = "Registrado";
        }
        btnNuevo.Enabled = false;
        btnGuardar.Enabled = true;
        btnEliminar.Enabled = true;
        btnCancelar.Enabled = true;
        btnGuardar.Text = "Actualizar";
    }


    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        List<SFRRMCOM08> list = new List<SFRRMCOM08>();
        list = lSFRRMBEN19.obtenerRegistros(null);
        dgvTipCortes.DataSource = list;
        dgvTipCortes.DataBind();
    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion "Metodos_Fin"
}