<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tabla2.aspx.cs" Inherits="AppWeb.Tabla2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="dgvDireccion" OnSelectedIndexChanged="dgvDireccion_SelectedIndexChanged" runat="server" CssClass="table table-dark table-striped-columns" DataKeyNames="Id" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Calle" DataField="Calle" />
            <asp:BoundField HeaderText="Numero" DataField="Numero" />
            <asp:BoundField HeaderText="Departamento" DataField="Departamento" />
            <asp:BoundField HeaderText="Color de la fachada" DataField="ColorFachada" />
            <asp:CommandField HeaderText="Seleccion" ShowSelectButton="true" SelectText="+"/>

        </Columns>
    </asp:GridView>

    <asp:Button ID="btnAgregarDireccionNueva" runat="server" Text="Agregar nueva direccion" CssClass="btn btn-success" OnClick="btnAgregarDireccionNueva_Click" />
    <asp:Button ID="btnModificarDireccion" runat="server" Text="Modificar direccion" CssClass="btn btn-secondary" OnClick="btnModificarDireccion_Click" />
    <asp:Button ID="btnEliminarDireccion" runat="server" Text="Eliminar direccion" CssClass="btn btn-danger" OnClick="btnEliminarDireccion_Click" />

</asp:Content>