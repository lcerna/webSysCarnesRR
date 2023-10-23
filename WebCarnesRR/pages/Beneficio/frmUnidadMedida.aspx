<%@ Page Title="Real Carnes RR| Unidad de Medida" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmUnidadMedida.aspx.cs" Inherits="pages_Beneficio_frmUnidadMedida" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Validar() {
            var sDesAlmacen = document.getElementById('ContentPlaceHolder2_txtNombre').value;
            if (sDesAlmacen.trim() == "") {
                alert('Ingrese descripción de almacen.');
                return false;
            }
            var sAbrAlm = document.getElementById('ContentPlaceHolder2_txtAbrev').value;
            if (sAbrAlm == "") {
                alert('Ingrese Abreviatura.');
                return false;
            }
            var sSunAlm = document.getElementById('ContentPlaceHolder2_txtSunat').value;
            if (sSunAlm == "") {
                alert('Ingrese Descripcion Sunat.');
                return false;
            }
            return true;
        }
    </script>   
    
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
    <h1>UNIDAD DE MEDIDA</h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="#">Mantenimiento</li>
        <li class="active">Unidad de Medida</li>
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-md-12">
        <div class="box box-primary">
            <div class="box-body">
                <br />
                <div class="row">
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                        <div class="input-group input-group-sm">
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            <span class="input-group-btn">
                                <button type="button"  class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modal-UnidadDM" id="btnUnidadM" runat="server"><i class="fa fa-search"></i></button>
                            </span>
                        </div>
                    </div>
                    <div class="col-xs-7">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false" MaxLength="200"></asp:TextBox>
                    </div>
                    <div class="col-xs-2">  
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label4" runat="server" Text="Abreviatura:"></asp:Label>
                        <asp:TextBox ID="txtAbrev" runat="server" CssClass="form-control" Enabled="false" MaxLength="50"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-7">
                        <asp:Label ID="Label6" runat="server" Text="Observaciones:"></asp:Label>
                        <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control" TextMode="MultiLine" Enabled="false" MaxLength="250"></asp:TextBox>
                    </div>
                    <div class="col-xs-2">
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label8" runat="server" Text="Sunat:"></asp:Label>
                        <asp:TextBox ID="txtSunat" runat="server" CssClass="form-control" Enabled="false" MaxLength="2"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="btn btn-group-justified">
                            <div class="box-footer">
                                <asp:Button ID="btnNuevoNC" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevoNC_Click" />
                                <asp:Button ID="btnGuardarNC" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClick="btnGuardarNC_Click" OnClientClick="return Validar();" />
                                <asp:Button ID="btnEliminarNC" runat="server" Text="Eliminar" CssClass="btn btn-primary " Enabled="False" OnClick="btnEliminarNC_Click" />
                                <asp:Button ID="btnCancelarNC" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelarNC_Click" />
                            </div>

                        </div>
                    </div>

                </div>

            </div>
            <!-- /.box-body -->
        </div>
        <div class="modal fade" id="modal-UnidadDM">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Seleccionar Unidad de Medida</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box-body">
                            <asp:GridView ID="gdrUnidadM" runat="server" CssClass="table table-bordered table-hover" DataKeyNames="Cod_Udm" UseAccessibleHeader="False"  OnRowDataBound="gdrUnidadM_RowDataBound" OnSelectedIndexChanged="gdrUnidadM_SelectedIndexChanged">
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
    </div>
</asp:Content>
