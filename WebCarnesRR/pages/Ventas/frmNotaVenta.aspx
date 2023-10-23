<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmNotaVenta.aspx.cs" Inherits="pages_Ventas_frmNotaVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
    <h1>NOTA DE VENTA</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Venta</a></li>
        <li class="#">Transaccion</li>
        <li class="active">Nota de Venta</li>
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
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBusNV" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-NotaVen"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label3" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label4" runat="server" Text="Cliente:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCliente" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnClien" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Cliente"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label5" runat="server" Text="Tipo Moneda:"></asp:Label>
                        <asp:DropDownList ID="bdoTipMon" runat="server" CssClass="form-control select2 select2-hidden-accessible"></asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-2">

                        <asp:Label ID="Label6" runat="server" Text="Tipo de Cambio:"></asp:Label>
                        <asp:TextBox ID="txtTipCamb" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <div class="checkbox">
                            <asp:CheckBox ID="chkIgv" runat="server" Text="Incluye IGV" />
                        </div>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Fecha Cierre:"></asp:Label>
                        <asp:TextBox ID="txtFecCie" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-8">
                        <div class="row">
                            <asp:Label ID="Label7" runat="server" Text="Observacion:"></asp:Label>
                            <asp:TextBox ID="txtObservacion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="btn btn-group-justified">
                                    <div class="box-footer">
                                        <asp:Button ID="btnNuevoBan" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevoBan_Click" />
                                        <asp:Button ID="btnGuardarBan" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClick="btnGuardarBan_Click" />
                                        <asp:Button ID="btnEliminarBan" runat="server" Text="Eliminar" CssClass="btn btn-primary " Enabled="False" OnClick="btnEliminarBan_Click" />
                                        <asp:Button ID="btnCancelarBan" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelarBan_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label9" runat="server" Text="Subtotal:"></asp:Label>
                        <asp:TextBox ID="txtSubTotal" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:Label ID="Label10" runat="server" Text="Igv:"></asp:Label>
                        <asp:TextBox ID="txtIgv" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:Label ID="Label11" runat="server" Text="Total:"></asp:Label>
                        <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <br />
            </div>
        </div>
    </div>

    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Nota de Venta</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <br />
                <span class="input-group-btn">
                    <button type="button" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-AgregarDetNV" id="btnAgregarDNV">Agregar</button>
                </span>

                <asp:GridView ID="gdrDetalleNV" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true">
                </asp:GridView>
            </div>
        </div>
    </div>
    <div class="modal fade" id="modal-NotaVen">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Nota de Venta</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgvNotVen" runat="server" DataKeyNames="Fac_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover"></asp:GridView>
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

    <div class="modal fade" id="modal-Cliente">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Cliente</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                         <asp:GridView ID="dgvCliente" runat="server" DataKeyNames="Cli_Codigo" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvCliente_RowDataBound" OnSelectedIndexChanged="dgvCliente_SelectedIndexChanged">
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

</asp:Content>

