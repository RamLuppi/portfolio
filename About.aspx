<%@ Page Title="Proyectos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AppWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <h2 style="padding-top: 20px;"><%: Title %></h2>
    <div class="card-deck">
        <div class="card">
            
            <div class="card-body">
                <h5 class="card-title">Aplicación de gestión de artículos</h5>
                <p class="card-text">
                    Aplicación de escritorio con C# y .NET para la gestión de artículos de un catálogo comercial, 
                    adaptable a cualquier tipo de comercio. La app permite listar, buscar, agregar, 
                    modificar, eliminar y visualizar detalles de artículos, persistiendo la información 
                    en una base de datos existente. Implementé una arquitectura en capas, con manejo de 
                    excepciones y validaciones para garantizar la robustez del sistema.
                </p>
            </div>
            <img class="card-img-top" src="recursos/imagenes-app-articulos/articulos1.png" alt="Pantalla principal app articulos">
            <div class="card-footer">
                <a class="a-subtitulo" style="text-decoration:none;color:#6c757d" href ="https://github.com/RamLuppi/Product-catalog-App" target="_blank" rel="noopener noreferrer">Acceder al proyecto en GitHub</a>
            </div>
        </div>
        <div class="card">
            
            <div class="card-body">
                <h5 class="card-title">Aplicación de gestión de tickets</h5>
                <p class="card-text">
                    Aplicación de escritorio en Python para la gestión de tickets. 
                    Permite generar y leer tickets de manera sencilla, asignando un número aleatorio 
                    a cada ticket y almacenando los datos en archivos locales. Incluye un menú 
                    interactivo para crear nuevos tickets y consultar información existente.
                </p>
            </div>
            <img class="card-img-top" src="recursos/imagenes-ticketera/tickets-pantalla-principal.png" alt="Pantalla principal ticketera">
            <div class="card-footer">
                <a class="a-subtitulo" style="text-decoration:none;color:#6c757d"  href ="https://github.com/RamLuppi/ticketera-python" target="_blank" rel="noopener noreferrer">Acceder al proyecto en GitHub</a>
            </div>
        </div>
        <div class="card">
            
            <div class="card-body">
                <h5 class="card-title">Cuenta de twitter Automatizada</h5>
                <p class="card-text">
                    Este script consulta si Estudiantes o Gimnasia tienen partidos en una fecha específica y 
                    publica automáticamente la información en Twitter. Se ejecuta diariamente en PythonAnywhere.
                </p>
            </div>
            <img class="card-img-top" src="recursos/imagen-bot_twitter/ejemplos-twits-automatizados.png" alt="Cuenta twitter">
            <div class="card-footer">
                <a class="a-subtitulo" style="text-decoration:none;color:#6c757d"  href ="https://github.com/RamLuppi/bot_twitter" target="_blank" rel="noopener noreferrer">Acceder al proyecto en GitHub</a>
            </div>
            <div class="card-footer">
                <a class="a-subtitulo" style="text-decoration:none;color:#6c757d"  href ="https://github.com/RamLuppi/bot_twitter target="_blank" rel="noopener noreferrer">Acceder a la cuenta de Twitter</a>
            </div>
        </div>
    </div>
</asp:Content>
