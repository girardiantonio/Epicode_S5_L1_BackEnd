<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagamenti.aspx.cs" Inherits="Epicode_S5_L1_BackEnd.Pagamenti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex">
        <div>
            <h2>Registra Pagamento</h2>
            <div class="form-group mb-3">
                <label for="txtDipendenteID">ID Dipendente:</label>
                <asp:TextBox ID="txtDipendenteID" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group mb-3">
                <label for="txtDataPagamento">Data Pagamento:</label>
                <asp:TextBox ID="txtDataPagamento" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group mb-3">
                <label for="txtAmmontare">Ammontare:</label>
                <asp:TextBox ID="txtAmmontare" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group mb-3">
                <label for="ddlTipoPagamento">Tipo Pagamento:</label>
                <asp:DropDownList ID="ddlTipoPagamento" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Stipendio" Value="Stipendio" />
                    <asp:ListItem Text="Acconto" Value="Acconto" />
                </asp:DropDownList>
            </div>
            <asp:Button ID="btnSalvaPagamento" runat="server" Text="Salva Pagamento" OnClick="btnSalvaPagamento_Click" CssClass="btn btn-primary" />
        </div>
        <div class="mx-5">
            <h2>Elimina Dipendente</h2>
            <asp:Button ID="btnEliminaDipendente" runat="server" Text="Elimina Dipendente" OnClick="btnEliminaDipendente_Click" CssClass="btn btn-danger" />
        </div>
    </div>
</asp:Content>
