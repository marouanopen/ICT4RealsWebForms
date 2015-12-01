<%@ Page Title="" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="InUitRij.aspx.cs" Inherits="ICT4RealsWebForms.InUitRij" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset class="Acces">
        <legend>Inrijden</legend>
            <div class="formitem">
                <label for="tbTramnr">Tram number:</label> 
                <asp:TextBox ID="tbTramnr" runat="server"></asp:TextBox>
            </div>
            <div class="formitem">
                <label for="ddlStatus">Status</label>
                <asp:DropDownList ID="ddlStatus" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnRegister" runat="server" Text="Registreren" OnClick="btnIncomingTram_Click" />
        </fieldset>

        <fieldset class="BigLabel">
            <asp:Label ID="lblBigLabel" runat="server" Text="Nr." Height="200px" Width="150px"></asp:Label>
        </fieldset>

        <fieldset class="Free">
        <legend>Uitrijden</legend>
            <div class="formitem">
                <label for="ddlTram">Tram</label>
                <asp:DropDownList ID="ddlTramOut" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnFree" runat="server" Text="Uitrijden" OnClick="btnUitrijden_Click" />
        </fieldset>

</asp:Content>
