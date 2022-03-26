//É dentro do controller que fica todo o código em JAVASCRIPT da TELA, toda a programação da tela fica aqui
//Dentro, tudo que vc digitar la no JQUERY é aqui que vc vai colocar
aplicacao.controller("amigoController", function ($scope) {
    //O objeto SCOPE equivale a uma VIEW MODEL ele transfere dados da VIEW pro CONTROLLER e VICE VERSA
    //View BINDING
    $scope.listaAmigos = [{ nome: "Zina da Silva" },
                          { nome: "Bozo de Souza" },
                          { nome: "Bozina dos santos" }];
});