<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmPrecio_Piezas.aspx.cs" Inherits="pages_Beneficio_PrecioPiezas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes| Precio Piezas Proveedor</title>

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
    <link rel="stylesheet" href="../../bower_components/bootstrap-daterangepicker/daterangepicker.css">
    <!-- bootstrap datepicker -->
    <link rel="stylesheet" href="../../bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css">
    <!-- iCheck for checkboxes and radio inputs -->
    <link rel="stylesheet" href="../../plugins/iCheck/all.css">
    <!-- Bootstrap Color Picker -->
    <link rel="stylesheet" href="../../bower_components/bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css">
    <!-- Bootstrap time Picker -->
    <link rel="stylesheet" href="../../plugins/timepicker/bootstrap-timepicker.min.css">
    <link href="../../bower_components/bootstrap/dist/css/ui.jqgrid.css" rel="stylesheet" />
    <link href="../../bower_components/bootstrap/dist/css/ui.jqgrid-bootstrap-ui.css" rel="stylesheet" />
    <link href="../../bower_components/bootstrap/dist/css/ui.jqgrid-bootstrap.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Precio de Bienes por Proveedor</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Mantenimiento</li>
        <li class="active">Precio Bienes x Proveedor</li>
    </ol>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">

        <div class="box box-primary">
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button id="btnBusPrePie" runat="server" type="button" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-PrePie"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
        
                </div>
                <div class="row">
                    <div class="col-xs-5">
                        

                    </div>
                    <div class="col-xs-4">
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Pieza:"></asp:Label>
                            <div class="input-group input-group-sm">
                                <asp:TextBox ID="txtPieza" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                <span class="input-group-btn">
                                    <button type="button" id="btnPieza" runat="server" disabled="disabled" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-Pieza"><i class="fa fa-search"></i></button>
                                </span>
                            </div>
                        </div>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="Label4" runat="server" Text="Tipo Cortes:"></asp:Label>
                        <asp:DropDownList ID="drbTipPiezas" Enabled="false" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true"></asp:DropDownList>

                    </div>
                    
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-6">
                        <asp:Label ID="Label8" runat="server" Text="Observacion:"></asp:Label>
                        <asp:TextBox ID="txtObservacion" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                      </div>
               </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo"  CssClass="btn btn-primary" OnClick="btnNuevo_Click"/>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" OnClick="btnEliminar_Click"/>
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.box-body -->
        </div>

                <div class="modal fade" id="modal-PrePie">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                       <h4 class="modal-title">Seleccionar Precio por Pieza</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:GridView ID="dgvPrePie" runat="server" OnRowDataBound="dgvPrePie_RowDataBound" OnSelectedIndexChanged="dgvPrePie_SelectedIndexChanged"></asp:GridView>
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
        <div class="modal fade" id="modal-proveedor">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                       <h4 class="modal-title">Seleccionar Proveedor</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:GridView ID="grvProveedor" runat="server" OnRowDataBound="grvProveedor_RowDataBound" OnSelectedIndexChanged="grvProveedor_SelectedIndexChanged"></asp:GridView>
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
        <div class="modal fade" id="modal-Pieza">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                       <h4 class="modal-title">Seleccionar Pieza</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:GridView ID="grvPieza" runat="server" OnRowDataBound="grvPieza_RowDataBound" OnSelectedIndexChanged="grvPieza_SelectedIndexChanged"></asp:GridView>
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

</asp:Content>
