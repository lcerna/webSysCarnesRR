using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RCRR.BL.BusinessObjects.SFRRMADM;
using RCRR.DA.DataAccessObjects.SFRRMADM;
using System.Net;
using System.Data;
using System.IO;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnIngresar_Click1(object sender, EventArgs e)
    {
        //if (SFRRMADM01DA.LOGEAR_USUARIO(txtUsuario.Text, txtContraseña.Text) > 0)
        //{
            Response.Redirect("~/Inicio.aspx");
        //}
        //else
        //{
          //  Server.Transfer("Default.aspx");
        //}
    }

    
}