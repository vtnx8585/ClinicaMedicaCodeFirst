<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlergiaCreate.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Alergia.AlergiaCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblEstadoMensaje" runat="server" Visible="false"></asp:Label>
    <br />
    <asp:Label ID="lblNombreAlergia" runat="server" Text="Alergia Nombre:"></asp:Label>
    <asp:TextBox ID="txtNombreAlergia" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDescripcionAlergia" runat="server" Text="Descripcion Alergia"></asp:Label>
    <asp:TextBox ID="txtDescripcionAlergia" runat="server"></asp:TextBox>
    <br />    
    <asp:Button ID="btnIngresarEstado" runat="server" Text="Ingresar" OnClick="btnIngresarAlergia_Click" />
</asp:Content>
