// [] = Estamos criando uma variavel global, do tipo Array.
// {} = Criação de objetos.
var ListCidades = [
{ texto: "São Paulo", valor: "SP" },
{ texto: "Rio de Janeiro", valor: "RJ" },
{ texto: "Minas Gerais", valor: "MG" },
{ texto: "Bahia", valor: "BA" }
];


var ListClientes = [];

function onCadastrarClick() {
    RemoveMensagemErro();
    RemoveClassErrorInput();
    if (Validacao()) {

        var txtNome = document.getElementById('txtNome');
        var txtTelefone = document.getElementById('txtTelefone');
        var txtEmail = document.getElementById('txtEmail');
        var ddlCidade = document.getElementById('ddlCidade');
        var ckbAtivo = document.getElementById('ckbAtivo');

        //Atribuindo um objeto em JavaScrit
        var cliente = {};
        cliente.Nome = txtNome.value;
        cliente.Telefone = txtTelefone.value;
        cliente.Email = txtEmail.value;
        cliente.Cidade = ddlCidade.value;
        cliente.IsAtivo = ckbAtivo.checked;

        LimparCampos();

        ListClientes.push(cliente);

        MensagemSucesso();

        ListarClientes();
    }
}

function Validacao() {
    var isValidado = true;

    var txtNome = document.getElementById('txtNome');
    var txtTelefone = document.getElementById('txtTelefone');
    var txtEmail = document.getElementById('txtEmail');
    var ddlCidade = document.getElementById('ddlCidade');

    // == : É a igual de valor, somente. Mesmo sendo
    // em tipos diferentes. Não da total certeza no
    // resultado.

    // === : É uma igualdade de valores e tipo! É mais
    // fiel nos resultados.

    if (txtNome.value === '') {
        isValidado = false;
        txtNome.classList.add('errorInput');
    }

    if (txtTelefone.value === '') {
        isValidado = false;
        txtTelefone.classList.add('errorInput');
    }

    if (txtEmail.value === '') {
        isValidado = false;
        txtEmail.classList.add('errorInput');
    }

    if (ddlCidade.value === '') {
        isValidado = false;
        ddlCidade.classList.add('errorInput');
    }

    if (!isValidado) {
        MenagemErro();
    }

    return isValidado;
}

function RemoveClassErrorInput() {
    var listImputComClass = document.getElementsByClassName('errorInput');

    var index = 0;
    while (listImputComClass.length > 0) {
        listImputComClass[index].classList.remove('errorInput');
    }
}

function MenagemErro() {
    var mensagem = '<strong>Atenção: </strong>' + 'Por favor, prencha os campos identificados abaixo.';

    AtribuiMensagem(mensagem);

    var divAlert = document.getElementById('divAlert');
    divAlert.classList.add('alert');
    divAlert.classList.add('alert-danger');
}

function RemoveMensagemErro() {
    AtribuiMensagem('');

    var divAlert = document.getElementById('divAlert');
    divAlert.classList.remove('alert');
    divAlert.classList.remove('alert-danger');
}

function AtribuiMensagem(mensagem) {
    var divAlert = document.getElementById('divAlert');
    divAlert.innerHTML = mensagem;
}

function PreencheCidade() {
    var options = '<option value="">-- Selecione --</option>';
    var ddlCidade = document.getElementById('ddlCidade');
    for (var i = 0; ListCidades.length > i; i++) {
        options += '<option value ="' + ListCidades[i].valor + '">' + ListCidades[i].texto + '</option>';
    }
    ddlCidade.innerHTML = options;
}

function MensagemSucesso() {
    var mensagem = '<strong>Sucesso: </strong>' + 'Cliente cadastrado com sucesso';

    AtribuiMensagem(mensagem);

    var divAlert = document.getElementById('divAlert');
    divAlert.classList.add('alert');
    divAlert.classList.add('alert-success');

    setTimeout(RemoveMensagemSucesso, 5000);
}

function RemoveMensagemSucesso() {
    AtribuiMensagem('');

    var divAlert = document.getElementById('divAlert');
    divAlert.classList.remove('alert');
    divAlert.classList.remove('alert-success');

}

function LimparCampos() {
    document.getElementById('txtNome').value = '';
    document.getElementById('txtTelefone').value = '';
    document.getElementById('txtEmail').value = '';
    document.getElementById('ddlCidade').selectedIndex = 0;
    document.getElementById('ckbAtivo').checked = false;
}

function ListarClientes() {
    var tbodyListaCliente = document.getElementById('tbodyListaCliente');
    var bodyTable = '';

    for (var i = 0; ListClientes.length > i; i++) {
        bodyTable += '<tr>';
        bodyTable += '<td>';
        bodyTable += (i + 1).toString();
        bodyTable += '</td>';
        bodyTable += '<td>';
        bodyTable += ListarClientes[i].Nome;
        bodyTable += '</td>';
        bodyTable += '<td>';
        bodyTable += ListarClientes[i].Telefone;
        bodyTable += '</td>';
        bodyTable += '<td>';
        bodyTable += ListarClientes[i].Email;
        bodyTable += '</td>';
        bodyTable += '<td>';
        bodyTable += ListarClientes[i].Cidade;
        bodyTable += '</td>';
        bodyTable += '<td>';
        bodyTable += ListarClientes[i].IsAtivo;
        bodyTable += '</td>';
        bodyTable += '</tr>';
    }

    tbodyListaCliente.innerHTML = bodyTable;
}