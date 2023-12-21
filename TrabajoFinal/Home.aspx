<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaInicial.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TrabajoFinal.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="Style/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="div-encuesta">
            <img src="Imagenes/HomeEcuesta.png" alt="Encuesta">
            <a href="#">Ingresa Aquí</a>
        </div>
        <h1 class="sub-title">Cursos Interesantes</h1>
        <div class="card-list">
            <a href="#" class="card-item">
                <img src="Imagenes/HomeProgramador.png" alt="Card Image">
                <span class="developer">LENG DE PROGRAMACION - JAVA</span>
                <h3>Introducción a Java y programación orientada a objetos. Cubre conceptos fundamentales y habilidades prácticas para desarrollar aplicaciones robustas.</h3>
                <div class="arrow">
                    <i class="fas fa-arrow-right card-icon"></i>
                </div>
            </a>
            <a href="#" class="card-item">
                <img src="Imagenes/HomeMantenimiento.png" alt="Card Image">
                <span class="designer">REP Y MANT DE HARDWARE</span>
                <h3>Aprende a reparar y mantener hardware informático. Identificación y solución de problemas, actualizaciones y eficiencia del sistema.</h3>
                <div class="arrow">
                    <i class="fas fa-arrow-right card-icon"></i>
                </div>
            </a>
            <a href="#" class="card-item">
                <img src="Imagenes/HomeBaseDatos.png" alt="Card Image">
                <span class="editor">BASE DE DATOS AVANZADO</span>
                <h3>Explora conceptos avanzados en bases de datos. Enfocado en diseño eficiente, consultas complejas y optimización del rendimiento.</h3>
                <div class="arrow">
                    <i class="fas fa-arrow-right card-icon"></i>
                </div>
            </a>
        </div>
        <div class="content-links">
            <div class="content-1">
                <a href="#">Oficinas y Centros
                </a>
            </div>
            <div class="content-2">
                <a href="#">Calendario Academico
                </a>

            </div>
            <div class="content-3">
                <a href="#">Directores Academicos
                </a>
            </div>
            <div class="content-4">
                <a href="#">Servicios
                </a>
            </div>
        </div>
    </section>
</asp:Content>
