<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagBotones.aspx.cs" Inherits="AppWeb.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <div class="form-group">
        <asp:Label ID="lblIdDireccion" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="tbxId" placeholder="Ingrese un ID unico." CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
    </div>
        <asp:Label ID="lblCalle" runat="server" Text="Calle"></asp:Label>
        <asp:TextBox ID="tbxCalle"  placeholder="Ingrese el nombre de la calle" CssClass="form-control" runat="server"></asp:TextBox>
        <small id="CalleAyuda" class="form-text text-muted">Solo agregue el nombre de la calle.</small>
    </div>
    <div class="form-group">
        <asp:Label ID="lblNumero" runat="server" Text="Numero"></asp:Label>
        <asp:TextBox ID="tbxNumero" placeholder="Ingrese el numero de la calle" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblDepartamento" runat="server" Text="Departamento"></asp:Label>
        <asp:TextBox ID="tbxDepartamento" placeholder="Por ejemplo 3A o 1B." CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblColorFachada" runat="server" Text="Color Fachada"></asp:Label>
        <asp:TextBox ID="tbxColorFachada" placeholder="Ingrese el color de la fachada." CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="btnConfirmarDireccion" runat="server" Text="Confirmar direccion" CssClass="btn btn-primary" OnClick="btnConfirmarDireccion_Click" />

</asp:Content>

