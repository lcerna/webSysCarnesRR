using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessObjects.SFRRMBEN;

using RCRR.BL.BusinessEntities.SFRRMCOM;
using RCRR.BL.BusinessObjects.SFRRMCOM;


public partial class pages_Beneficio_frmPiezas : System.Web.UI.Page
{
    #region "Variables_Ini"

    //Tipo de Corte
    SFRRMCOM08 eSFRRMBEN19 = new SFRRMCOM08();
    SFRRMCOM08BL lSFRRMBEN19 = new SFRRMCOM08BL();

    //Unidad de Medida
    SFRRMCOM06 eSFRRMBEN17 = new SFRRMCOM06();
    SFRRMCOM06BL lSFRRMBEN17 = new SFRRMCOM06BL();

    //Piezas
    SFRRMCOM05 eSFRRMBEN16 = new SFRRMCOM05();
    SFRRMCOM05BL lSFRRMBEN16 = new SFRRMCOM05BL();
    #endregion "Variables_Fin"

    #region "Eventos_Ini"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = ""; 
            txtCapacidad.Text="";
            txtObservaciones.Text = "";
            dboUnidadMedida.Enabled = false;
            txtCodigo.Enabled = false;
            txtEstado.Enabled = false;
            txtNombre.Enabled = false;
            txtCapacidad.Enabled = false;
            txtObservaciones.Enabled = false;
            btnCancelar.Enabled = false;
            CargarCombos();
        }
        CargarGrilla();
    }
    
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnbusPieza.Disabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = true;
        txtObservaciones.Enabled = true;
        txtCapacidad.Enabled = true;
        btnProvee.Disabled = false;
        dboUnidadMedida.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnCancelar.Enabled = true;
        CargarCombos();
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
             eSFRRMBEN16.Bie_Codigo = txtCodigo.Text;
             eSFRRMBEN16.Bie_Nombre = txtNombre.Text;
             eSFRRMBEN16.Bie_Estado ="1";
             eSFRRMBEN16.Bie_Observaciones = txtObservaciones.Text;
             eSFRRMBEN16.Capacidad = txtCapacidad.Text;
             eSFRRMBEN16.Unidades = 1;
             eSFRRMBEN16.Umd_Codigo = dboUnidadMedida.SelectedValue;
             txtCodigo.Text = lSFRRMBEN16.insertarRegistro(eSFRRMBEN16);
        }
       else
        {
            eSFRRMBEN16.Bie_Codigo = txtCodigo.Text;
            eSFRRMBEN16.Bie_Nombre = txtNombre.Text;
            eSFRRMBEN16.Bie_Estado = "1";
            eSFRRMBEN16.Bie_Observaciones = txtObservaciones.Text;
            eSFRRMBEN16.Capacidad = txtCapacidad.Text;
            eSFRRMBEN16.Unidades = 1;
            eSFRRMBEN16.Umd_Codigo = dboUnidadMedida.SelectedValue;
            lSFRRMBEN16.actualizarRegistro(eSFRRMBEN16);
        }

        txtEstado.Text = "Registrado";
        btnGuardar.Text = "Actualizar";
        btnEliminar.Enabled = true;
        btnCancelar.Enabled = true;
        Message();
        CargarGrilla();    
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        lSFRRMBEN16.eliminarRegistro(txtCodigo.Text.Trim());
        txtCodigo.Text = txtEstado.Text = txtNombre.Text = txtCapacidad.Text = txtObservaciones.Text = String.Empty;
    
        dboUnidadMedida.SelectedValue = "0";
        btnbusPieza.Disabled = false;
        btnGuardar.Enabled = btnEliminar.Enabled = btnCancelar.Enabled = false;
        btnNuevo.Enabled = true;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtCapacidad.Enabled = false;
        txtObservaciones.Enabled = false;
       
        dboUnidadMedida.Enabled = false;
        CargarGrilla();
    }
    
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnbusPieza.Disabled = false;
        txtCodigo.Enabled = false;
        txtEstado.Enabled = false;
        txtNombre.Enabled = false;
        txtCapacidad.Enabled = false;
        txtObservaciones.Enabled = false;
        btnProvee.Disabled = true;
        dboUnidadMedida.Enabled = false;
        btnNuevo.Enabled = true;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = false;
        txtCodigo.Text = txtEstado.Text = txtNombre.Text = txtCapacidad.Text = txtObservaciones.Text = String.Empty;
        btnCancelar.Enabled = false;

        dboUnidadMedida.SelectedValue = "0";
        btnGuardar.Text = "Guardar";
    }

    protected void dgvPiezas_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarCombos();

        SFRRMCOM05 ENTIDAD = new SFRRMCOM05();

        SFRRMCOM05BL lSFRRMBEN16 = new SFRRMCOM05BL();
        ENTIDAD = lSFRRMBEN16.obtenerRegistro(this.dgvPiezas.SelectedRow.Cells[0].Text.Trim());
        txtCodigo.Text = ENTIDAD.Bie_Codigo;
        txtCodigo.Enabled = false;
        txtNombre.Enabled = true;
        txtNombre.Text = ENTIDAD.Bie_Nombre;
        if (ENTIDAD.Bie_Estado == "1")
        {
            txtEstado.Text = "Registrado";
            txtEstado.Enabled = false;
        }
        txtCapacidad.Text = ENTIDAD.Capacidad;
        txtCapacidad.Enabled = true;
        txtObservaciones.Text = ENTIDAD.Bie_Observaciones;
        txtObservaciones.Enabled = true;
        dboUnidadMedida.SelectedValue = ENTIDAD.Umd_Codigo;
        dboUnidadMedida.Enabled = true;
        btnNuevo.Enabled = false;
        btnGuardar.Enabled = true;
        btnEliminar.Enabled = true;
        btnGuardar.Text = "Actualizar";
        btnCancelar.Enabled = true;
    }
    
    protected void dgvPiezas_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvPiezas, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void grvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    #endregion "Eventos_Fin"

    #region "Metodos_Ini"

    private void CargarGrilla()
    {
        List<SFRRMCOM05_List> listPi = new List<SFRRMCOM05_List>();
        listPi = lSFRRMBEN16.ListarRegistros(null);
        dgvPiezas.DataSource = listPi;
        dgvPiezas.DataBind();
    }

    private void CargarCombos()
    {
        List<SFRRMCOM06> listUMD = new List<SFRRMCOM06>();
        listUMD = lSFRRMBEN17.obtenerRegistros(null);
        listUMD.Add(new SFRRMCOM06 { Cod_Udm = "0", Nombre = "SELECCIONE" });
        dboUnidadMedida.DataSource = listUMD.OrderBy(t => int.Parse(t.Cod_Udm)).ToList();
        dboUnidadMedida.DataBind();

    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion "Metodos_Fin"
    
}