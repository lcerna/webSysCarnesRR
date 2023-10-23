<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmNotaCompra_new.aspx.cs" Inherits="pages_Beneficio_frmNotaCompra_new" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
    <title>Real Carnes| Nota de Compra</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h1>NOTA DE COMPRA</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Transacciones</li>
        <li class="active">Nota de Compra</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
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
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
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
                            <asp:ListItem Selected="True" Value="1">Soles</asp:ListItem>
                            <asp:ListItem Value="2">Dolares</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Tipo Cambio:"></asp:Label>
                        <asp:TextBox ID="txtTipoC" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>

                    </div>
                    <div class="col-xs-1"></div>
                    <div class="col-xs-2">
                        <div class="checkbox">
                            <asp:CheckBox ID="chkIgv" runat="server" Text="IGV" />
                        </div>
                    </div>

                    <div class="col-xs-3">
                        <asp:Label ID="Label12" runat="server" Text="Almacen:"></asp:Label>
                        <asp:DropDownList ID="dbrAlmacen" DataTextField="DscAlmacen" DataValueField="CodAlmacen" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label6" runat="server" Text="Fecha Cierre.:"></asp:Label>
                        <asp:TextBox ID="txtFecCie" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>                        
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
                                        <asp:Button ID="btnNuevoNC" runat="server" Text="Nuevo" CssClass=" btn btn-danger" OnClick="btnNuevoNC_Click" />
                                        <asp:Button ID="btnGuardarNC" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardarNC_Click" />
                                        <asp:Button ID="btnEliminarNC" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminarNC_Click" />
                                        <asp:Button ID="btnCancelarNC" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelarNC_Click" />
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label7" runat="server" Text="Sub Total:"></asp:Label>
                        <asp:TextBox ID="txtSubTotal" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:Label ID="Label10" runat="server" Text="Igv:"></asp:Label>
                        <asp:TextBox ID="txtIgv" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:Label ID="Label11" runat="server" Text="Total:"></asp:Label>
                        <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
            </div>
        
    <!-- /.box -->
    <br />

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
                            <div class="row">
                                <div class="col-xs-3">
                                    <div class="btn btn-group-justified">
                                        <div class="box-footer">
                                            <span class="input-group-btn">
                                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Pieza" id="btnAgregar" runat="server">Agregar</button>
                                            </span>
                                            <span class="input-group-btn">
                                                <button type="button" class="btn btn-danger btn-flat" id="btnImportar" runat="server" OnClick="btnImportar_Click">Importar</button>                                            
                                            </span>
                                        </div>
                                    </div>
                                    <br />
                                    <%--<asp:GridView ID="gdrDetalle" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true" OnRowDataBound="gdrDetalle_RowDataBound" OnSelectedIndexChanged="gdrDetalle_SelectedIndexChanged">
                                        <Columns>
                                            <asp:BoundField HeaderText="Items" DataField="CodId" />
                                            <asp:BoundField HeaderText="Descripcion" DataField="Bie_Codigo" />
                                            <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad"></asp:TemplateField>
                                            <asp:TemplateField HeaderText="Semana" SortExpression="Precio"></asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>--%>
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
                            <%--<asp:GridView ID="dgvProveeNot" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeader="true">
                                <Columns>
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/alert-circled.png" DeleteText="" EditImageUrl="~/bower_components/Ionicons/png/512/coffee.png" EditText="" ShowEditButton="True" />
                                    <asp:CommandField CancelText="" DeleteImageUrl="~/bower_components/Ionicons/png/512/edit.png" DeleteText="" ShowDeleteButton="True" />
                                    <asp:BoundField HeaderText="Items" DataField="CodId" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="Bie_Codigo" />
                                    <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Semana" SortExpression="Precio"></asp:TemplateField>
                                </Columns>
                            </asp:GridView>--%>
                        </div>
                        <!-- /.tab-pane -->
                    </div>
                    <!-- /.tab-content -->
                </div>
                <!-- nav-tabs-custom -->
            </div>
        </div>
    </div>
    <!-- /.box-body -->
    <!-- /.box -->
              </div>
    <div class="modal fade" id="modal-default">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Nota de Compra</h4>
                </div>
                <div class="modal-body">
                   <%-- <asp:GridView ID="dgvNotCompra" UseAccessibleHeader="False" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="false" DataKeyNames="NotCom_Id">
                        <Columns>
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="NotCom_Id" />
                            <asp:BoundField HeaderText="Proveedor" DataField="Not_Com_Fecha"  />
                            <asp:BoundField HeaderText="igv" DataField="Ped_Codigo" visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Requerido"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="CDestino"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Tcambio"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Incluye_Igv"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Moneda"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="SubTotal"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Igv"  visible="false" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Monto" />
                            <asp:BoundField HeaderText="Cod_NotaCom" DataField="Observacion"  visible="false" />
                                            </Columns>
                    </asp:GridView>--%>

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

    <div class="modal fade" id="modal-Proveedor">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                <h4 class="modal-title">Seleccionar Proveedor</h4>
                </div>
                <div class="modal-body">
                     <asp:GridView ID="dgvProveedor" runat="server" DataKeyNames="Prov_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvProveedor_RowDataBound" OnSelectedIndexChanged="dgvProveedor_SelectedIndexChanged" > 
                        </asp:GridView> 
                    
       
                    </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                </div>
                <div class="modal-footer">
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->

    <div class="modal fade" id="modal-AgregarProve">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Proveedor</h4>
                </div>
                <div class="modal-body">
                    <asp:GridView ID="dgvProvee" runat="server" CssClass="table table-bordered table-hover">
                     <Columns>
                          <asp:BoundField HeaderText="Codigo" DataField="Prov_Codigo" />
                          <asp:BoundField HeaderText="Tipo Documento" DataField="Tip_Doc" Visible ="false"/>
                          <asp:BoundField HeaderText="Numero Documento" DataField="Prov_NumDoc" Visible ="false"/>
                          <asp:BoundField HeaderText="Proveedor" DataField="Prov_Nombre"/>
                          <asp:BoundField HeaderText="Prov_Direccion" Visible ="false" DataField="Prov_Direccion"/>
                          <asp:BoundField HeaderText="Prov_Telefono" Visible ="false" DataField="Prov_Telefono"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov_TipTelf"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov_Contacto"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov_email"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov_Observaciones"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Depa"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Dist"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Prov_Estado"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Usu_Crea"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Fec_Crea"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Usu_Upd"/>
                          <asp:BoundField HeaderText="Codigo" Visible ="false" DataField="Fec_upd"/>
                      </Columns> 
                     </asp:GridView>     
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
    <div class="modal fade" id="modal-Pieza">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Pieza</h4>
                </div>
                <div class="modal-body">
                    <%--<asp:GridView ID="dgvPieza" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-hover" OnRowDataBound="dgvPieza_RowDataBound" OnSelectedIndexChanged="dgvPieza_SelectedIndexChanged"></asp:GridView>--%>                
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
          
        <!-- /.box-body -->
    </div>
</asp:Content>

