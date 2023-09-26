<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dipendente.aspx.cs" Inherits="Epicode_S5_L1_BackEnd.Dipendente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2>Creazione Dipendente</h2>

        <div class="mb-3">
            <label for="txtNome" class="form-label">Nome:</label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtCognome" class="form-label">Cognome:</label>
            <asp:TextBox ID="txtCognome" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtIndirizzo" class="form-label">Indirizzo:</label>
            <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtCodiceFiscale" class="form-label">Codice Fiscale:</label>
            <asp:TextBox ID="txtCodiceFiscale" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label class="form-label">Stato Coniugato:</label>
            <asp:RadioButtonList ID="rblConiugato" runat="server" CssClass="form-check">
                <asp:ListItem Text="Sì" Value="S"></asp:ListItem>
                <asp:ListItem Text="No" Value="N"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="mb-3">
            <label for="txtNumeroFigli" class="form-label">Numero di Figli a Carico:</label>
            <asp:TextBox ID="txtNumeroFigli" runat="server" CssClass="form-control" type="number" min="0"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtMansione" class="form-label">Mansione:</label>
            <asp:TextBox ID="txtMansione" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="btnSalva" runat="server" Text="Archivia Dipendente" CssClass="btn btn-primary" OnClick="BtnSalva_Click" />
    </div>
</asp:Content>
