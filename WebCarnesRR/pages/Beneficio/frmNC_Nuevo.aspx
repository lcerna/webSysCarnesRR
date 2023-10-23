<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmNC_Nuevo.aspx.cs" Inherits="pages_Beneficio_frmNC_Nuevo" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Validar() {
            var sFecha = document.getElementById('ContentPlaceHolder2_txtFecha').value;
            if (sFecha.trim() == "dd/mm/aaaa") {
                alert('Ingrese Fecha de Nota de Venta.');
                return false;
            }
            var sNombrePro = document.getElementById('ContentPlaceHolder2_txtNombrePro').value;
            if (sNombrePro.trim() == "") {
                alert('Seleccione Proveedor.');
                return false;
            }
            var sFecCierre = document.getElementById('ContentPlaceHolder2_txtFecCie').value;
            if (sFecCierre.trim() == "dd/mm/aaaa") {
                alert('Ingrese Fecha de Cierre.');
                return false;
            }
            var sMoneda = document.getElementById('ContentPlaceHolder2_dbrMoneda').value;
            if (sMoneda.trim() == "0") {
                alert('Seleccione Tipo de Moneda');
                return false;
            }
            var sAlmacen = document.getElementById('ContentPlaceHolder2_dbrAlmacen').value;
            if (sAlmacen.trim() == "0") {
                alert('Seleccione Almacen');
                return false;
            }
            return true;
        }

        function ValidarDetalle() {
            var sPieza = document.getElementById('ContentPlaceHolder2_txtFamiliaPieza').value;
            if (sPieza.trim() == "") {
                alert('Seleccione Familia de Bien.');
                return false;
            }
            var sDes = document.getElementById('ContentPlaceHolder2_txtDescripcion').value;
            if (sDes.trim() == "") {
                alert('Ingrese Descripción.');
                return false;
            }
            var sPrecio = document.getElementById('ContentPlaceHolder2_txtPrecio').value;
            if (sPrecio.trim() == "") {
                alert('Ingrese Precio.');
                return false;
            }
            var sCantidad = document.getElementById('ContentPlaceHolder2_txtCantidad').value;
            if (sCantidad.trim() == "") {
                alert('Ingrese Cantidad.');
                return false;
            }
            return true;
        }

    </script>
    <title>Real Carnes RR | Almacen</title>
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

        .btn-group-lg {
            width: 121px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>NOTA DE COMPRA
        <small></small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Transacciones</li>
        <li class="active">Nota de Compra</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-header with-border">
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-default" id="btnBuscar" runat="server"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-3">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label9" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>

                </div>
                <br />
                <div class="row">
                    <div class="col-xs-8">
                        <asp:Label ID="Label3" runat="server" Text="Proveedor:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtNombrePro" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Proveedor" id="btnBuscaProvee" runat="server"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label5" runat="server" Text="Moneda:"></asp:Label>
                        <asp:DropDownList ID="dbrMoneda" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False">
                            <asp:ListItem Selected="True" Value="0">Seleccione</asp:ListItem>
                            <asp:ListItem Value="1">Soles</asp:ListItem>
                            <asp:ListItem Value="2">Dolares</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Tipo Cambio:"></asp:Label>
                        <asp:TextBox ID="txtTipoC" runat="server" CssClass="form-control" Enabled="False" Text="3.265" ></asp:TextBox>

                    </div>
                    <div class="col-xs-1"></div>
                    <div class="col-xs-2">
                        <div class="checkbox">
                            <asp:CheckBox ID="chkIgv" runat="server" Text="IGV" />
                        </div>
                    </div>

                    <div class="col-xs-3">
                        <asp:Label ID="Label12" runat="server" Text="Almacen:"></asp:Label>
                        <asp:DropDownList ID="dbrAlmacen" DataTextField="DscAlmacen" DataValueField="CodAlmacen" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="false" OnSelectedIndexChanged="dbrAlmacen_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label6" runat="server" Text="Fecha Cierre.:"></asp:Label>
                        <asp:TextBox ID="txtFecCie" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-8">
                        <div class="row">
                            <asp:Label ID="Label8" runat="server" Text="Observacion:"></asp:Label>
                            <asp:TextBox ID="txtGlosa" runat="server" CssClass="form-control" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="btn btn-group-justified">
                                    <div class="box-footer">
                                        <asp:Button ID="btnNuevoNC" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevoNC_Click" />
                                        <asp:Button ID="btnGuardarNC" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardarNC_Click" OnClientClick="return Validar();" />
                                        <asp:Button ID="btnEliminarNC" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminarNC_Click" />
                                        <asp:Button ID="btnCancelarNC" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelarNC_Click" />
                                        <asp:Button ID="btnCerrarNC" runat="server" Text="Cerrar" CssClass="btn btn-danger" OnClick="btnCerrarNC_Click" />
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label7" runat="server" Text="Sub Total:"></asp:Label>
                        <asp:TextBox ID="txtSubTotal" runat="server" CssClass="form-control" Text="0.00"></asp:TextBox>
                        <asp:Label ID="Label10" runat="server" Text="Igv:"></asp:Label>
                        <asp:TextBox ID="txtIgv" runat="server" CssClass="form-control" Text="0.00"></asp:TextBox>
                        <asp:Label ID="Label11" runat="server" Text="Total:"></asp:Label>
                        <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" Text="0.00"></asp:TextBox>
                    </div>
                </div>

                <div class="modal fade" id="modal-Proveedor">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h4 class="modal-title">Seleccionar Proveedor</h4>
                            </div>
                            <div class="modal-body">
                                <div class="box-body">

                                    <asp:GridView ID="drvProveedor" runat="server" DataKeyNames="Prov_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="drvProveedor_RowDataBound" OnSelectedIndexChanged="drvProveedor_SelectedIndexChanged">
                                    </asp:GridView>

                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                            </div>
                        </div>
                        <!-- /.modal-content -->
                    </div>
                    <!-- /.modal-dialog -->
                </div>
                <!-- /.modal -->
                <div class="modal fade" id="modal-default">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h4 class="modal-title">Seleccionar Nota de Compra</h4>
                            </div>
                            <div class="modal-body">
                                <div class="box-body">

                                    <asp:GridView ID="dgvNotCompra" runat="server" DataKeyNames="NotCom_Id" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvNotCompra_RowDataBound" OnSelectedIndexChanged="dgvNotCompra_SelectedIndexChanged">
                                    </asp:GridView>

                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                            </div>
                        </div>
                        <!-- /.modal-content -->
                    </div>
                    <!-- /.modal-dialog -->
                </div>
                <!-- /.modal -->


            </div>
        </div>
    </div>
    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Nota de Compra</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs ">
                        <li class="active"><a href="#tab_Detalle" data-toggle="tab">Piezas </a></li>
                        <li><a href="#tab_Proveed" data-toggle="tab">Proveedores Asociados </a></li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_Detalle">
                            <br />
                            <div class="row">
                                <div class="col-xs-1">
                                  <asp:Button ID="btnNuevoDet" runat="server" Text="Nuevo" CssClass=" btn btn-danger" Enabled="false" OnClick="btnNuevoDet_Click"/>
                                     </div>
                                 <div class="col-xs-1">
                                  <asp:Button ID="btnGuardarDet" runat="server" Text="Guardar" CssClass=" btn btn-danger" Enabled="false" OnClientClick="return ValidarDetalle();" OnClick="btnAgregarDet_Click"/>
                                     </div>
                                 <div class="col-xs-4">
                                    <asp:FileUpload ID="FileDetalle" runat="server" Width="400px" Enabled="false"/>
                                 </div>
                                 <div class="col-xs-1">
                                    <asp:Button ID="btnImportarDet" runat="server" Text="Importar" CssClass="btn btn-danger" Enabled="false" OnClick="btnImportar_Click" />
                                  </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-10">
                                    <div class="row">
                                        <div class="col-xs-2">
                                            <asp:Label ID="lblCodDetalle" runat="server" Text="Codigo:"></asp:Label>
                                            <asp:TextBox ID="txtCodDetalle" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row">
                                        <div class="col-xs-5">
                                            <asp:Label ID="Label13" runat="server" Text="Familia de Bienes:"></asp:Label>
                                            <div class="input-group input-group-sm">
                                                <asp:TextBox ID="txtFamiliaPieza" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                                <span class="input-group-btn">
                                                    <button type="button" id="btnPieza" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Pieza"><i class="fa fa-search"></i></button>
                                                </span>
                                            </div>

                                        </div>
                                        <div class="col-xs-1">
                                        </div>
                                        <div class="col-xs-2">
                                            <asp:Label ID="Label17" runat="server" Text="Precio:"></asp:Label>
                                            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                         <div class="col-xs-1">
                                        </div>
                                        <div class="col-xs-2">
                                            <asp:Label ID="Label14" runat="server" Text="Cantidad:"></asp:Label>
                                            <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xs-1">
                                </div>                               
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-10">
                                    <asp:GridView ID="gdrDetalle" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true" DataKeyNames="Bie_Codigo" OnRowDataBound="gdrDetalle_RowDataBound" OnSelectedIndexChanged="gdrDetalle_SelectedIndexChanged">
                                        <Columns>
                                            <asp:BoundField HeaderText="Items" DataField="CodId" />
                                            <asp:BoundField HeaderText="Codigo" DataField="Bie_Codigo" />
                                            <asp:BoundField HeaderText="Descripcion" DataField="DES_BIEN" />
                                            <asp:BoundField HeaderText="Cantidad" DataField="Cantidad"/>
                                            <asp:BoundField HeaderText="Precio" DataField="Precio"/>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="tab_Proveed">
                            <br />

                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-AgregarProve" id="btnAgregaProv" runat="server">Agregar</button>
                            </span>
                            <br />
                            <asp:GridView ID="dgvProveeNot" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeader="true">
                                <Columns>
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/alert-circled.png" DeleteText="" EditImageUrl="~/bower_components/Ionicons/png/512/coffee.png" EditText="" ShowEditButton="True" />
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/edit.png" DeleteText="" ShowDeleteButton="True" />
                                    <asp:BoundField HeaderText="Items" DataField="CodId" />
                                    <asp:BoundField HeaderText="Items" DataField="NotCom_Id" Visible="false" />
                                    <asp:BoundField HeaderText="Items" DataField="Ped_Codigo" Visible="false" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="Bie_Codigo" />
                                    <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Semana" SortExpression="Precio"></asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <!-- /.tab-pane -->
                    </div>
                    <!-- /.tab-content -->
                </div>
                <!-- nav-tabs-custom -->
            </div>
        </div>
        <div class="modal fade" id="modal-Pieza">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Pieza</h4>
                    </div>
                    <div class="modal-body">
                        <asp:GridView ID="dgvPieza" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-hover" OnRowDataBound="dgvPieza_RowDataBound" OnSelectedIndexChanged="dgvPieza_SelectedIndexChanged"></asp:GridView>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <div class="modal fade" id="modal-importar">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Pieza</h4>
                    </div>
                    <div class="modal-body">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="165px" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-dismiss="modal" runat="server" id="btnAceptarImp">Cerrar</button>
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
    </div>
    <!-- /.box-body -->
</asp:Content>

