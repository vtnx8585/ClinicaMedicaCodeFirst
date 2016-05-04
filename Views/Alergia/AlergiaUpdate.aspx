<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlergiaUpdate.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Alergia.AlergiaUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtIdAlergia" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtNombreAlergia" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtDescripcionAlergia" runat="server"></asp:TextBox>
    <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" OnClick="btnEditAlergia_Click" />
</asp:Content>
