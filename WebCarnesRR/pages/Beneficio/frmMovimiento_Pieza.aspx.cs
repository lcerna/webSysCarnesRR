using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessEntities.SFRRMBEN;
using RCRR.BL.BusinessObjects.SFRRMBEN;

public partial class pages_Beneficio_frmMovimiento_Bien : System.Web.UI.Page
{
    //SFRRMBEN05 - CABECERA DE MOVIMIENTO
    SFRRMBEN05 eSFRRMBEN05 = new SFRRMBEN05();
    SFRRMBEN05BL lSFRRMBEN05 = new SFRRMBEN05BL();

    //SFRRMBEN06 DETALLE DE MOVIMEINTO
    SFRRMBEN06 eSFRRMBEN06 = new SFRRMBEN06();
    SFRRMBEN06BL lSFRRMBEN06 = new SFRRMBEN06BL();

    //ALMACEN
    SFRRMBEN01 eSFRRMBEN01 = new SFRRMBEN01();
    SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtFecha.Text = "";
            txtEstado.Text = "";
            txtAlmacenOrigen.Text = "";
            txtAlmacenDestino.Text = "";
            txtNomProv.Text = "";
            txtNumDoC.Text = "";
            txtFechaDoc.Text = "";
            dbrTipoOpera.SelectedValue = "0";
            dbrMotivo.SelectedValue = "0";
            dbrMoneda.SelectedValue = "0";
        }
        //CargarGrilla();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        btnAlmacenO.Disabled = false;
        btnAlmacenD.Disabled = false;
        btnProv.Disabled = false;
        btnNumDoc.Disabled = false;
        txtFecha.Enabled = true;
        txtFecha.Text = DateTime.Today.ToString("dd-MM-yyyy");
        dbrTipoOpera.Enabled = true;
        dbrMotivo.Enabled = true;
        dbrMoneda.Enabled = true;
       dvrTipoDoc.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = false;
        btnGuardar.Enabled = true;
        btnGuardar.Text = "Guardar";
        btnCancelar.Enabled = true;

    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {

    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }

    //public CargarGrilla()
    //{

    //}
}