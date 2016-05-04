<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlergiaIndex.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Alergia.AlergiaIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblAlergiTitulo" runat="server" Text="Catalogo de Alergias"></asp:Label>
    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
    <asp:GridView ID="grdAlergias" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="IDAlergia" DataField="IdAlergia" ReadOnly="true" ItemStyle-Width="25px"/>
            <asp:BoundField HeaderText="Nombre De Estado" DataField="Nombre" ReadOnly="true" />
            <asp:BoundField HeaderText="Descripcion De Estado" DataField="Descripcion" ReadOnly="true"/>
            <asp:BoundField HeaderText="Fecha Creacion" DataField="FechaCreacion" ReadOnly="true" />
            <asp:TemplateField ShowHeader="False">                
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="False" Text="Edit" OnClick="btnEditAlergia_Click"></asp:LinkButton>
                </ItemTemplate>                                
            </asp:TemplateField> 
        </Columns>
    </asp:GridView>    
    <a href="../Estado/AlergiaCreate.aspx">Crear</a>
    <a href="../Estado/AlergiaDelete.aspx">Eliminar</a>
</asp:Content>
