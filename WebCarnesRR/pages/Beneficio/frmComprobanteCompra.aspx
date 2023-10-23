<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmComprobanteCompra.aspx.cs" Inherits="pages_Beneficio_frmComprobanteCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Comprobante</title>
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
    <h1>COMPROBANTE DE COMPRA
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Trannsacciones</li>
        <li class="active">Comprobante de Compra</li>
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
                                <button type="button" id="btnBuscarAlm" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-default"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label5" runat="server" Text="Fecha :"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
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
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Proveedor:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnProv" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-default"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Fecha Recep.:"></asp:Label>
                        <asp:TextBox ID="txtFecRecp" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label6" runat="server" Text="Tipo Doc:"></asp:Label>
                        <asp:DropDownList ID="cmbTipDoc" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true" Enabled="False">
                            <asp:ListItem Value="0" Selected="True">Seleccione</asp:ListItem>
                            <asp:ListItem Value="1">Principal</asp:ListItem>
                            <asp:ListItem Value="2">Secundario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="Label7" runat="server" Text="Numero Doc.:"></asp:Label>
                        <asp:TextBox ID="txtNumeroDoc" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Monto:"></asp:Label>
                        <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label9" runat="server" Text="Glosa:"></asp:Label>
                        <asp:TextBox ID="txtGLosa" runat="server" CssClass="form-control" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
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
        </div>
    </div>
</asp:Content>

