<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmStock.aspx.cs" Inherits="pages_Beneficio_frmStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Real Carnes RR | Stock</title>
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>GENERAR STOCK</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Transacciones</li>
        <li class="active">Generar Stock</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div class="col-md-12">
        <div class="box box-primary">
            <div class="box-body">
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarStock" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Stock"><i class="fa fa-search"></i></button>
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
                    <div class="col-xs-8">
                        <asp:Label ID="Label3" runat="server" Text="Almacen:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtAlmacen" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnAlmacen" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Almacen"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-4">
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-8">
                        <asp:Label ID="Label5" runat="server" Text="Glosa:"></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="btn btn-group-justified">
                                <div class="box-footer">
                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevo_Click" />
                                    <asp:Button ID="btnGenerar" runat="server" Text="Generar" CssClass="btn btn-primary" OnClick="btnGenerar_Click" />
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
       </div>
     <div class="modal fade" id="modal-Stock">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Stock</h4>
                    </div>
                    <div class="modal-body">
                        <asp:GridView ID="dgvStock" runat="server" CssClass="table table-bordered table-hover" OnRowDataBound="dgvStock_RowDataBound" OnSelectedIndexChanged="dgvStock_SelectedIndexChanged">
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

        <div class="modal fade" id="modal-Almacen">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Almacen</h4>
                    </div>
                    <div class="modal-body">
                        <asp:GridView ID="dgvAlmacen" runat="server" CssClass="table table-bordered table-hover" OnRowDataBound="dgvAlmacen_RowDataBound" OnSelectedIndexChanged="dgvAlmacen_SelectedIndexChanged">
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
</asp:Content>

