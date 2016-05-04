<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoCreate.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Estado.EstadoCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">  
    <asp:Label ID="lblEstadoMensaje" runat="server" Visible="false"></asp:Label>
    <br />
    <asp:Label ID="lblNombreEstado" runat="server" Text="Estado Nombre:"></asp:Label>
    <asp:TextBox ID="txtNombreEstado" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDescripcionEstado" runat="server" Text="Descripcion"></asp:Label>
    <asp:TextBox ID="txtDescripcionEstado" runat="server"></asp:TextBox>
    <br />    
    <asp:Button ID="btnIngresarEstado" runat="server" Text="Ingresar" OnClick="btnIngresarEstado_Click" />
</asp:Content>
