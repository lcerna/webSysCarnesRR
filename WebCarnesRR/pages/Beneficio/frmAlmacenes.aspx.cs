
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using System.Data.SqlClient;
using System.Data;

public partial class pages_Beneficio_Proveedor : System.Web.UI.Page
{
    #region "Variables_Ini"

    SFRRMBEN01 eSFRRMBEN01 = new SFRRMBEN01();
    SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();

    #endregion "Variables_Fin"

    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            CargarGrilla();
        }        
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBuscarAlm.Disabled = true;
        TextBox1.Enabled = false;
        TextBox2.Enabled = true;
        cmbTipDoc.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = true;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text))
        {
            eSFRRMBEN01.CodAlmacen = TextBox1.Text;
            eSFRRMBEN01.DscAlmacen = TextBox2.Text;
            eSFRRMBEN01.TipAlmacen = cmbTipDoc.SelectedValue;
            TextBox1.Text = lSFRRMBEN01.insertarRegistro(eSFRRMBEN01);
            btnEliminar.Enabled = true;
        }
        else
        {
            eSFRRMBEN01.CodAlmacen = TextBox1.Text;
            eSFRRMBEN01.DscAlmacen = TextBox2.Text;
            eSFRRMBEN01.TipAlmacen = cmbTipDoc.SelectedValue;
            lSFRRMBEN01.actualizarRegistro(eSFRRMBEN01);

        }
        btnGuardar.Text = "Actualizar";
        Message();
        CargarGrilla();
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        eSFRRMBEN01.CodAlmacen = TextBox1.Text;
        eSFRRMBEN01.DscAlmacen = TextBox2.Text;
        eSFRRMBEN01.Estado = TextBox3.Text;
        eSFRRMBEN01.TipAlmacen = cmbTipDoc.DataValueField;
        lSFRRMBEN01.eliminarRegistro(eSFRRMBEN01.CodAlmacen);
        TextBox1.Text = TextBox2.Text = TextBox3.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        btnBuscarAlm.Disabled = false;
        btnGuardar.Enabled = btnEliminar.Enabled = false;
        btnNuevo.Enabled = btnCancelar.Enabled = true;
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        cmbTipDoc.Enabled = false;
        CargarGrilla();
        btnGuardar.Text = "Guardar";
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBuscarAlm.Disabled = false;
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        cmbTipDoc.Enabled = false;
        btnNuevo.Enabled = true;        
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        TextBox1.Text = TextBox2.Text = TextBox3.Text = String.Empty;
        cmbTipDoc.SelectedValue = "0";
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = false;
    }

    protected void btnModalG_Click(object sender, EventArgs e)
    {
        //List<SFRRMBEN01> list = new List<SFRRMBEN01>();
        //list = lSFRRMBEN01.obtenerRegistros(null);
        //dgvAlmacenes.DataSource = list;
        //dgvAlmacenes.DataBind();
    }
    
    protected void dgvAlmacenes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvAlmacenes, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = this.dgvAlmacenes.SelectedRow.Cells[0].Text;
        TextBox1.Enabled = false;
        TextBox2.Enabled = true;
        TextBox2.Text = this.dgvAlmacenes.SelectedRow.Cells[1].Text;

        if (this.dgvAlmacenes.SelectedRow.Cells[4].Text == "1")
        {
            TextBox3.Text = "Registrado";
        }

        cmbTipDoc.SelectedValue = this.dgvAlmacenes.SelectedRow.Cells[4].Text;
        cmbTipDoc.Enabled = true;
        btnNuevo.Enabled = false;
        btnGuardar.Enabled = true;
        btnEliminar.Enabled = true;
        btnGuardar.Text = "Actualizar";
        btnBuscarAlm.Disabled = true;
        btnCancelar.Enabled = true;
    }

    protected void dgvAlmacenes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgvAlmacenes.PageIndex = e.NewPageIndex;
        CargarGrilla();
    }

    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        //List<SFRRMBEN01> list = new List<SFRRMBEN01>();
        //list = lSFRRMBEN01.obtenerRegistros(null);
        //dgvAlmacenes.DataSource = list;
        //dgvAlmacenes.DataBind();
    }

    private void Message()
    {       
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente." ), true);        
    }

    #endregion "Metodos_Fin"    
}