<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas.master" AutoEventWireup="true" CodeFile="frmUsuario.aspx.cs" Inherits="pages_Beneficio_Proveedor" %>

<script runat="server">

    protected void btnNuevo1_Click(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <section class="content-header">
      <h1>
        Usuario
        <small>Registro de Usuario</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Inicio</a></li>
        <li><a href="#">Beneficio</a></li>
        <li class="active">Mantenimiento</li>
          <li class="active">Usuario</li>
      </ol>
    </section>

      <br />
    <div class="col-md-12">
   <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Mantenimiento Usuarios</h3>
            </div>
            <div class="box-body">
                 <div class="row">
                <div class="col-xs-2">
                    <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                    <div class="input-group input-group-sm">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Enabled="False" Text=" "></asp:TextBox>
                    <span class="input-group-btn">
                        <button type="button"  id="btnBuscarAlm" runat="server" class="btn btn-primary btn-flat" data-toggle="modal" data-target="#modalUsuario"><i class="fa fa-search"> </i></button>
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
                <div class="col-xs-6">
                   <asp:Label ID="Label3" runat="server" Text="Nombre Usuario:"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Enabled="False" MaxLength="200"></asp:TextBox>
                </div>
                    <div class="col-xs-2">
                   <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Enabled="False" MaxLength="20" TextMode="Password"></asp:TextBox>
                </div>
                 <div class="col-xs-1"></div>
                <div class="col-xs-3">
                <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tipo Usuario:" Enabled="False"></asp:Label>
                   <asp:DropDownList ID="cmbTipUsu" DataTextField="Nombre_Tipo" DataValueField="Id_Tipo_Usuario" CssClass="form-control select2 select2-hidden-accessible" runat="server" tyle="width: 100%;" tabindex="-1" aria-hidden="true" Enabled="False">
                       </asp:DropDownList>
                </div>
                </div>
                
                </div>

                <br />
                 <div class="row">
                <div class="col-xs-12">
               
                <div class="btn btn-group-justified">
                     <div class="box-footer">
                                <asp:Button ID="btnNuevo1" runat="server" Text="Nuevo" CssClass=" btn btn-primary" OnClick="btnNuevo1_Click" />
                                <asp:Button ID="btnGuardar2" runat="server" Text="Guardar" CssClass="btn btn-primary" Enabled="False" OnClick="btnGuardar2_Click" />
                                <asp:Button ID="btnEliminar2" runat="server" Text="Eliminar" CssClass="btn btn-primary" Enabled="False"  />
                                <asp:Button ID="btnCancelar2" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                </div>
                
              </div>
                </div>
              </div>
               
            </div>
            <!-- /.box-body -->
          </div>
                <div class="modal fade" id="modalUsuario">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h4 class="modal-title">Seleccionar Usuario</h4>
              </div>
              <div class="modal-body">
                <div class="box-body">
                   
                     <asp:GridView ID="dgvUsuario" runat="server" DataKeyNames="CodUsuario" UseAccessibleHeader="False" Width="100%" CssClass="table table-bordered table-hover"  > <%--OnPageIndexChanging="dgvAlmacenes_PageIndexChanging" PageSize="5" AllowPaging="true" AllowSorting="true" >--%>
                         
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

</asp:Content>

