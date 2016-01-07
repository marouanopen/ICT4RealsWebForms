<%@ Page Title="In Uit Rij" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="InUitRij.aspx.cs" Inherits="ICT4RealsWebForms.InUitRij" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainContent">
        <h2><%: Title %></h2>
        <div class="contentbox1">
            <fieldset>
            <legend>Inrijden</legend>
                <div class="formitem">
                    <label for="tbTramnr">Tram number</label> 
                    <asp:TextBox ID="tbTramnr" runat="server"></asp:TextBox>
                </div>
                <div class="formitem">
                    <label for="ddlStatus">Status</label>
                    <asp:DropDownList ID="ddlStatus" runat="server"></asp:DropDownList>
                </div>
                <asp:Button ID="btnRegister" runat="server" Text="Registreren" OnClick="btnIncomingTram_Click" />
            </fieldset>
        </div>
        <div class="contentbox1">
            <fieldset>
                <legend>Spoornummer</legend>
                <asp:Label ID="lblBigLabel" runat="server" Text="Nr." Font-Size="XX-Large"></asp:Label>
            </fieldset>
        </div>
        <div class="contentbox1">
        <fieldset>
        <legend>Uitrijden</legend>
            <div class="formitem">
                <label for="ddlTram">Tram</label>
                <asp:DropDownList ID="ddlTramOut" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnFree" runat="server" Text="Uitrijden" OnClick="btnUitrijden_Click" />
        </fieldset>
        </div>
    </div>
</asp:Content>
