<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmTipo_Cortes.aspx.cs" Inherits="pages_Beneficio_Proveedor" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <script type="text/javascript">
       function Validar() {
           var sTipoCorte = document.getElementById('ContentPlaceHolder2_txtNombre').value;
           if (sTipoCorte.trim() == "") {
               alert('Ingrese Tipo de Corte.');
               return false;
           }

           return true;
       }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <section class="content-header">
      <h1>
        Tipo de Cortes
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="#">Mantenimiento</li>
          <li class="active">Tipo Cortes</li>
      </ol>
    </section>
     <br />
    <div class="col-md-12">
   <div class="box box-danger">
            <div class="box-header with-border">
              <h3 class="box-title"></h3>
            </div>
            <div class="box-body">
                 <div class="row">
                <div class="col-xs-2">
                    <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                    <div class="input-group input-group-sm">
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    <span class="input-group-btn">
                        <button id="btnBuscarCortes" runat="server" type="button" class="btn btn-danger btn-flat" data-toggle="modal" data-target="#modal-TipCortes"><i class="fa fa-search"> </i></button>
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
                   <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false" MaxLength="150"></asp:TextBox>
                </div>
                <div class="col-xs-3">
               <br />
                </div>
                </div>
                <br />
                
  
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
                <div class="modal fade" id="modal-TipCortes">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h4 class="modal-title">Seleccionar Tipo Cortes</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">
                    <asp:GridView ID="dgvTipCortes" runat="server" DataKeyNames="TipCor_Cod" UseAccessibleHeader="False" CssClass="table table-bordered table-hover" OnRowDataBound="dgvTipCortes_RowDataBound" OnSelectedIndexChanged="dgvTipCortes_SelectedIndexChanged"></asp:GridView>
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

