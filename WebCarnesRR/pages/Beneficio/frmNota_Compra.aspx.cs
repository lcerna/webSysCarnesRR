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
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

public partial class pages_Beneficio_frmNota_Compra : System.Web.UI.Page
{
    #region "Variables"

    //aLMACEN
    SFRRMBEN01 eSFRRMBEN01 = new SFRRMBEN01();
    SFRRMBEN01BL lSFRRMBEN01 = new SFRRMBEN01BL();
    //
    SFRRMADM05 eSFRRMADM05 = new SFRRMADM05();
    SFRRMADM05BL lSFRRMADM05 = new SFRRMADM05BL();
    //Nota Compra Cabecera
    SFRRMCOM03 eSFRRMBEN14 = new SFRRMCOM03();
    SFRRMCOM03BL lSFRRMBEN14 = new SFRRMCOM03BL();
    //Nota de Compra Detalle
    SFRRMCOM04 eSFRRMBEN15 = new SFRRMCOM04();
    SFRRMCOM04BL lSFRRMBEN15 = new SFRRMCOM04BL();
    //Piezas
    SFRRMCOM05 eSFRRMBEN16 = new SFRRMCOM05();
    SFRRMCOM05BL lSFRRMBEN16 = new SFRRMCOM05BL();
    //peoveedor
    SFRRMCOM10 eSFRRMBEN21 = new SFRRMCOM10();
    SFRRMCOM10_List eSFRRMBEN21_ = new SFRRMCOM10_List();
    SFRRMCOM10BL lSFRRMBEN21 = new SFRRMCOM10BL();

    //Movimiento Cabecera
    SFRRMBEN05 eSFRRMBEN05 = new SFRRMBEN05();
    SFRRMBEN05BL lSFRRMBEN05 = new SFRRMBEN05BL();

    //Movimeinto Detalle
    SFRRMBEN06 eSFRRMBEN06 = new SFRRMBEN06();
    SFRRMBEN06BL lSFRRMBEN06BL = new SFRRMBEN06BL();

    #endregion "Variables"

