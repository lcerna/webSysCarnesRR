<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmNota_Pedido.aspx.cs" Inherits="pages_Beneficio_Nota_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Real Carnes RR | Proveedor</title>
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
    <h1>NOTA DE PEDIDO</h1>
        <ol class="breadcrumb">
            <li><i class="fa fa-dashboard"></i>Inicio</li>
            <li>Beneficio</li>
            <li>Transacciones</li>
            <li class="active">Nota de Pedido</li>
        </ol>
  

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
      <br />
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-header with-border">
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBuscarNP" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-NotaPedido" ><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-3">
                        <br />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label9" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="col-xs-3">
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
                        <asp:Label ID="Label3" runat="server" Text="Cliente:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtNombreCli" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnBusCliente" runat="server"  disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Cliente"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-4">
                        <div class="form-group">
                            <br />
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label5" runat="server" Text="Usuario Aprob.:"></asp:Label>
                        <asp:TextBox ID="txtUsuAprob" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-6">
                        <asp:Label ID="Label8" runat="server" Text="Glosa:"></asp:Label>
                        <asp:TextBox ID="txtGlosa" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
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
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" />

                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
        <!-- /.box-body -->
    </div>

    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Detalle de Pedido</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <span class="input-group-btn">
                    <button type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-AgregarDet" id="btnAgreNP" runat="server">Agregar</button>
                </span>
                <div id="example2_wrapper" class="dataTables_wrapper form-inline dt-bootstrap">
                    <div class="row">
                        <div class="col-sm-6"></div>
                        <div class="col-sm-6"></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                             <asp:GridView ID="dgrNotaCompra" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover">
                                    <Columns>
                                        <asp:ImageField>
                                        </asp:ImageField>
                                        <asp:ImageField>
                                        </asp:ImageField>
                                        <asp:BoundField HeaderText="Item" />
                                        <asp:BoundField HeaderText="Descripcion" />
                                        <asp:TemplateField HeaderText="Cantidad"></asp:TemplateField>
                                        <asp:CommandField AccessibleHeaderText="Semana" ShowSelectButton="True" />
                                    </Columns>
                                </asp:GridView>

                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SFRRMBEN08SelProc" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:Parameter Name="invd_codIde" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                                         
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <!-- /.box-body -->
    </div>
    <!-- /.box -->

    <div class="modal fade" id="modal-NotaPedido">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                  <h4 class="modal-title">Seleccionar Pedido</h4>
                </div>
                <div class="modal-body">
                    <div class="box-body">
                                <asp:GridView ID="dgvNotaPedido" runat="server" CssClass="table table-bordered table-hover"></asp:GridView>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <!-- /.box -->
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
                                <asp:GridView ID="dgvCliente" runat="server" CssClass="table table-bordered table-hover"></asp:GridView>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <!-- /.box -->
           
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
        <div class="modal fade" id="modal-AgregarDet">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                  <h4 class="modal-title">Seleccionar Pieza</h4>
                </div>
                <div class="modal-body">
                              <div class="box-body">
                                <asp:GridView ID="dgvPiezaNP" runat="server" CssClass="table table-bordered table-hover"></asp:GridView>
                            </div>
                            <!-- /.box-body -->
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


