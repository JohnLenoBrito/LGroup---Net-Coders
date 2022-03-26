//O angular trabalha com a tecnica de ROTAS
//Criamos apelidos (URL AMIGAVEIS) para redirecionar pras
//Páginas
//Cada página vai ter uma URL AMIGAVEL (LEMBRAR MUITO O MVC)
//ROUTCONFIG.cs

//Inicializamos a nossa aplicação em ANGULAR
//O angular trabalha com a tecnica de DI(Injeção de Dependencia)
//Sempre que você precisar utilizar alguma biblioteca
//Importa ela e INJETA dentro da APP
//ngRoute -> Vai vir Injetado vai vir la da biblioteca
//Angular-route
var aplicacao = angular.module("SISAMIGOS", ["ngRoute"]);

//Definimos as ROTAS(URL'S AMIGAVEIS)
aplicacao.config(function ($routeProvider) {

    //Aqui dentro definimos as ROTAS
    //JS -> ngRoute -> $roteProvider
    //Tudo que começa com CIFRÃO não é JQUERY
    //São objetos nativos do ANGULAR
    //Caso o usuario não digite nenhuma URL definidas nos WHENS
    //Vai pra URL padrao que esta dentro do OTHERWISE
    $routeProvider.when("/listar", { templateUrl: "App/Views/listar.html", controller: "amigoController" })
                  .when("/cadastrar", { templateUrl: "App/Views/cadastrar.html", controller: "amigoController" })
                  .otherwise({ redirectTo: "/listar" });

});