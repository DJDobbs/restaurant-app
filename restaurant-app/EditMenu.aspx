<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditMenu.aspx.cs" Inherits="restaurant_app.EditMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Label runat="server">Name</asp:Label>
        <asp:TextBox ID ="tbName" runat="server"></asp:TextBox>
        <asp:Label runat="server">Price</asp:Label>
        <asp:TextBox ID ="tbPrice" runat="server"></asp:TextBox>
        <asp:Label runat="server">Ingredients</asp:Label>
        <asp:TextBox ID ="tbIngredients" runat="server"></asp:TextBox>
        <asp:Label runat="server">Allergens</asp:Label>
        <asp:TextBox ID ="tbAllergens" runat="server"></asp:TextBox>
        <asp:Button ID="bnAddMenuItem" runat="server" Text="Add Menu Item" onclick="addMenuItem"/>
        <asp:Button ID="bnRemoveMenuItem" runat="server" Text="Remove Menu Item" onclick="removeMenuItem"/>
</asp:Content>
