using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMADM;
using RCRR.BL.BusinessEntities.SFRRMADM;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;


public partial class pages_Beneficio_Proveedor : System.Web.UI.Page
{
    #region "Variables"

    //aLMACEN
    SFRRMADM02 eSFRRMADM02 = new SFRRMADM02();
    SFRRMADM02BL lSFRRMADM02 = new SFRRMADM02BL();

    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          //  CargarCombos();
        }
    }

    private void CargarCombos()
    {
        //Almacenes
        List<SFRRMADM02> ListTipUsu = new List<SFRRMADM02>();
        ListTipUsu = lSFRRMADM02.obtenerRegistros_V2();
        cmbTipUsu.DataSource = ListTipUsu;
        cmbTipUsu.DataBind();
    }

    protected void btnNuevoNC_Click(object sender, EventArgs e)
    {
        CargarCombos();
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        cmbTipUsu.Enabled = true;
        btnGuardar2.Enabled = true;
        btnEliminar2.Enabled = true;
    }


    protected void btnGuardar2_Click(object sender, EventArgs e)
    {

    }
}