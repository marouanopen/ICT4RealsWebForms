<%@ Page Title="Reparatie" Language="C#" MasterPageFile="~/ICT4Reals.Master" AutoEventWireup="true" CodeBehind="Reparatie.aspx.cs" Inherits="ICT4RealsWebForms.Reparatie" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainContent"></div>
    <h2><%: Title %></h2>
    <div class="contentbox1">

        <fieldset>
            <legend>kapote Trams</legend>
            <div class="formitem">
                <label for="lboxBrokeInList">Lijst</label>
                <asp:ListBox ID="lboxBrokeInList" runat="server"></asp:ListBox>
            </div>
        </fieldset>
    </div>
    <div class="formitem">
        <fieldset>
            <legend>Reparatie uitvoeren</legend>
            <div class="formitem">
                <label for="ddlTramState">State</label>
                <asp:DropDownList ID="ddlTramState" runat="server"></asp:DropDownList>
            </div>
           
            <asp:Button ID="btnDetailsAdd" runat="server" Text="Toevoegen" />
        </fieldset>
    </div>

    <div class="formitem">
    </div>



</asp:Content>
