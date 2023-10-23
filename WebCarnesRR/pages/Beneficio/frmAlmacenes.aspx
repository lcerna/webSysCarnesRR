<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmAlmacenes.aspx.cs" Inherits="pages_Beneficio_Proveedor" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
    <script type="text/javascript">
        function Validar() {
            var sDesAlmacen = document.getElementById('ContentPlaceHolder1_TextBox2').value;
            if (sDesAlmacen.trim() == "") {
                alert('Ingrese descripción de almacen.');
                return false;
            }
            var sTipAlmacen = document.getElementById('ContentPlaceHolder1_cmbTipDoc').value;
            if (sTipAlmacen == "0") {
                alert('Seleccione tipo de almacen.');
                return false;
            }
            return true;
        }
    </script>   
     <title>SysOdonto | Almacen</title>
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
    <!--  <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptLocalization="true" EnableScriptGlobalization="true" />
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="always">
   <contenttemplate>-->
        <section class="content-header">
      <h1>
        ALMACEN
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Mantenimiento</li>
          <li class="active">Almacenes</li>
      </ol>
    </section>
      <br />
    <div class="col-md-12">
   <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Mantenimiento Almacen</h3>
            </div>
            <div class="box-body">
                 <div class="row">
                <div class="col-xs-2">
                    <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                    <div class="input-group input-group-sm">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Enabled="False" Text=" "></asp:TextBox>
                    <span class="input-group-btn">
                        <button type="button"  id="btnBuscarAlm" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modalAlmacen"><i class="fa fa-search"> </i></button>
                    </span>
                        </div>
                   
                </div>
                <div class="col-xs-8">
                 <br />
                </div>
                <div class="col-xs-2">
                   <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                </div>
                <br />
                <div class="row">
                <div class="col-xs-7">
                   <asp:Label ID="Label3" runat="server" Text="Descripcion:"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Enabled="False" MaxLength="200"></asp:TextBox>
                </div>
                <div class="col-xs-3">
                <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tipo Almacenes:" Enabled="False"></asp:Label>
                   <asp:DropDownList ID="cmbTipDoc" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" tabindex="-1" aria-hidden="true" Enabled="False">
                       <asp:ListItem Value="0" Selected="True">Seleccione</asp:ListItem>
                       <asp:ListItem Value="1">Principal</asp:ListItem>
                       <asp:ListItem Value="2">Secundario</asp:ListItem>
                    </asp:DropDownList>
                </div>
                </div>
                
                </div>

                <br />
                 <div class="row">
                <div class="col-xs-12">
               
                <div class="btn btn-group-justified">
                     <div class="box-footer">
                                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevo_Click"/>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClick="btnGuardar_Click" OnClientClick="return Validar();" />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" Enabled="False" OnClick="btnEliminar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
                </div>
                
              </div>
                </div>
              </div>
               
            </div>
            <!-- /.box-body -->
          </div>
                <div class="modal fade" id="modalAlmacen">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h4 class="modal-title">Seleccionar Almacen</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">
                   
                     <asp:GridView ID="dgvAlmacenes" runat="server" DataKeyNames="CodAlmacen" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover" OnRowDataBound="dgvAlmacenes_RowDataBound" OnSelectedIndexChanged="dgvAlmacenes_SelectedIndexChanged"> <%--OnPageIndexChanging="dgvAlmacenes_PageIndexChanging" PageSize="5" AllowPaging="true" AllowSorting="true" >--%>
                         
                    </asp:GridView>
       
            </div>
              </div>
              <div class="modal-footer">                    
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
     </div>  
   <!--    </contenttemplate>
                        </asp:UpdatePanel>-->
</asp:Content>

