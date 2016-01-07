<%@ Page Title="Login" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ICT4RealsWebForms.Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainContent">
        <h2><%: Title %></h2>
        <div class="contentbox1">
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
                <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btlogin_Click"/>
            </fieldset>
        </div>
    </div>
</asp:Content>
