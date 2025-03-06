<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tabla.aspx.cs" Inherits="AppWeb.Formulario_web11" %>

<asp:Content ID="TablaDirecciones" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>

    <%if (Calle != "" && Numero != "" && Departamento != "")
        {%>
        <h2>Bienvenido!!</h2>
        <asp:Label ID="lblDireccionCompleta" Text="" runat="server"></asp:Label>
        <a href="Tabla2.aspx">Ver tabla de direcciones</a>
    <%}
    else
    {%>            
        <h2>No has ingresado correctemente la direccion :(</h2>
        <a href="PagBotones.aspx">Ingresar direccion</a>
    <%} %>
    

    
</asp:Content>
