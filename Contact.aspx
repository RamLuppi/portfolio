<%@ Page Title="Formulario de contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AppWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2 style="padding-top: 20px;">Contactame.</h2>
        <!-- Formulario con ancho definido y estilos modernos -->
        <div style="max-width: 600px; margin: 0 auto; padding: 20px; border-radius: 8px; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);">
            <!-- Campo Nombre -->
            <div class="form-group mb-3">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre" />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" required />
            </div>

            <!-- Campo Email -->
            <div class="form-group mb-3">
                <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail" />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" required />
            </div>

            <!-- Campo Mensaje -->
            <div class="form-group mb-4">
                <asp:Label ID="lblMensaje" runat="server" Text="Mensaje:" AssociatedControlID="txtMensaje" />
                <asp:TextBox ID="txtMensaje" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" required />
            </div>

            <!-- Botón Enviar centrado dentro del formulario -->
            <div">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-success px-4" OnClick="btnEnviar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
