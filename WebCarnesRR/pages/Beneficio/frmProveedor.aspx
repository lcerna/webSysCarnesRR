<%@ Page Title="Real Carnes || Proveedor" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmProveedor.aspx.cs" Inherits="pages_Proveedor" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <script type="text/javascript">
         function Validar() {
             var sNombre = document.getElementById('ContentPlaceHolder2_txtNombre').value;
             if (sNombre.trim() == "") {
                 alert('Ingrese Nombre.');
                 return false;
             }
             var sEmail = document.getElementById('ContentPlaceHolder2_txtemail').value;
             if (sEmail.trim() == "") {
                 alert('Ingrese Email.');
                 return false;
             }

             var sDireccion = document.getElementById('ContentPlaceHolder2_txtDirec').value;
             if (sDireccion.trim() == "") {
                 alert('Ingrese Dirección.');
                 return false;
             }

             var sTipoDoc = document.getElementById('ContentPlaceHolder2_cmbTipDoc').value;
             if (sTipoDoc.trim() == "0") {
                 alert('Seleccione Tipo Documento.');
                 return false;
             }

             var sTipoTel = document.getElementById('ContentPlaceHolder2_cmbTipTel').value;
             if (sTipoTel.trim() == "0") {
                 alert('Seleccione Tipo Telefono.');
                 return false;
             }

             var sDepart = document.getElementById('ContentPlaceHolder2_cmbDepa').value;
             if (sDepart.trim() == "0") {
                 alert('Seleccione Departamento.');
                 return false;
             }

             var sProvincia = document.getElementById('ContentPlaceHolder2_cmbProv').value;
             if (sProvincia.trim() == "0") {
                 alert('Seleccione Provincia.');
                 return false;
             }

             var sDistrito = document.getElementById('ContentPlaceHolder2_cmbDist').value;
             if (sDistrito.trim() == "0") {
                 alert('Seleccione Distrito.');
                 return false;
             }
           
             return true;
         }
    </script>  
    <title>ERP Odonto | Proveedor</title>
    <style>
        .example-modal .modal {
            position: relative;
            top: auto;
            bottom: auto;
            right: auto;
            left: auto;
            display: block;
            z-index: 1;
        }

        .example-modal .modal {
            background: transparent !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <h1>Proveedor</h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li><a href="#">Almacen</a></li>
            <li class="#">Mantenimiento</li>
            <li class="active">Proveedor</li>
        </ol>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-primary">
        <br />

            <div class="box-body">
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button id="btnBusProvee" runat="server" type="button" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-default"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false" MaxLength="200"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Tipo Doc.:" Enabled="false"></asp:Label>
                            <asp:DropDownList ID="cmbTipDoc" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true" AutoPostBack="true" OnSelectedIndexChanged="cmbTipDoc_SelectedIndexChanged">
                                <asp:ListItem Value="1">DNI</asp:ListItem>
                                <asp:ListItem Value="2">RUC</asp:ListItem>
                                <asp:ListItem Selected="True" Value="0">--SELECCIONE--</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Numero Doc.:"></asp:Label>
                        <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" Enabled="false" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
                        <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Tipo Telf.:" Enabled="false"></asp:Label>
                            <asp:DropDownList ID="cmbTipTel" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="1">CELULAR</asp:ListItem>
                                <asp:ListItem Value="2">FIJO</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Numero Telf.:"></asp:Label>
                        <asp:TextBox ID="txtNumTelf" runat="server" CssClass="form-control" Enabled="false" MaxLength="9"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label9" runat="server" Text="Direccion:"></asp:Label>
                        <asp:TextBox ID="txtDirec" runat="server" CssClass="form-control" Enabled="false" MaxLength="200"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Departamento:"></asp:Label>
                            <asp:DropDownList ID="cmbDepa" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="1">LIMA</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="Label11" runat="server" Text="Provincia:"></asp:Label>
                            <asp:DropDownList ID="cmbProv" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="51">LIMA</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="Label12" runat="server" Text="Distrito:"></asp:Label>
                            <asp:DropDownList ID="cmbDist" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELEECIONE--</asp:ListItem>
                                <asp:ListItem Value="1">LIMA</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label13" runat="server" Text="Observacion:"></asp:Label>
                        <asp:TextBox ID="txtObser" runat="server" Height="50px" CssClass="form-control" TextMode="MultiLine" Enabled="false" MaxLength="200"></asp:TextBox>
                    </div>

                    <div class="col-xs-5">
                        <asp:Label ID="Label14" runat="server" Text="Contacto:"></asp:Label>
                        <asp:TextBox ID="txtCont" runat="server" CssClass="form-control" Enabled="false" MaxLength="200"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevo_Click" />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClick="btnGuardar_Click"   OnClientClick="return Validar();" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary " Enabled="False" OnClick="btnEliminar_Click"  />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"  />

                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.box-body -->
        </div>

        <div class="modal fade" id="modal-default">
            <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button id="Button1" type="button" runat="server" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Seleccionar Proveedo</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">
                    <asp:GridView ID="dgvProveedor" runat="server" DataKeyNames="Prov_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvProveedor_RowDataBound" OnSelectedIndexChanged="dgvProveedor_SelectedIndexChanged" > <%--OnPageIndexChanging="dgvAlmacenes_PageIndexChanging" PageSize="5" AllowPaging="true" AllowSorting="true" >--%>
                         
                    </asp:GridView>

                </div>
                  </div>                
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
    </div>
</asp:Content>


