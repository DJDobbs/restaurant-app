<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditMenu.aspx.cs" Inherits="restaurant_app.EditMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="AddItem" runat="server">
        <form>
            Name: <input type="text" name="name"><br>
            Price: <input type="text" name="price"><br>
            Ingredients: <input type="text" name="ingredients"><br>
            Allergens: <input type="text" name="allergens"><br>
             <input type="submit" value="Add Item to Menu">
        </form>
    </div>
    <div id="RemoveItem" runat="server">
        <form>
            Name: <input type="text" name="name"><br>
             <input type="submit" value="Remove Item from Menu">
        </form>

    </div>
</asp:Content>
