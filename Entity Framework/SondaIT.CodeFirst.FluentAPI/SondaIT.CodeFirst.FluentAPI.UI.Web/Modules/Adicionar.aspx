<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMape/Root.Master" AutoEventWireup="true" CodeBehind="Adicionar.aspx.cs" Inherits="SondaIT.CodeFirst.FluentAPI.UI.Web.Modules.Adicionar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- Aqui deixamos os nossos scripts JavaScript JQuery, Link CSS BOOTSTRAP --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Formluarío de adicionar</h1>
    <br />
    <fieldset>
        <legend>DADOS DO CLIENTE</legend>
        <br />
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
            <ajaxToolkit:MaskedEditExtender ID="txtRG_MaskedEditExtender" runat="server" BehaviorID="txtRG_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="99,999,999-9" TargetControlID="txtRG" />
        </div>
        <div>
            <asp:Label Text="CPF" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtCPF" CssClass="form-control" Width="20%" />
            <ajaxToolkit:MaskedEditExtender ID="txtCPF_MaskedEditExtender" runat="server" BehaviorID="txtCPF_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="999,999,999-99" TargetControlID="txtCPF" />
        </div>
        <div>
            <asp:Label Text="Data Nascimento" runat="server" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtDataNascimento" CssClass="form-control" Width="30%" />
            <ajaxToolkit:CalendarExtender ID="txtDataNascimento_CalendarExtender" runat="server" BehaviorID="txtDataNascimento_CalendarExtender" TargetControlID="txtDataNascimento" />
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
            <ajaxToolkit:MaskedEditExtender ID="txtSalario_MaskedEditExtender" runat="server" BehaviorID="txtSalario_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="9999,99" TargetControlID="txtSalario" />
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
        <asp:Button Text="Cadastrar" ID="btnCadastrar" runat="server" CssClass="btn btn-info" OnClick="btnCadastrar_Click" />
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true">
        </asp:ScriptManager>
    </fieldset>
</asp:Content>
