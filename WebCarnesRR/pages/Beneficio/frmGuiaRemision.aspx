<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmGuiaRemision.aspx.cs" Inherits="pages_Beneficio_frmGuiaRemision" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Guia Remision</title>
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
    <h1>GUIA DE REMISION</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Transcciones</li>
        <li class="active">Guia de Remision</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-body">
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-GuiaR" id="btnBuscar"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label9" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-4">
                        <asp:Label ID="Label12" runat="server" Text="Motivo:"></asp:Label>
                    <asp:DropDownList ID="dbrMotivo" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label3" runat="server" Text="Fecha Traslado:"></asp:Label>
                        <asp:TextBox ID="txtFechTras" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-4">
                        <asp:Label ID="Label4" runat="server" Text="Tipo Persona:"></asp:Label>
                    <asp:DropDownList ID="dboTipPer" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="Label5" runat="server" Text="Descripcion:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Descrp" id="btnDescrip"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-4">
                        <asp:Label ID="Label6" runat="server" Text="Tipo Documento:"></asp:Label>
                    <asp:DropDownList ID="dboTipDoc" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-4">
                        <asp:Label ID="Label7" runat="server" Text="Numero Documento:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-NumDoc" id="btnNumDoc"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-8">
                        <asp:Label ID="Label8" runat="server" Text="Dirección:"></asp:Label>
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label10" runat="server" Text="Placa:"></asp:Label>
                        <asp:TextBox ID="txtPlaca" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-3">
                    <asp:Label ID="Label11" runat="server" Text="Departamento:"></asp:Label>
                    <asp:DropDownList ID="dboDepartamento" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="Label13" runat="server" Text="Provincia:"></asp:Label>
                    <asp:DropDownList ID="dboProvincia" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                    <div class="col-xs-1">
                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="Label14" runat="server" Text="Distrito:"></asp:Label>
                    <asp:DropDownList ID="dboDistrito" CssClass="form-control select2 select2-hidden-accessible" runat="server" Style="width: 100%;" TabIndex="-1" Enabled="False"></asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-danger" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Guia de Remision</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <span class="input-group-btn">
                    <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-AgregarDetGR" id="btnAgregarGr">Agregar</button>
                </span>
                <br />
                <asp:GridView ID="gdrDetalleGR" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true">
                </asp:GridView>
            </div>
        </div>
    </div>

    <div class="modal fade" id="modal-GuiaR">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Guia de Remision</h4>
                </div>
                <div class="modal-body">
                    <asp:GridView ID="dgvGuiaR" runat="server" CssClass="table table-bordered table-hover" >
                  
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
    <div class="modal fade" id="modal-Descrp">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar </h4>
                </div>
                <div class="modal-body">
                    <asp:GridView ID="dgvDescrip" runat="server" CssClass="table table-bordered table-hover" >
                        
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
    <div class="modal fade" id="modal-NumDoc">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Numero Documento</h4>
                </div>
                <div class="modal-body">
                    <asp:GridView ID="GridView2" runat="server" CssClass="table table-bordered table-hover" >
                        <Columns>
                            <asp:BoundField HeaderText="Cod_NotaCom" />
                            <asp:BoundField HeaderText="Proveedor" Visible="False" />
                            <asp:BoundField HeaderText="igv" />
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
</asp:Content>

