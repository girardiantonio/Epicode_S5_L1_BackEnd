<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epicode_S5_L1_BackEnd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dipendenti</h2>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:TemplateField HeaderText="Modifica">
                <ItemTemplate>
                    <asp:Button ID="btnDipendenti" runat="server" Text="Visualizza" OnClick="btnDipendenti_Click" CommandArgument='<%# Eval("ID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <h2>Pagamenti</h2>
    <asp:GridView ID="GridView2" runat="server" CssClass="table table-striped table-bordered">
    </asp:GridView>
</asp:Content>
