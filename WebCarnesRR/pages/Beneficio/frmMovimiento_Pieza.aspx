<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmMovimiento_Pieza.aspx.cs" Inherits="pages_Beneficio_frmMovimiento_Bien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Movimiento de Almacen</title>
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

       <h1>Movimientos de Almacen</h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li><a href="#">Beneficio</a></li>
            <li class="active">Mantenimiento</li>
            <li class="active">Movimiento de Almacen</li>
        </ol>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
        <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-header with-border">
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarMov" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Movimiento"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Fecha:" Enabled="False"></asp:Label>
                            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-4">
                        <asp:Label ID="Label3" runat="server" Text="Almacen Origen:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtAlmacenOrigen" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" id="btnAlmacenO" runat="server" disabled="disabled" data-target="#modal-Almacen"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Almacen Destino:" Enabled="False"></asp:Label>
                            <div class="input-group input-group-sm">
                                <asp:TextBox ID="txtAlmacenDestino" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                <span class="input-group-btn">
                                    <button type="button" id="btnAlmacenD" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Almacen"><i class="fa fa-search"></i></button>
                                </span>
                            </div>
                        </div>
                    </div>
                    
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label6" runat="server" Text="Tipo Operación:"></asp:Label>
                        <asp:DropDownList ID="dbrTipoOpera" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Motivo:"></asp:Label>
                            <asp:DropDownList ID="dbrMotivo" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Moneda:"></asp:Label>
                            <asp:DropDownList ID="dbrMoneda" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <asp:Label ID="Label9" runat="server" Text="Proveedor:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtNomProv" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnProv" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Proveedor"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-4">
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label10" runat="server" Text="Tipo Documento:"></asp:Label>
                        <asp:DropDownList ID="dvrTipoDoc" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>

                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="Label11" runat="server" Text="Numero Doc:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtNumDoC" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnNumDoc" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-NumDoc"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label12" runat="server" Text="Fecha Doc.:" Enabled="False"></asp:Label>
                        <asp:TextBox ID="txtFechaDoc" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                    </div>
                    
                </div>
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" OnClick="btnNuevo_Click"  />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardar_Click"  />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.box-body -->
        </div>

    </div>

    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Movimiento</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <div id="example2_wrapper" class="dataTables_wrapper form-inline dt-bootstrap">
                    <div class="row">
                        <div class="col-sm-6"></div>
                        <div class="col-sm-6"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-AgregarDet" id="btnAgregaDet" runat="server" disabled="disabled">Agregar</button>
                            </span>
                            <br />
                            <asp:GridView ID="gdrDetalle" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true" >
                                <Columns>
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/alert-circled.png" DeleteText="" EditImageUrl="~/bower_components/Ionicons/png/512/coffee.png" EditText="" ShowEditButton="True" />
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/edit.png" DeleteText="" ShowDeleteButton="True" />
                                    <asp:BoundField HeaderText="Items" DataField="CodId" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="Bie_Codigo" />
                                    <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Semana" SortExpression="Precio"></asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-5">
                            <div class="dataTables_info" id="example2_info" role="status" aria-live="polite">Showing 1 to 10 of 57 entries</div>
                        </div>
                        <div class="col-sm-7">
                            <div class="dataTables_paginate paging_simple_numbers" id="example2_paginate">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.box-body -->
    </div>
    <!-- /.box -->

        <div class="modal fade" id="modal-Movimiento">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Movimiento</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:HiddenField runat="server" ID="hf_control" />
                            <%-- <asp:GridView ID="dgvAlmacenes" runat="server" CssClass="dataTables_wrapper form-inline dt-bootstrap">

                        </asp:GridView>  --%>
                            <asp:GridView ID="dgvMovimiento" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover">
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="modal-footer">
                       <asp:Button ID="btnModalC" runat="server" Text="Cerrar" CssClass="btn btn-default" data-dismiss="modal" />
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
                    <h4 class="modal-title">Seleccionar Almacen</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:HiddenField runat="server" ID="HiddenField1" />
                        <%-- <asp:GridView ID="dgvAlmacenes" runat="server" CssClass="dataTables_wrapper form-inline dt-bootstrap">

                    </asp:GridView>  --%>
                        <asp:GridView ID="dgvAlmacen" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover">
                        </asp:GridView>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button3" runat="server" Text="Cerrar" CssClass="btn btn-default" data-dismiss="modal" />
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
        <div class="modal fade" id="modal-Proveedor">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Proveedor</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:HiddenField runat="server" ID="HiddenField2" />
                        <%-- <asp:GridView ID="dgvAlmacenes" runat="server" CssClass="dataTables_wrapper form-inline dt-bootstrap">

                    </asp:GridView>  --%>
                        <asp:GridView ID="dgvProveedor" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover">
                        </asp:GridView>
                    </div>
                </div>
                <div class="modal-footer">
                   <asp:Button ID="Button5" runat="server" Text="Cerrar" CssClass="btn btn-default" data-dismiss="modal" />
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
            <div class="modal fade" id="modal-NumDoc">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Seleccionar Numero Documento</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:HiddenField runat="server" ID="HiddenField3" />
                        <%-- <asp:GridView ID="dgvAlmacenes" runat="server" CssClass="dataTables_wrapper form-inline dt-bootstrap">

                    </asp:GridView>  --%>
                        <asp:GridView ID="dgvNumDoc" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover">
                        </asp:GridView>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button7" runat="server" Text="Cerrar" CssClass="btn btn-default" data-dismiss="modal" />
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
</asp:Content>


