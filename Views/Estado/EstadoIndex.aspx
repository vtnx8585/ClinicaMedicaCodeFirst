<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoIndex.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Estado.EstadoIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
    <asp:GridView ID="grdEstados" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="IDEstado" DataField="IdEstado" ReadOnly="true" ItemStyle-Width="25px"/>
            <asp:BoundField HeaderText="Nombre De Estado" DataField="Nombre" ReadOnly="true" />
            <asp:BoundField HeaderText="Descripcion De Estado" DataField="Descripcion" ReadOnly="true"/>
            <asp:BoundField HeaderText="Fecha Creacion" DataField="FechaCreacion" ReadOnly="true" />
            <asp:TemplateField ShowHeader="False">                
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="False" Text="Edit" OnClick="btnEditEstado_Click"></asp:LinkButton>
                </ItemTemplate>                                
            </asp:TemplateField> 
        </Columns>
    </asp:GridView>    
    <a href="../Estado/EstadoCreate.aspx">Crear</a>
    <a href="../Estado/EstadoDelete.aspx">Eliminar</a>
</asp:Content>
