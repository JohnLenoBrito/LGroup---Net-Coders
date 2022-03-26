<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMape/Root.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="SondaIT.CodeFirst.FluentAPI.UI.Web.Modules.Listar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Listagem de Registros</h1>
    <br />
    <fieldset>
        <legend>..:: Filtrar Registro ::..</legend>
        <br />
        <asp:Label Text="Nome" runat="server" />
        &nbsp;
        <asp:TextBox runat="server" ID="txtFiltro" />
        &nbsp;
        <asp:Button Text="Filtro" ID="btnFiltro" runat="server" OnClick="btnFiltro_Click" />
    </fieldset>
    <br />
    <br />
    <asp:GridView runat="server" CssClass="table table-hover " ID="gvLista"></asp:GridView>
</asp:Content>
