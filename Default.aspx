<%@ Page Title="Hola" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ramiro Luppi</h1>
        <p class="lead">
            Cómo va? Mi nombre es Ramiro y estás viendo mi portfolio personal. ¡Espero que te sea de mucha utilidad!
        </p>
        <p><button id="btnBackendDeveloper" type="button" class="btn btn-warning btn-lg active" role="button" aria-pressed="true" >Backend Developer</button></p>

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Sobre mí.</h2>
            <p>
                Soy estudiante de programación y, después de realizar varios cursos, en 2024 decidí iniciar 
                la carrera de Analista en Programación Universitario en la Universidad Nacional de La Plata. 
                Tengo experiencia en diversos lenguajes y herramientas, y he desarrollado proyectos que 
                demuestran mi capacidad para resolver problemas y adaptarme a distintos desafíos 
                en el desarrollo de software.
            </p>
        </div>
        <div class="col-md-4">
            <h2>Proyectos.</h2>
            <p>
                algunos de los proyectos asjasa
            </p>
            <p>
                <a class="btn btn-default" href="About.aspx">Acceder a proyectos &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contacto.</h2>
            <p>
                <a href="https://www.linkedin.com/in/ramiroluppi" target="_blank" class="text-decoration-none text-dark">
                    <i class="fab fa-linkedin"></i>  LinkedIn.
                </a>
            </p>
            <p>
                <a href="mailto:ramiro_luppi@hotmail.com" class="text-decoration-none text-dark" target="_blank">
                    <i class="fas fa-envelope"></i>  Email.
                </a>
            </p>
            <p>
                <a href="https://github.com/RamLuppi" class="text-decoration-none text-dark" target="_blank">
                    <i class="fab fa-github"></i>  GitHub.
                </a>
            </p>
            <p>
                <a class="btn btn-default" href="Contact.aspx">Formulario de contacto &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
