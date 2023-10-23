<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmInventario.aspx.cs" Inherits="pages_Beneficio_frmInventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Inventario</title>
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
    <h1>INVENTARIO</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Transcciones</li>
        <li class="active">Inventario</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-body">
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarAlm" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Inventario"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-6">
                        <asp:Label ID="Label3" runat="server" Text="Almacen:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtAlmacen" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnAlmacen"  runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Pieza"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-4">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-8">
                        <asp:Label ID="Label5" runat="server" Text="Descripcion:"></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="btn btn-group-justified">
                                <div class="box-footer">
                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" />
                                    <asp:Button ID="btnGenerar" runat="server" Text="Generar" CssClass="btn btn-danger" Enabled="false" />
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal fade" id="modal-Inventario">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Inventario</h4>
                    </div>
                    <div class="modal-body">
                        <asp:GridView ID="dgvInventario" runat="server" CssClass="table table-bordered table-hover">
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
                        <asp:GridView ID="dgvPieza" runat="server" CssClass="table table-bordered table-hover">
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
    </div>
    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Inventario</h3>
                <div class="box-body">
                    <br />
                    <div class="row">
                        <div class="col-xs-9">
                            <div class="row">
                                <div class="col-xs-5">
                                    <asp:Label ID="Label6" runat="server" Text="Pieza:"></asp:Label>
                                    <div class="input-group input-group-sm">
                                        <asp:TextBox ID="txtPieza" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        <span class="input-group-btn">
                                            <button type="button" id="btnPieza" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-default"><i class="fa fa-search"></i></button>
                                        </span>
                                    </div>

                                </div>
                                <div class="col-xs-1">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label8" runat="server" Text="Cant. Sistema:"></asp:Label>
                                    <asp:TextBox ID="txtCanSis" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                </div>
                                <div class="col-xs-1">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label7" runat="server" Text="Cant. Fisico:"></asp:Label>
                                    <asp:TextBox ID="txtCanFis" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-6">
                                    <asp:Label ID="Label9" runat="server" Text="Sustento:"></asp:Label>
                                    <asp:TextBox ID="txtSustento" runat="server" CssClass="form-control" Enabled="False" TextMode="MultiLine" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-xs-1">
                        </div>
                        <div class="col-xs-2">
                            <div class="btn-group-vertical">
                                <asp:Button ID="btnNuevoIN" runat="server" Text="Agregar" CssClass=" btn btn-danger" Enabled="false" />
                                <asp:Button ID="btnCerrarIN" runat="server" Text="Cerrar Inventario" CssClass="btn btn-danger" Enabled="false" />

                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <asp:GridView ID="gdrDetalleInv" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true">
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
            </div>
        </div>
    </div>

</asp:Content>

