using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMBEN;
using RCRR.BL.BusinessEntities.SFRRMBEN;

public partial class pages_Beneficio_Nota_Pedido : System.Web.UI.Page
{
    SFRRMBEN06 eSFRRMBEN08 = new SFRRMBEN06();
    SFRRMBEN06BL lSFRRMBEN08 = new SFRRMBEN06BL();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtCodigo.Text= "";
        txtEstado.Text = "";
        txtFecha.Text = "";


    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {

        txtFecha.Enabled = true;
            txtGlosa.Enabled = true;
        btnNuevo.Enabled = false;
        btnEliminar.Enabled = true;
        btnGuardar.Enabled = true;


    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {


    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {

    }
}