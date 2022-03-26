//Similar ao ASP.NET MVC aqui temos arquivos de controllers
//É onde vai ficar toda a programação da tela (js)
//Limpa os campos, acessa um serviço
//Pra manipular os dados dos campos da tela
//E até mesmo pegar eventos (click)
//Utilizamos o objeto $SCOPE
aplicacao.controller("amigoController", function ($scope, $rootScope, $location) {

    //Criamos 2 funções dentro do objeto scope
    //Pra subir (interceptar) o click dos botôes
    //Equivaleria a grosso MODO um MODEL LA NO MVC
    $scope.clickLimpar = function () {
        $scope.nome = "";
        $scope.email = "";
        $scope.telefone = "";
        $scope.data = "";
    };

    $scope.clickCadastrar = function () {
        alert("Amigo Cadastrado com Sucesso");
        $scope.clickLimpar();
    };

    $scope.clickCarregar = function () {

        //Simulamos uma lista em memoria
        $scope.listaAmigos = [
            { Codigo: "1", Nome: "Zina", Email: "ZinaMen@gmail.com", Telefone: "(11) 3849-39394", Data: "09/12/1988" },
            { Codigo: "2", Nome: "Ronaldo", Email: "Ronaldo@gmail.com", Telefone: "(17) 5474-39394", Data: "27/10/1964" }
        ];
    };

    //Criamos uma função via angular
    //para outras paginas (ROTAS)
    //Tomar cuidado com campos com manipulações que ficam
    //Na pagina principal na INDEX, como não tem controller
    //Para abrir ela só conseguimos manipular os campos dela
    //Via ESCOPO GLOBAL (ROOTSCOPE)
    //ROOTSCOPE -> SESSION -> TEMPDATA
    $rootScope.redirecionar = function (caminhoPagina) {
        
        //Levamos o usuário pra URL enviada via parametro
        $location.path(caminhoPagina);

    };

    $scope.clickExcluir = function (amigoCorrente, posicaoLinha) {

        //Excluimos a linha do GRID
        //Splice é para remover itens de uma coleção (ARRAY)
        //1-> Posição inicial
        //2-> Quantos registros vai remover a partir da posição
        //Inicial
        $scope.listaAmigos.splice(posicaoLinha, 1);

    };
});