<%@ Page Title="Beheer" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="Beheer.aspx.cs" Inherits="ICT4RealsWebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainContent"></div>
    <aside>
        <h2><%: Title %></h2>
        <fieldset>
            <legend>Tram Details</legend>
            <div class="formitem">
                <label for="tbDetailsName">Naam</label> 
                <asp:TextBox ID="tbDetailsName" runat="server"></asp:TextBox>
            </div>
            <div class="formitem">
                <label for="ddlDetailsLocation">Locatie</label>
                <asp:DropDownList ID="ddlDetialsLocation" runat="server"></asp:DropDownList>
            </div>
            <div class="formitem">
                <label for="ddlDetailsStatus">Status</label>
                <asp:DropDownList ID="ddlDetailsStatus" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnDetailsRemove" runat="server" Text="Verwijderen" />
            <asp:Button ID="btnDetailsEdit" runat="server" Text="Aanpassen" />
        </fieldset>
        <fieldset>
            <legend>Tram Toevoegen</legend>
            <div class="formitem">
                <label for="tbAddName">Naam</label> 
                <asp:TextBox ID="tbAddName" runat="server"></asp:TextBox>
            </div>
            <div class="formitem">
                <label for="ddlAddLocation">Locatie</label>
                <asp:DropDownList ID="ddlAddLocation" runat="server"></asp:DropDownList>
            </div>
            <div class="formitem">
                <label for="ddlAddStatus">Status</label>
                <asp:DropDownList ID="ddlAddStatus" runat="server"></asp:DropDownList>
            </div>
            <div class="formitem">
                <label class="checkbox" for="cbAddOnTrack"><asp:CheckBox ID="cbAddOnTrack" runat="server" />Op spoor</label>
            </div>
            <asp:Button ID="btnAddSubmit" runat="server" Text="Verwijderen" />
        </fieldset>
        <fieldset>
            <legend>Spoor Status</legend>
            <div class="formitem">
                <label for="ddlStatusTrack">Spoor</label> 
                <asp:DropDownList ID="ddlStatusTrack" runat="server"></asp:DropDownList>
            </div>
            <div class="formitem">
                <label for="ddlStatusStatus">Status</label>
                <asp:DropDownList ID="ddlStatusStatus" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnStatus" runat="server" Text="Aanpassen" />
        </fieldset>
        <fieldset>
            <legend>Inrijdende Trams</legend>
            <div class="formitem">
                <label for="lboxDriveInList">Lijst</label> 
                <asp:ListBox ID="lboxDriveInList" runat="server"></asp:ListBox>
            </div>
            <div class="formitem">
                <label for="ddlDriveInLocation">Locatie</label>
                <asp:DropDownList ID="ddlDriveInLocation" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnDriveInAssign" runat="server" Text="Toewijzen" />
        </fieldset>
    </aside>
</asp:Content>