    #region "Eventos"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtCodigo.Text = "";
            txtFecha.Text = DateTime.Now.ToString();
            txtEstado.Text = "";
            txtNombrePro.Text = "";
            txtGlosa.Text = "";
            txtFecCie.Text = DateTime.Now.ToString("dd/MM/yyyy").Replace(' ', 'T');
            ViewState["Accion"] = string.Empty;
            ViewState["CodProv"] = string.Empty;
            txtSubTotal.Enabled = false;
            txtIgv.Enabled = false;
            txtTotal.Enabled = false;
            btnAgregar.Disabled = true;
            btnImportar.Disabled = true;
            btnAgregaProv.Disabled = true;
            btnBuscaProvee.Disabled = true;
            chkIgv.Enabled = false;
            dbrAlmacen.Enabled = false;
            btnCancelarNC.Enabled = false;
            //List<SFRRMBEN16_List> oList = lSFRRMBEN16.ListarRegistros(null);
            List<SFRRMCOM05_List> oList = new List<SFRRMCOM05_List>();
            SFRRMCOM05_List eSFRRMBEN16_L = new SFRRMCOM05_List();
            eSFRRMBEN16_L.Bie_Codigo = "0001";
            eSFRRMBEN16_L.Bie_Nombre = "pieza1";
            oList.Add(eSFRRMBEN16_L);
            dgvPieza.DataSource = oList;
            dgvPieza.DataBind();
            //List<SFRRMBEN21_List> lpROVEE = lSFRRMBEN21.ListarRegistros(null);
            List<SFRRMCOM10_List> lpROVEE = new List<SFRRMCOM10_List>();
            SFRRMCOM10_List SFRRMBEN21_List = new SFRRMCOM10_List();
            SFRRMBEN21_List.Prov_Codigo = "0001";
            SFRRMBEN21_List.Prov_Nombre = "real carnes rr";
            SFRRMBEN21_List.Prov_NumDoc = "45594329544";
            lpROVEE.Add(SFRRMBEN21_List);
            dgvProveedor.DataSource = lpROVEE;
            dgvProveedor.DataBind();
            List<SFRRMBEN01> ListAlma = new List<SFRRMBEN01>();
            ListAlma.Add(new SFRRMBEN01() { CodAlmacen = "0", DscAlmacen = "Seleccione" });
            dbrAlmacen.DataSource = ListAlma;
            dbrAlmacen.DataBind();
        }
        CargarGrilla();
    }

    protected void dgvNotCompra_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvNotCompra, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvNotCompra_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigo.Text = this.dgvNotCompra.SelectedRow.Cells[0].Text;
        txtNombrePro.Text = this.dgvNotCompra.SelectedRow.Cells[2].Text;
    }

    protected void btnNuevoNC_Click(object sender, EventArgs e)
    {
        List<SFRRMBEN01> ListAlma = new List<SFRRMBEN01>();
       
        SFRRMBEN01 sSFRRMBEN01 = new SFRRMBEN01();
        ListAlma = lSFRRMBEN01.obtenerRegistros(null);
        sSFRRMBEN01.CodAlmacen = "0001";
        sSFRRMBEN01.DscAlmacen = "Principal";
        sSFRRMBEN01.TipAlmacen = "1";
        ListAlma.Add(sSFRRMBEN01);
        ListAlma.Add(new SFRRMBEN01() { CodAlmacen = "0", DscAlmacen = "Seleccione" });
        dbrAlmacen.DataSource = ListAlma;
        dbrAlmacen.DataBind();
        txtFecha.Text = System.DateTime.Today.ToShortDateString();
        txtFecha.Enabled = true;
        txtEstado.Text = "Registrado";
        txtNombrePro.Enabled = false;
        btnBuscaProvee.Disabled = false;
        btnBuscar.Disabled = true;
        dbrMoneda.Enabled = true;
        txtTipoC.Enabled = false;
        txtFecCie.Enabled = true;
        txtGlosa.Enabled = true;
        chkIgv.Enabled = true;        
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        txtFecCie.Text = System.DateTime.Today.ToShortDateString();
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        btnNuevoNC.Enabled = false;
        btnCancelarNC.Enabled = true;
        btnGuardarNC.Enabled = true;
        dbrAlmacen.Enabled = true;
    }

    protected void btnGuardarNC_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCodigo.Text))
        {
            eSFRRMBEN14.NotCom_Id = txtCodigo.Text;
            eSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(txtFecha.Text);
            eSFRRMBEN14.Ped_Codigo = "";
            eSFRRMBEN14.Requerido = "";
            eSFRRMBEN14.CDestino = dbrAlmacen.SelectedValue;
            eSFRRMBEN14.Tcambio = Convert.ToDecimal("3.261");
            if (chkIgv.Checked == true)
            {
                eSFRRMBEN14.Incluye_Igv = 1;
            }
            else
            {
                eSFRRMBEN14.Incluye_Igv = 0;
            }
            eSFRRMBEN14.Moneda = Convert.ToInt32(dbrMoneda.SelectedValue);
            eSFRRMBEN14.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            eSFRRMBEN14.Igv = Convert.ToDecimal(txtIgv.Text);
            eSFRRMBEN14.Monto = Convert.ToDecimal(txtTotal.Text);
            eSFRRMBEN14.Observacion = txtGlosa.Text;

            txtCodigo.Text = lSFRRMBEN01.insertarRegistro(eSFRRMBEN01);
            btnEliminarNC.Enabled = true;
        }
        else
        {
            eSFRRMBEN14.NotCom_Id = txtCodigo.Text;
            eSFRRMBEN14.Not_Com_Fecha = Convert.ToDateTime(txtFecha.Text);
            eSFRRMBEN14.Ped_Codigo = "";
            eSFRRMBEN14.Requerido = "";
            eSFRRMBEN14.CDestino = dbrAlmacen.SelectedValue;
            eSFRRMBEN14.Tcambio = Convert.ToDecimal("3.261");
            if (chkIgv.Checked == true)
            {
                eSFRRMBEN14.Incluye_Igv = 1;
            }
            else
            {
                eSFRRMBEN14.Incluye_Igv = 0;
            }
            eSFRRMBEN14.Moneda = Convert.ToInt32(dbrMoneda.SelectedValue);
            eSFRRMBEN14.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            eSFRRMBEN14.Igv = Convert.ToDecimal(txtIgv.Text);
            eSFRRMBEN14.Monto = Convert.ToDecimal(txtTotal.Text);
            eSFRRMBEN14.Observacion = txtGlosa.Text;
            lSFRRMBEN14.actualizarRegistro(eSFRRMBEN14);

        }
        btnGuardarNC.Text = "Cerrar_NC";
        Message();
        CargarGrilla();
        
        if (btnGuardarNC.Text == "Cerrar_NC")
        {
            eSFRRMBEN05.NroMovimiento = "";
            eSFRRMBEN05.Fecha = Convert.ToDateTime(DateTime.Now.ToString());
            eSFRRMBEN05.Prov_Codigo = ViewState["CodProv"].ToString();
            eSFRRMBEN05.TipOper = "1";
            eSFRRMBEN05.Observacion = "Ingreso desde Nota de Compra" + txtCodigo.Text;
            eSFRRMBEN05.CDocumento = "NC-" + txtCodigo.Text;
            eSFRRMBEN05.Destino = dbrAlmacen.SelectedValue;
            eSFRRMBEN05.CodAlmacen = dbrAlmacen.SelectedValue;
            eSFRRMBEN05.Moneda = dbrMoneda.SelectedValue;
            if (chkIgv.Checked == true)
            {
                eSFRRMBEN05.IncluyeIGV = "1";
            }
            else
            {
                eSFRRMBEN05.IncluyeIGV = "0";
            }
            eSFRRMBEN05.FecDocumento = Convert.ToDateTime(txtFecha.Text); ;
            eSFRRMBEN05.Semana = Convert.ToDecimal(DateTime.Today.Day.ToString());
            eSFRRMBEN05.Total = Convert.ToDecimal(txtTotal.Text);
            lSFRRMBEN05.insertarRegistro(eSFRRMBEN05);


            int i = 0;
            //foreach (var i in Entidad)
            //{

            //}

            btnGuardarNC.Enabled = false;
            Message();
        }

        
    }

    protected void btnEliminarNC_Click(object sender, EventArgs e)
    {
        //eSFRRMBEN14.NotCom_Id = txtCodigo.Text ;
        //lSFRRMBEN14.eliminarRegistro(eSFRRMBEN14.NotCom_Id);
        txtFecha.Text = System.DateTime.Today.ToShortDateString();
        txtFecha.Enabled = true;
        txtEstado.Text = "Registrado";
        txtNombrePro.Enabled = false;
        btnBuscaProvee.Disabled = false;
        btnBuscar.Disabled = true;
        dbrMoneda.Enabled = true;
        txtTipoC.Enabled = false;
        txtFecCie.Enabled = true;
        txtGlosa.Enabled = true;
        chkIgv.Enabled = true;
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        txtFecCie.Text = System.DateTime.Today.ToShortDateString();
        txtSubTotal.Text = "0.00";
        txtIgv.Text = "0.00";
        txtTotal.Text = "0.00";
        btnNuevoNC.Enabled = false;
        btnCancelarNC.Enabled = true;
        btnGuardarNC.Enabled = true;
        dbrAlmacen.Enabled = true;

    }

    protected void btnCancelarNC_Click(object sender, EventArgs e)
    {
        btnNuevoNC.Enabled = true;
        btnCancelarNC.Enabled = false;
        btnGuardarNC.Enabled = false;
        txtGlosa.Enabled = false;
        dbrMoneda.Enabled = false;
        txtFecCie.Enabled = false;
        txtFecha.Enabled = false;
        btnBuscaProvee.Disabled = true;
        btnBuscar.Disabled = false;
        List<SFRRMBEN01> ListAlma = new List<SFRRMBEN01>();
        ListAlma.Add(new SFRRMBEN01() { CodAlmacen = "0", DscAlmacen = "Seleccione" });
        dbrAlmacen.DataSource = ListAlma;
        dbrAlmacen.DataBind();
    }

    protected void gdrDetalle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(gdrDetalle, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void gdrDetalle_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    protected void dgvPieza_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvPieza, "select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void dgvPieza_SelectedIndexChanged(object sender, EventArgs e)
    {
        SFRRMCOM04 Entidad = new SFRRMCOM04();
        //lSFRRMBEN16.obtenerRegistro(this.dgvPieza.SelectedRow.Cells[0].Text.ToString().Trim());
    }

    protected void btnImportar_Click(object sender, EventArgs e)
    {
        /*  try
          {
              if (FlUploadcsv.HasFile)
           {
          OleDbConnection OleDbcon;
          OleDbCommand cmd = new OleDbCommand(); ;
          OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
          DataSet ds = new DataSet();
          DataTable dtExcelData = new DataTable();

          string FileName = FlUploadcsv.FileName;
          string filePath = "C:\\Users\\admin\\Desktop\\Sheet1.xlsx";
          string path = filePath;// string.Concat(Server.MapPath("~/Document/" + FlUploadcsv.FileName));

          FlUploadcsv.PostedFile.SaveAs(path);

          if (Path.GetExtension(path) == ".xls")
          {
              OleDbcon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "; Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
          }
          else if (Path.GetExtension(path) == ".xlsx")
          {
              OleDbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
          }

          OleDbcon.Open();
          cmd.Connection = OleDbcon;
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = "SELECT * FROM [Sheet1$]";
          objAdapter1 = new OleDbDataAdapter(cmd);
          objAdapter1.Fill(ds);
          dtExcelData = ds.Tables[0];

          string consString = "Your Sql Connection string";

          using (SqlConnection con = new SqlConnection(consString))
          {
              using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
              {
                  //Set the database table name
                  sqlBulkCopy.DestinationTableName = "SqlDatabase Table name where you want insert data";

                  sqlBulkCopy.ColumnMappings.Add(".xls/.xlsx Header column name(Id)", "Your database table column(IndexId)");
                  con.Open();
                  sqlBulkCopy.WriteToServer(dtExcelData);
                  con.Close();
                      }
                  }
              }
                      }
              catch (Exception ex)
              { }*/
    }

    protected void dgvProveedor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.style.cursor='pointer'");
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(dgvProveedor, "select$" + e.Row.RowIndex.ToString()));
        }
    }
    protected void dgvProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["CodProv"] = this.dgvProveedor.SelectedRow.Cells[0].Text;
        txtNombrePro.Text = this.dgvProveedor.SelectedRow.Cells[0].Text + " - " + this.dgvProveedor.SelectedRow.Cells[2].Text;
    }


    #endregion "Eventos"

    #region "Metodo"

    private void CargarGrilla()
    {
        List<SFRRMCOM03> lNotCompra = new List<SFRRMCOM03>();
        //lNotCompra = lSFRRMBEN14.obtenerRegistros(null);
        SFRRMCOM03 sSFRRMBEN14 = new SFRRMCOM03();
        sSFRRMBEN14.NotCom_Id ="0001";
	    sSFRRMBEN14.Not_Com_Fecha =Convert.ToDateTime("10/02/2017");
	    sSFRRMBEN14.Ped_Codigo="";
	    sSFRRMBEN14.Requerido="";
	    sSFRRMBEN14.CDestino="";
	    sSFRRMBEN14.Tcambio=Convert.ToDecimal("3.26");
	    sSFRRMBEN14.Incluye_Igv=0;
	    sSFRRMBEN14.Moneda=1;
        sSFRRMBEN14.SubTotal = Convert.ToDecimal("300.26");
        sSFRRMBEN14.Igv = Convert.ToDecimal("30.26");
        sSFRRMBEN14.Monto = Convert.ToDecimal("330.26");
        sSFRRMBEN14.Observacion = "pruebas1";
        lNotCompra.Add(sSFRRMBEN14);
        dgvNotCompra.DataSource = lNotCompra;
        dgvNotCompra.DataBind();
    }

    private void Message()
    {
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", string.Format("alert('{0}');", "Se grabó satisfactoriamente."), true);
    }

    #endregion    
    


}