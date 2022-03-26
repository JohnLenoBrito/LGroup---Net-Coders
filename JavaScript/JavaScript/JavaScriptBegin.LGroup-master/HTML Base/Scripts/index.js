function SetAno() {
    //debugger = É uma palavra chave do JavaScript que, quando o navegador
    //identificar essa palavra, vai para a execução. Debbuger do JS.
    debugger;
    // Abaixo estamos pegando o DOM da Label que esta no Footer
    var lblTime = document.getElementById("lblTimeYear");
    // Atribuindo um texto para a label
    lblTime.textContent = "2015";
}

function CarregaNoOnLoadDaPagina() {
    SetAno();
    PreencheCidade();
}

//window.onload = É um evento da pagína que será execultado
//quando todos os elementos HTML's forem renderizados.
window.onload = CarregaNoOnLoadDaPagina;