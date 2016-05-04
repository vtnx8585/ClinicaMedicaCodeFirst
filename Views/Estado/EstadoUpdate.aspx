<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoUpdate.aspx.cs" Inherits="ClinicaMedicaCodeFirst.Views.Estado.EstadoUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">    
    <asp:TextBox ID="txtIdEstado" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtNombreEstado" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtDescripcionEstado" runat="server"></asp:TextBox>
    <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" OnClick="btnEditEstado_Click" />
    <%--<asp:GridView ID="grdEstados" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="IDEstado" DataField="IdEstado" ReadOnly="true" ItemStyle-Width="25px" />                         
            <asp:BoundField HeaderText="Nombre De Estado" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion De Estado" DataField="Descripcion"/>
            <asp:BoundField HeaderText="Fecha Creacion" DataField="FechaCreacion" ReadOnly="true" />
            <asp:TemplateField ShowHeader="False">                
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="False" Text="Edit" OnClick="btnEditEstado_Click"></asp:LinkButton>
                </ItemTemplate>                                
            </asp:TemplateField>            
        </Columns>
    </asp:GridView>  --%>   
</asp:Content>
