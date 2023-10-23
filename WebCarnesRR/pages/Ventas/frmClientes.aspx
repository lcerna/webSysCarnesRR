<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmClientes.aspx.cs" Inherits="pages_Ventas_Cliente" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Validar() {
            var sNombre = document.getElementById('ContentPlaceHolder2_txtNombre').value;
            if (sNombre.trim() == "") {
                alert('Ingrese Nombre.');
                return false;
            }

            var sTipoDoc = document.getElementById('ContentPlaceHolder2_cmbTipDoc').value;
            if (sTipoDoc.trim() == "0") {
                alert('Seleccione Tipo Documento.');
                return false;
            }
           
            var sNumDoc = document.getElementById('ContentPlaceHolder2_txtNumDoc').value;
            if (sNumDoc.trim() == "") {
                alert('Ingrese Numero Documento.');
                return false;
            }
            
            var sEMail = document.getElementById('ContentPlaceHolder2_txtEmail').value;
            if (sEMail.trim() == "") {
                alert('Ingrese EMail.');
                return false;
            }

            var sTipoTel = document.getElementById('ContentPlaceHolder2_dblTipTelf').value;
            if (sTipoTel.trim() == "0") {
                alert('Seleccione Tipo Teléfono.');
                return false;
            }

            var sTipoTel = document.getElementById('ContentPlaceHolder2_txtNumTel').value;
            if (sTipoTel.trim() == "") {
                alert('Ingrese Número Teléfono.');
                return false;
            }

            var sTipoTel = document.getElementById('ContentPlaceHolder2_txtDirec').value;
            if (sTipoTel.trim() == "") {
                alert('Ingrese Dirección.');
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

            var sAlmacen = document.getElementById('ContentPlaceHolder2_txtAlmacen').value;
            if (sAlmacen.trim() == "") {
                alert('Seleccione Almacen.');
                return false;
            }
                        
            var sRango = document.getElementById('ContentPlaceHolder2_txtRango').value;
            if (sRango.trim() == "") {
                alert('Ingrese Rango Peso.');
                return false;
            }
            
            var sSexo = document.getElementById('ContentPlaceHolder2_txtSexoPor').value;
            if (sSexo.trim() == "") {
                alert('Ingrese Sexo.');
                return false;
            }
                
            return true;
        }
    </script>
    <title>Real Carnes RR | Cliente</title>
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
    <h1>Cliente</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Venta</a></li>
        <li class="#">Mantenimiento</li>
        <li class="active">Cliente</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-primary">
            <div class="box-header with-border">
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarCli" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Cliente"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Tipo Doc.:"></asp:Label>
                            <asp:DropDownList ID="cmbTipDoc" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="1">DNI</asp:ListItem>
                                <asp:ListItem Value="2">RUC</asp:ListItem>
                                <asp:ListItem Value="3">CARNET DE EXTRANJERIA</asp:ListItem>
                                <asp:ListItem Selected="True" Value="0">--SELECCIONE--</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Numero Doc.:"></asp:Label>
                        <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Tipo Telf.:"></asp:Label>
                            <asp:DropDownList ID="dblTipTelf" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="1">CELULAR</asp:ListItem>
                                <asp:ListItem Value="2">FIJO</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Numero Telf.:"></asp:Label>
                        <asp:TextBox ID="txtNumTel" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label9" runat="server" Text="Direccion:"></asp:Label>
                        <asp:TextBox ID="txtDirec" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Departamento:"></asp:Label>
                            <asp:DropDownList ID="cmbDepa" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="1">LIMA</asp:ListItem>                                
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label11" runat="server" Text="Provincia:"></asp:Label>
                            <asp:DropDownList ID="cmbProv" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true">
                                <asp:ListItem Value="0">--SELECCIONE--</asp:ListItem>
                                <asp:ListItem Value="51">LIMA</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
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
                <div class="col-xs-5">
                    <asp:Label ID="Label18" runat="server" Text="Almacen:"></asp:Label>
                    <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtAlmacen" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBusAlmacen" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Almacen"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label15" runat="server" Text="Preferecia Proveedor:"></asp:Label>
                       <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtPrefProv" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuPrv" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-PrefProv"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label16" runat="server" Text="Rango de Peso:"></asp:Label>
                        <asp:TextBox ID="txtRango" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label17" runat="server" Text="Sexo para Pieza:"></asp:Label>
                        <asp:TextBox ID="txtSexoPor" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                  <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label13" runat="server" Text="Observacion:"></asp:Label>
                        <asp:TextBox ID="txtObserva" runat="server" CssClass="form-control" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-xs-5">
                        <asp:Label ID="Label14" runat="server" Text="Contacto:"></asp:Label>
                        <asp:TextBox ID="txtXContac" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevo_Click" />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClientClick="return Validar();" OnClick="btnGuardar_Click" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary " Enabled="False" OnClick="btnEliminar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" Enabled="false" />

                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.box-body -->
        </div>
        <div class="modal fade" id="modal-PrefProv">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button id="Button3" type="button" runat="server" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Seleccionar Proveedor</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">                    
                     <asp:GridView ID="grvProveedor" runat="server" DataKeyNames="Prov_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="grvProveedor_RowDataBound" OnSelectedIndexChanged="grvProveedor_SelectedIndexChanged"> <%--OnPageIndexChanging="dgvAlmacenes_PageIndexChanging" PageSize="5" AllowPaging="true" AllowSorting="true" >--%>                         
                    </asp:GridView>
       
            </div>
              </div>
              <div class="modal-footer">                    
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>        
        <!-- /.modal -->
         <div class="modal fade" id="modal-Cliente">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button id="Button2" type="button" runat="server" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Seleccionar Cliente</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">                    
                     <asp:GridView ID="grvCliente" runat="server" DataKeyNames="Cli_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="grvCliente_RowDataBound" OnSelectedIndexChanged="grvCliente_SelectedIndexChanged"> <%--OnPageIndexChanging="dgvAlmacenes_PageIndexChanging" PageSize="5" AllowPaging="true" AllowSorting="true" >--%>                         
                    </asp:GridView>
       
            </div>
              </div>
              <div class="modal-footer">                    
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
          <div class="modal fade" id="modal-Almacen">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button id="Button1" type="button" runat="server" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Seleccionar Almacen</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">
                    <asp:HiddenField runat="server" ID="hf_control" />
                    
                     <asp:GridView ID="grvAlmacen" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="grvAlmacen_RowDataBound" OnSelectedIndexChanged="grvAlmacen_SelectedIndexChanged">
                         
                    </asp:GridView>
       
            </div>
              </div>
              <div class="modal-footer">                    
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
    </div>

</asp:Content>

