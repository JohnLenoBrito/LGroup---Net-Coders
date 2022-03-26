/// <reference path="../JQuery/jquery-1.11.2.min.js" />


function onCadastrarClick() {
    RemoveClassErrorInput();
    RemoveMenssagemError();
    if (ValidaHTML()) {

    }
}

function ValidaHTML() {
    var $txtNome = $('#txtNome');
    var $txtEmail = $('#txtEmail');
    var $txtCep = $('#txtCep');

    var isValido = true;
    // == : Igualdade de valores, somente! Não da um resultado 100% certeza.
    // === : Igualdade de tipo e valor. Mais fiel, da 100% de certeza nos resultados.
    if ($txtNome.val() === '') {
        $txtNome.addClass('errorInput');
        isValido = false;
    }
    if ($txtEmail.val() === '') {
        $txtEmail.addClass('errorInput');
        isValido = false;
    }
    if ($txtCep.val() === '') {
        $txtCep.addClass('errorInput');
        isValido = false;
    }

    //Podemos validar assim:
    //(!isValido)
    //(isValido !== true)
    //(!isValido === false)
    if (!isValido) {
        ShowMenssagemErro();
    }

    return isValido;
}

function ShowMenssagemErro() {
    var $divAlerta = $('#divAlerta');
    var menssagem = '<strong>Erro: </strong>Por favor, preencha os campos indicados abaixo.';
    $divAlerta.html(menssagem);
    //Abaixo, estamos fazendo uma chamada atras da outra (funções).
    //Isso é chamado de encadeamento de funções.
    $divAlerta.addClass("alert").addClass('alert-danger');
}

function RemoveClassErrorInput() {
    //Abaixo, temos outro selector do JQuery, selecionar elementos da
    //página através de class. Colocando "." na frente do nome da class.
    var $listaInputError = $('.errorInput');

    //O JQuery, vai remover as class de todos os elementos que ele
    //encontrou, sem precisar fazer um for e remover um por um.
    $listaInputError.removeClass('errorInput');
}

function RemoveMenssagemError() {
    //Encadeamento de funções:
    //Chamando função HTML
    $('#divAlerta').html("").removeClass('alert').removeClass('alert-danger');
}

function onConsultarCEPBlur() {
    //Outra forma se selecionar elemento HTML na página, é passar um
    //Objeto DOM para o JQury selecionar
    var cep = $(this).val();
    
    AjaxConsultarCEP(cep);
}

function AjaxConsultarCEP(cep) {
    //Requisição Ajax
    //{} = Objeto JavaScript
    $.ajax({
        //Url = É a URL da API que consumi
        url: "http://api.postmon.com.br/v1/cep/" + cep,
        dataType: "JSON",
        //async: Como true, vai ser executado sem ter que travar a apagina.
        //uma requisição que será feito backend;
        //Por default, todas as requisições são assicronas (async = true);
        async: false,
        beforeSend: function (jqXHR, settings) {
            $('#imgLoading').show();
        },
        success: function (data, textStatus, jqXHR) {
            console.log(data);
            PreencheEnderecoAjax(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus);
            var $divAlerta = $('#divAlerta');
            var menssagem = '<strong>Erro: </strong>Erro ao tentar buscar o CEP.</br><i>' + errorThrown.message + '</i>';
            $divAlerta.html(menssagem);
            //Abaixo, estamos fazendo uma chamada atras da outra (funções).
            //Isso é chamado de encadeamento de funções.
            $divAlerta.addClass("alert").addClass('alert-danger');
        },
        complete: function (jqXHR, settings) {
            $('#imgLoading').hide();
        }
    });
}

function PreencheEnderecoAjax(data) {
    $('#txtEndereco').val(data.logradouro);
    $('#txtBairro').val(data.bairro);
    $('#txtEstado').val(data.estado);
    $('#txtCidade').val(data.cidade);
}