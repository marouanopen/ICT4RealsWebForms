<%@ Page Title="Schoonmaak" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="Schoonmaak.aspx.cs" Inherits="ICT4RealsWebForms.Schoonmaak" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainContent">
    <h2><%: Title %></h2>
    <div class="contentbox1">

        <fieldset>
            <legend>Vieze Trams</legend>
            <div class="formitem">
                <label for="lboxDirtyInList">Lijst</label>
                <asp:ListBox ID="lboxDirtyInList" runat="server"></asp:ListBox>
            </div>
        </fieldset>
    </div>

    <div class="contentbox1">
        <fieldset>
            <legend>Schoonmaak Uitvoeren</legend>

            <div class="formitem">
                <label for="ddlTramState">State</label>
                <asp:DropDownList ID="ddlTramState" runat="server">
                    <asp:ListItem Text="Ok" Value="1" Selected="false"></asp:ListItem>
                    <asp:ListItem Text="Kapot" Value="2" Selected="false"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Button ID="btnDetailsAdd" runat="server" Text="Toevoegen" OnClick="btnDetailsAdd_Click" />
        </fieldset>
    </div>

    <div class="contentbox1">
        <fieldset>
            <legend>Schoonmaak Logboek</legend>
            <div class="formitem">

                <label for="lboxTramLog">Lijst</label>
                <asp:ListBox ID="lboxTramLog" runat="server"></asp:ListBox>
            </div>
        </fieldset>
    </div>
    </div>
</asp:Content>
