<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMape/Root.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="SondaIT.CodeFirst.FluentAPI.UI.Web.Modules.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Formaluarío de edição</h1>
    <br />
    <fieldset>
        <legend>DADOS DO CLIENTE</legend>
        <br />
        <div>
            <asp:Label Text="ID" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtID" CssClass="form-control" Width="10%" />
            <asp:Button Text="Pesquisa" ID="btnPesquisa" runat="server" CssClass="btn btn-info" OnClick="btnPesquisa_Click" />
        </div>
        <div>
            <asp:Label Text="NOME" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" Width="50%" />
        </div>
        <div>
            <asp:Label Text="RG" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtRG" CssClass="form-control" Width="20%" />
        </div>
        <div>
            <asp:Label Text="CPF" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtCPF" CssClass="form-control" Width="20%" />
        </div>
        <div>
            <asp:Label Text="Data Nascimento" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtDataNascimento" CssClass="form-control" Width="30%" />
        </div>
        <div>
            <asp:Label Text="Email" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" Width="50%" />
        </div>
        <div>
            <asp:Label Text="Salario" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtSalario" CssClass="form-control" Width="20%" />
        </div>
        <div>
            <asp:Label Text="PIS" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtPis" CssClass="form-control" Width="20%" />
        </div>
        <div>
            <asp:Label Text="CEP" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtCep" CssClass="form-control" Width="20%" />
        </div>
        <div>
            <asp:Label Text="Endereço" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtEndereco" CssClass="form-control" Width="50%" />
        </div>
        <div>
            <asp:Label Text="Estado Civil" runat="server" />
        </div>
        <div>
            <asp:DropDownList runat="server" ID="ddlEstadoCivil" CssClass="form-control" Width="30%">
                <asp:ListItem Value="0">Selecione</asp:ListItem>
                <asp:ListItem Value="1">Casado</asp:ListItem>
                <asp:ListItem Value="2">Solteiro</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label Text="Sexo" runat="server" />
        </div>
        <div>
            <asp:DropDownList runat="server" ID="ddlSexo" CssClass="form-control" Width="30%">
                <asp:ListItem Value="0">Selecione</asp:ListItem>
                <asp:ListItem Value="1">Masculino</asp:ListItem>
                <asp:ListItem Value="2">Feminino</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button Text="Atualizar" ID="btnAtualizar" runat="server" CssClass="btn btn-info" OnClick="btnAtualizar_Click" />
        &nbsp;
        <asp:Button Text="Deletar" ID="btnDeletar" runat="server" CssClass="btn btn-warning" OnClick="btnDeletar_Click" />
    </fieldset>
</asp:Content>
