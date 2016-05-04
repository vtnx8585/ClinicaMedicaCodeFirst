<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoDelete.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Estado.EstadoDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">    
    <asp:GridView ID="grdEstados" runat="server" AutoGenerateColumns="False">
        <Columns>                        
            <asp:BoundField HeaderText="Id" DataField="IdEstado" ReadOnly="true" />
            <asp:BoundField HeaderText="Nombre De Estado" DataField="Nombre" ReadOnly="true" />
            <asp:BoundField HeaderText="Descripcion De Estado" DataField="Descripcion" ReadOnly="true" Visible="true" />
            <asp:BoundField HeaderText="Fecha Creacion" DataField="FechaCreacion" ReadOnly="true" />            
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" Text="Delete" OnClick="btnDeleteEstado_Click"></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
