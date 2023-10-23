<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmMov_Venta.aspx.cs" Inherits="pages_Ventas_frmMov_Venta" %>

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
        <li class="#">Transaccion</li>
        <li class="active">Movimiento de Venta</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-primary">
            <div class="box-body">
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnMovVen" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-MovVen"><i class="fa fa-search"></i></button>
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
                    <div class="col-xs-4">
                        <asp:Label ID="Label4" runat="server" Text="Banco:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtBanco" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBanco" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Banco"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-4">
                        <asp:Label ID="Label5" runat="server" Text="Cuenta:"></asp:Label>
                        <div class="input-group input-group-sm">
                        <asp:TextBox ID="txtCuenta" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="input-group-btn">
                                <button type="button" id="btnCliente" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Cliente"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label6" runat="server" Text="Fecha Transac.:"></asp:Label>
                        <asp:TextBox ID="txtFecMov" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label7" runat="server" Text="Tipo Movimiento:"></asp:Label>
                        <asp:DropDownList ID="dboTipMov" runat="server" CssClass="form-control select2 select2-hidden-accessible"></asp:DropDownList>

                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-5">
                        <asp:Label ID="Label8" runat="server" Text="Descripcion:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtDescrip" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnDesc" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Descrip"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                  </div>
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label10" runat="server" Text="Moneda:"></asp:Label>
                        <asp:DropDownList ID="dboMoneda" runat="server" CssClass="form-control select2 select2-hidden-accessible"></asp:DropDownList>

                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label11" runat="server" Text="Monto:"></asp:Label>
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                   
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevoBan" runat="server" Text="Nuevo" CssClass=" btn btn-primary" />
                                <asp:Button ID="btnGuardarBan" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" />
                                <asp:Button ID="btnEliminarBan" runat="server" Text="Eliminar" CssClass="btn btn-primary " Enabled="False" />
                                <asp:Button ID="btnCancelarBan" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="modal-MovVen">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Movimiento Venta</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgvMovVen" runat="server"></asp:GridView>
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

    <div class="modal fade" id="modal-Banco">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Cliente</h4>
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

    <div class="modal fade" id="modal-Cliente">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Cliente</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgvCliente" runat="server"></asp:GridView>
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

    <div class="modal fade" id="modal-Descrip">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Movimiviento</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgDescrip" runat="server"></asp:GridView>
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

