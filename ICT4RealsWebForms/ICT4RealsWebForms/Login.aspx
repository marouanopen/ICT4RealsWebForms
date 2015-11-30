<%@ Page Title="" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ICT4RealsWebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset class="Inlog">
        <legend>Inloggen</legend>
            <div class="formitem">
                <label for="tbUserName">Username</label> 
                <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
            </div>
            <div class="formitem">
                <label for="tbPassword">Password</label>
                <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </fieldset>
</asp:Content>
