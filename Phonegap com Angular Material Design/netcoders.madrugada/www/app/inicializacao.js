/// <reference path="../node_modules/angular-route/angular-route.js" />
/// <reference path="../node_modules/angular/angular.js" />

//Baixamos o Angula via NPM, angular é um FRAMEWORK MVC e MVVM (Nome Carinhoso MVW (Whatever))
//Da pra trabalhar tanto com CONTRLLERS quanto com o ESTILO SPA
//JQUERY é um LIXO (Biblioteca)
//ANGULAR é um FRAMEWORK (Controllers, Views, Pagina Pai e Filha, Scope, RootScope, Services, Dependency Injection)

//Inicializamos a nossa aplicação em ANGULAR
//O ANULAR por padrão trabalha com injeção de dependencia, ele é todo desacoplado, sempre que baixamos algum modulo
//temos que injetar dentro da aplicação
//pra trabalhar com o modulo de rotas injetamos o serviço, objeto ngROUTE é ele quem habilita os comandos de definição e interpretação
//de rotas (url amigaveis)
//GOOGLE, NPM ou olha o arquivo e pega o NAME
var aplicacao = angular.module("MADRUGADA", ["ngRoute", "ngMaterial", "ngMdIcons"]);

//Quando trabalhamos com SPA nós não navegamos diretamente nas paginas, pra cada pagina que quisermos abrir, navegar temos que
//dar 1 apelido
//É o conceito de URLS AMIGAVEIS o usuario navega no apelido e o apelido redireciona pra pagina (Tela Fisica)
//Pra trabalhar com URLS AMIGAVEIS (ROTAS, REDIRECIONAMENTOS) baixamos o módulo (pacote) angular-route
//NPM INSTALL ANGULAR-ROUTE
//Essa parte lembra muito o arquivo ROUTECONFIG.cs lá no MVC
aplicacao.config(function ($routeProvider) {
    //O objeto $routeProvider desceu do modulo NGROUTE
    //Definimos 1 URL AMIGAVEL pra CADA PAGINA
    //Ao capturar uma rota temos que passar 3 parametros
    //NOME DO CONTROLLER

    //NOME DA VIEW
    $routeProvider.when("/home", { controller: "homeController", templateUrl: "app/views/home.html" })
                  .when("/amigo/listar", { controller: "amigoController", templateUrl: "app/views/amigos/listar.html" })
                  .when("/amigo/cadastrar", { controller: "amigoController", templateUrl: "app/views/amigos/cadastrar.html" });

    //Definimos a rota padrão, se o usuario não especificar nenhuma URL amigavel vai pra HOME, vai pra tela de entrada
    //É como se fosse o HOME/INDEX
    $routeProvider.otherwise({ redirectTo: "/home" });
});