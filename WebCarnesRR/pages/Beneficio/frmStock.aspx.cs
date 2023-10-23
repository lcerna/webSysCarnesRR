using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;

public partial class pages_Beneficio_frmStock : System.Web.UI.Page
{
    #region "Variables_Ini"

    SFRRMBEN09 eSFRRMBEN09 = new SFRRMBEN09();
    SFRRMBEN09BL lSFRRMBEN09 = new SFRRMBEN09BL();
    SFRRMBEN01 eSFRRMBEN01 = new SFRRMBEN01();
    SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();
    public string cod_Alma = "";

    #endregion "Variables_Fin"

    #region "Eventos_Ini"
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtAlmacen.Text = "";
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            btnAlmacen.Disabled = true;
            btnGenerar.Enabled = false;

        }
        //CargarGrilla();
        //CargarGrillaAlma();

    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnBuscarStock.Disabled = true;
        btnAlmacen.Disabled = false;
        txtCodigo.Enabled = false;
        txtAlmacen.Enabled = true;
        txtEstado.Enabled = false;
        txtDescripcion.Enabled = true;
        btnNuevo.Enabled = false;
        btnGenerar.Enabled = true;
        btnCancelar.Enabled = true;
        txtEstado.Text = "Pendiente";
    }
    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        //List<SFRRMBEN09> list = new List<SFRRMBEN09>();
        //list = lSFRRMBEN09.obtenerRegistros(null);
        //dgvStock.DataSource = list;
        //dgvStock.DataBind();
    }

    private void CargarGrillaAlma()
    {
        List<SFRRMBEN01> listAlm = new List<SFRRMBEN01>();
        listAlm = lSFRRMBEN01.obtenerRegistros(null);
        dgvAlmacen.DataSource = listAlm;
        dgvAlmacen.DataBind();
    }

    #endregion "Metodos_Fin"
    protected void btnGenerar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMBEN09.stk_codIde = Convert.ToInt32(txtCodigo.Text);
            eSFRRMBEN09.CodAlmacen = cod_Alma;
            eSFRRMBEN09.Bie_Codigo = txtDescripcion.Text ;
            //string txtCodigo.Text = lSFRRMBEN09.insertarRegistro(eSFRRMBEN09);
        }
        else
        {
            //eSFRRMBEN09.stk_codIde = Convert.ToInt32(txtCodigo.Text);
            //eSFRRMBEN09.CodAlmacen = txtAlmacen.Text;
            //eSFRRMBEN09.Bie_Codigo = txtDescripcion.Text;
            ////lSFRRMBEN09.actualizarRegistro(eSFRRMBEN09);

        }
        //CargarGrilla();

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnBuscarStock.Disabled = false;
        txtCodigo.Enabled = false;
        txtAlmacen.Enabled = false;
        txtDescripcion.Enabled = false;
        btnNuevo.Enabled = true;
        btnGenerar.Enabled = false;
        txtCodigo.Text = txtAlmacen.Text = txtDescripcion.Text = txtEstado.Text = String.Empty;
    
    }
    protected void dgvAlmacen_SelectedIndexChanged(object sender, EventArgs e)
    {
        cod_Alma = this.dgvAlmacen.SelectedRow.Cells[0].Text;
        txtAlmacen.Text = cod_Alma+ this.dgvAlmacen.SelectedRow.Cells[1].Text;
        txtAlmacen.Enabled = false;
    }

    protected void dgvAlmacen_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvAlmacen, "select$" + e.Row.RowIndex.ToString()));
        }
        
    }
    protected void dgvStock_SelectedIndexChanged(object sender, EventArgs e)
    {
        cod_Alma = this.dgvStock.SelectedRow.Cells[1].Text;

        txtCodigo.Text = this.dgvStock.SelectedRow.Cells[0].Text;

        txtCodigo.Enabled = false;
        txtAlmacen.Enabled = true;
        txtAlmacen.Text = this.dgvStock.SelectedRow.Cells[1].Text;
        if (this.dgvStock.SelectedRow.Cells[4].Text == "1")
        {
            txtEstado.Text = "Registrado";
        }

        btnNuevo.Enabled = false;
        btnGenerar.Enabled = true;
    }
    protected void dgvStock_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvStock, "select$" + e.Row.RowIndex.ToString()));
        }
    }
}