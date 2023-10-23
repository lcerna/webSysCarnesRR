<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmBanco_Cue.aspx.cs" Inherits="pages_Ventas_frmBanco_Cue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Banco - Cuenta</title>
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
    <h1>Banco - Cuenta</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Venta</a></li>
        <li class="#">Mantenimiento</li>
        <li class="active">Banco - Venta</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-body">
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs ">
                        <li class="active"><a href="#tab_Banco" data-toggle="tab"  aria-expanded="undefined">Bancos </a></li>
                        <li><a href="#tab_Cuenta" data-toggle="tab">Cuentas </a></li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_Banco">
                            <br />
                            <div class="row">
                                <div class="col-xs-2">
                                    <asp:Label ID="Label4" runat="server" Text="Codigo:"></asp:Label>
                                    <div class="input-group input-group-sm">
                                        <asp:TextBox ID="txtCodigoBan" runat="server" CssClass="form-control"></asp:TextBox>
                                        <span class="input-group-btn">
                                            <button type="button" id="btnBuscarBan" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Banco"><i class="fa fa-search"></i></button>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-xs-8">
                                    <br />
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label5" runat="server" Text="Estado:"></asp:Label>
                                    <asp:TextBox ID="txtEstadoBan" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-7">
                                    <asp:Label ID="Label6" runat="server" Text="Descripcion:"></asp:Label>
                                    <asp:TextBox ID="txtDescripBan" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="btn btn-group-justified">
                                        <div class="box-footer">
                                            <asp:Button ID="btnNuevoBan" runat="server" Text="Nuevo" CssClass=" btn btn-danger" />
                                            <asp:Button ID="btnGuardarBan" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" />
                                            <asp:Button ID="btnEliminarBan" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" />
                                            <asp:Button ID="btnCancelarBan" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="tab_Cuenta">
                            <br />
                            <div class="row">
                                <div class="col-xs-2">
                                    <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                                    <div class="input-group input-group-sm">
                                        <asp:TextBox ID="txtCodCue" runat="server" CssClass="form-control"></asp:TextBox>
                                        <span class="input-group-btn">
                                            <button type="button" id="btnCuenta" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Cuenta"><i class="fa fa-search"></i></button>
                                        </span>
                                    </div>

                                </div>
                                <div class="col-xs-3">
                                </div>
                                <div class="col-xs-3">
                                    <asp:Label ID="Label7" runat="server" Text="Banco:"></asp:Label>
                                    <asp:TextBox ID="txtCueBanco" runat="server" CssClass="form-control"></asp:TextBox>

                                </div>
                                <div class="col-xs-2">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                                    <asp:TextBox ID="txtEstadoCue" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-8">
                                    <asp:Label ID="Label3" runat="server" Text="Codigo:"></asp:Label>
                                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-2">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label9" runat="server" Text="Moneda:"></asp:Label>
                                    <asp:DropDownList ID="dboMoneda" runat="server" CssClass="form-control select2 select2-hidden-accessible"></asp:DropDownList>
                                </div>

                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-3">
                                    <asp:Label ID="Label8" runat="server" Text="Tipo Cuenta:"></asp:Label>
                                    <asp:DropDownList ID="dboTipCuenta" runat="server" CssClass="form-control select2 select2-hidden-accessible"></asp:DropDownList>

                                </div>
                                <div class="col-xs-2">
                                </div>
                                <div class="col-xs-3">
                                    <asp:Label ID="Label10" runat="server" Text="Numero Cta.:"></asp:Label>
                                    <asp:TextBox ID="txtNumCuen" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-xs-2">
                                </div>
                                <div class="col-xs-2">
                                    <asp:Label ID="Label11" runat="server" Text="Saldo Inicial:"></asp:Label>
                                    <asp:TextBox ID="txtSaldo" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="btn btn-group-justified">
                                        <div class="box-footer">
                                            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" />
                                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" />
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" />
                                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                    </div>
                    <!-- /.tab-content -->
                </div>
                <!-- nav-tabs-custom -->

                    <div class="modal fade" id="modal-Banco">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h4 class="modal-title">Seleccionar Banco</h4>
                            </div>
                            <div class="modal-body">
                                <div class="box-body">
                                    <asp:GridView ID="dgvBanco" runat="server"></asp:GridView>
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

                <div class="modal fade" id="modal-Cuenta">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h4 class="modal-title">Seleccionar Cuenta</h4>
                            </div>
                            <div class="modal-body">
                                <div class="box-body">
                                    <asp:GridView ID="dgvCuenta" runat="server"></asp:GridView>
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
</asp:Content>

