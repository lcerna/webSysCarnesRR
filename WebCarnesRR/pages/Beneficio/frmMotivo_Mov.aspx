<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmMotivo_Mov.aspx.cs" Inherits="pages_Beneficio_Proveedor" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Tipo y Motivo Movimiento
        <small></small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li><a href="#">Beneficio</a></li>
            <li class="#">Mantenimiento</li>
            <li class="active">Tipo y Motivo Mov.</li>
        </ol>
    </section>
    <br />
    <div class="nav-tabs-custom">
        <ul class="nav nav-tabs">
            <li class="active"><a href="#tab_1" data-toggle="tab">Tipo Movimiento</a></li>
            <li><a href="#tab_2" data-toggle="tab">Motivo de Movimiento</a></li>

        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="tab_1" >
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarAlm" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-tipoMov"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Descripcion:"></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label4" runat="server" Text="Comentario:"></asp:Label>
                        <asp:TextBox ID="txtComentario" runat="server" CssClass="form-control" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" OnClick="btnNuevo_Click" />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardar_Click" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <!-- /.tab-pane -->
            <div class="tab-pane" id="tab_2" >
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label5" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigoMot" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnMov" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Motivo"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-8">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label6" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstadoMot" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label7" runat="server" Text="Descripcion:"></asp:Label>
                        <asp:TextBox ID="txtDescMot" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label9" runat="server" Text="Descripcion Corta:"></asp:Label>
                        <asp:TextBox ID="txtDesCorMot" runat="server" CssClass="form-control" Enabled="False" TextMode="SingleLine"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label8" runat="server" Text="Tipo Operación:"></asp:Label>
                        <asp:DropDownList ID="cmbTipMoti" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" tabindex="-1" aria-hidden="true" Enabled="False">
                        </asp:DropDownList>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label10" runat="server" Text="Sunat:"></asp:Label>
                        <asp:TextBox ID="txtSunatMot" runat="server" CssClass="form-control" Enabled="False" TextMode="SingleLine"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevoMov" runat="server" Text="Nuevo" CssClass=" btn btn-danger" OnClick="btnNuevoMov_Click" />
                                <asp:Button ID="btnGuardarMov" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardarMov_Click" />
                                <asp:Button ID="btnEliminarMov" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminarMov_Click" />
                                <asp:Button ID="btnCancelarMov" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelarMov_Click" />
                            </div>

                        </div>
                    </div>
                </div>


            </div>
            <!-- /.tab-pane -->

        </div>
        <!-- /.tab-content -->
    </div>
    <div class="modal fade" id="modal-tipoMov">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Tipo de Motivo</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgvTipoMotivo" runat="server" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvTipoMotivo_RowDataBound" OnSelectedIndexChanged="dgvTipoMotivo_SelectedIndexChanged">
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
        <div class="modal fade" id="modal-Motivo">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Seleccionar Motivo</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                        <asp:GridView ID="dgvMotivo" runat="server" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvMotivo_RowDataBound" OnSelectedIndexChanged="dgvMotivo_SelectedIndexChanged">
                        </asp:GridView>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button6" runat="server" Text="Cerrar" CssClass="btn btn-default" data-dismiss="modal" />
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
</asp:Content>

