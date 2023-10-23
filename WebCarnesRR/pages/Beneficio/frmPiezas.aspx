<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true"  CodeFile="frmPiezas.aspx.cs" Inherits="pages_Beneficio_frmPiezas" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <script type="text/javascript">
         function Validar() {
             var sDes = document.getElementById('ContentPlaceHolder2_txtNombre').value;
             if (sDes.trim() == "") {
                 alert('Ingrese Nombre.');
                 return false;
             }
             var sUnidadMedida = document.getElementById('ContentPlaceHolder2_dboUnidadMedida').value;
             if (sUnidadMedida.trim() == "0") {
                 alert('Seleccione Unidad de Medida.');
                 return false;
             }
             var sCapacidad = document.getElementById('ContentPlaceHolder2_txtCapacidad').value;
             if (sCapacidad == "") {
                 alert('Ingrese Capacidad.');
                 return false;
             }

             return true;
         }
    </script>  



    <title>Real Carnes| Familia de Bienes</title>
    
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
    <h1>Familia de Bienes </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Mantenimiento</li>
        <li class="active">Familia de Bienes</li>
    </ol>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="col-md-12">
        <div class="box box-danger">
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-3">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnbusPieza" runat="server" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-Piezas"><i class="fa fa-search"></i></button>
                            </span>
                        </div>

                    </div>
                    <div class="col-xs-6">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="200"></asp:TextBox>
                    </div>
                    <div class="col-xs-2">
                        
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Capacidad:"></asp:Label>
                        <asp:TextBox ID="txtCapacidad" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>

                    </div>
                </div>
                <br />
                <div class="row">
                   <div class="col-xs-5">
                        <asp:Label ID="Label4" runat="server" Text="Proveedor:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtProvee" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button" id="btnProvee" runat="server" disabled="disabled" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-proveedor"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label7" runat="server" Text="Unidad de Medida:"></asp:Label>
                            <asp:DropDownList ID="dboUnidadMedida" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" TabIndex="-1" aria-hidden="true" DataTextField="Nombre" DataValueField="Cod_Udm"></asp:DropDownList>
                            
                    </div>
                </div>
 
                <div class="row">
                   <div class="col-xs-7">
                        <asp:Label ID="Label6" runat="server" Text="Observaciones:"></asp:Label>
                        <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control" MaxLength="200"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">

                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-danger" OnClick="btnNuevo_Click" />
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-danger" Enabled="False" OnClick="btnGuardar_Click" OnClientClick="return Validar();" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.box-body -->
        </div>
        <div class="modal fade" id="modal-Piezas">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Piezas</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:GridView ID="dgvPiezas" runat="server" CssClass="table table-bordered table-hover" DataKeyNames="Bie_Codigo" UseAccessibleHeader="False" OnRowDataBound="dgvPiezas_RowDataBound" OnSelectedIndexChanged="dgvPiezas_SelectedIndexChanged"></asp:GridView>
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
                            <asp:GridView ID="grvProveedor" runat="server" DataKeyNames="Prov_Codigo" OnRowDataBound="grvProveedor_RowDataBound" OnSelectedIndexChanged="grvProveedor_SelectedIndexChanged"></asp:GridView>
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

