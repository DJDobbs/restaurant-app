﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="restaurant_app.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="CartDisplay" runat="server">
        
    </div>
    <asp:Button ID="Button1" runat="server" OnClick="placeOrder" Text="Place Order" />
    <asp:Button ID="Button2" runat="server" OnClick="emptyCart" Text="Empty Cart" />
</asp:Content>
