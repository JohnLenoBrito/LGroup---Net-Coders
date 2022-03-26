/// <reference path="../JQuery/jquery-1.11.2.min.js" />

//$(document).ready = Função JQuery que vai ser executado
//após a pagina ser renderizada.
$(document).ready(
    //Passando para a pagina a funçaõ ready do JQuery, uma outra função anonima.
    function () {
        SetAno();
        SetOnBlurCEP();
    });

function SetAno() {
    //debugger: É uma palavra reservada do JavaScript
    //para sinalizar o navegador a aparar a execução quando ele
    //passar por ela, quando estiver com F12 (console) aberto.
    //debugger;
    //Pegando um elemento HTML da página através do ID.,
    //No JQuery, para identificar o ID do elemento, coloca-se # na
    //frente do nome do ID.
    var $lbltimeNow = $('#lbltimeNow');//Por boa pratica, coloca-se $ na frente de uma variavel que contem um objeto JQuery.
    $lbltimeNow.text('2015');
}

//Essa função abaixo, estamos atribuindo ao txtCep um elemento blur(onblur).
//E a função onConsultarCEPBlur() esta em outro arquivo, abaixo deste.
//Isso é possivel, porque será executado após a página ser renderizado.
function SetOnBlurCEP() {
    var $txtCep = $('#txtCep');
    // Passando para o evento Blur uma função por
    // Parametro
    $txtCep.blur(onConsultarCEPBlur);
}