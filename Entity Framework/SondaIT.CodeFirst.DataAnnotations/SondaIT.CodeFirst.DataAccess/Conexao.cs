using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pra poder utilizar o nucleo so EF que baixamos via NUGET temos que importar a namespace (PACOTE) abaixo
using System.Data.Entity;

//Subimos a DLL de modelos (MODEL) é lá que ficam as classes que vão virar tabelas, precisamos delas pra poder mapear o DbSet  (CREATE TABLE)
using SondaIT.CodeFirst.Model;

//O nosso projeto é composto de diversos projetinhos
//MODEL -> As definições de tabelas e onde armazenamos os dados
//DATAACCESS -> É o nome de mercado, termo arquitetural, significa acesso a doados,
//é onde vamos deixar a conexão e o Entity Framework, toda manipulação do servidor de banco de dados
//fica dentro do DATAACCESS (DAL)
namespace SondaIT.CodeFirst.DataAccess
{
    //No Code First não temos EDMX, temos que montar a conexão na raça através das DLLS e COMANDO DO EF

    //Baixamos a versão mais recente do EF 6.1, baixamos via NUGET (Instalador e Desinstalador de Componentes) de Recursos
    //Precisou baixar algo da net, baixe pelo NUGET, ele ja vem integrado ao VISUAL STUDIO
    //Quando baixamos pelo NUGET ele baixa somente o KARNEL, somente as DLLS Internas do EF (Não tem EDMX)
    //Pra transforma a nossa classe em uma classe de conexão com o banco de dados, temos que HERDAR da classe DbContext
    //DbContext -> classe de conexão do EF
    public class Conexao : DbContext
    {
        //O EF é burro, temos que avisar ele onde ele vai se conectar
        //(Nome do servidor, nome do banco, autenticação), fazemos tudo isso no CONSTRUTOR
        //base() significa PAI
        //Que significa que estamos buscando alguma informação na classe PAI (DbContext) (EF)
        //Data Source -> Nome do Servidor (Instancia)
        //Initial Catalog -> Nome do Banco de Dados (Não existe)
        //Integrated Security -> Windows Authentication, logue no Sql Server com o mesmo usuário que está logado no WINDOWS

        public Conexao()
            : base("Data Source=172.28.128.29;Initial Catalog=DATAANNOTATIONS; Integrated Security=True;")
        {
            //ctor + TAB + TAB gera um construtor
            //Construtor é um inicializador da nossa classe, é uma forma de saber quando a classe subiu pra memoria

            //É no construtor que passamos a STRING DE CONEXÃO, todos os dados necessários pra se conectar com o SERVER

        }

        //Criamos 2 comandos, 1 comando ele gera o banco
        //CREATE DATABASE
        //1 Comado ele deleta o banco
        //DROP DATABASE
        //Provando que temos controle TOTAL do EF e do BANCO
        public void CriarBanco()
        {
            //O nosso comando acionou o comando interno do EF de geração de banco, é nesse momento que ele cria o banco,
            //as tabela e os campos CREATE DATABASE, CREATE TABLE's
            Database.Create();
        }

        public void DeletarBanco()
        {
            //Removemos o banco, tableas e os dados
            //DROP DATABASE
            Database.Delete();
        }

        //Alem de gerar o banco pelo C# (EF = CODE FIRST) temos tambem que gerar as tabelas
        //Pra gerar as tabelas temos que usar a classe DBSET
        //É um DBSET pra cada tabela
        //O DbSet além de dar um CREATE TABLE ele também acessa elas podemos inserir, deletar, pesquisar, atualizar os dados
        public DbSet<AmigoModel> Amigo { get; set; }

        public DbSet<SexoModel> Sexo { get; set; }

        public DbSet<EstadoCivilModel> EstadoCivil { get; set; }
    }
}
