using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pra poder testar a criação e remoção do banco, baixamos o FRAMEWORK NUNIT,
//É a principal biblioteca do mundo para criação e execução de testes
//Baixamos o NUNIT nia NUGET (Gerenciador de Downloads)
//Subimos o NUNIT pra memória
using NUnit.Framework;

//Pra que o VS reconheça o NUNIT temos que baixar via Nuget o pacote NUNIT TEST ADAPTER é ele quem faz a integração do VS com o ROBO DE TESTES

//Subimos prá memoria a DLL de Acesso a DADOS(EF)
using SondaIT.CodeFirst.DataAccess;

//Subimos pra memoria a DLL de Armazenamento de dados(MODEL)
using SondaIT.CodeFirst.Model;

//Subimos pra memória a DLL de geração de massa de dados
//É gratuita (NBUILDER) e baixamos via NUGET(Gerenciador de Componentes)
using FizzWare.NBuilder;

namespace SondaIT.CodeFirst.Tests.DataAccess
{
    //Uma das atribuições do programador no dia a dia além de codificar é TESTAR
    //Pra não ficar testando de forma BRAÇAL, MANUAL criamos um PROJETO DE TESTES
    //TESTES AUTOMATIZADOS, CÓDIGO TESTANDO CÓDIGO, O PROJETO DE TESTES VAI TESTAR O PROJETO DE DATA ACCESS
    
    //Transformamos a classe em um robo de testes utilizando a configuração (Data Annotations) TestFixture (NUNIT)
    [TestFixture]
    class ConexaoTest
    {
        //O robo não se move sozinho, nós temos que falar como o robo vai se mover
        //E aqui em um projeto (ROBO DE TESTES) é o mesmo esquema, temos que falar quais são as operações do ROBO
        //Quais os comandos que ele vai executar e testar
        [Test]
        public void Testar_Criacao_Do_Banco()
        {
            //Acionamos a classe de conexão (EF)
            var conexao = new Conexao();
            conexao.CriarBanco();
        }

        //A configuração Test é do NUNIT e serve para transformar o comando em um comando de TESTES do robo (CLASSE)

        //O VS só consegue visualizar dependencia de primeiro nivel (1 DLL chamando OUTRA DLL)
        //Do segundo nivel pra cima ele caga todo, somos obrigados a importar 1 por 1
        [Test]
        public void Testar_Exclusao_Do_Banco()
        {
            var conexao = new Conexao();
            conexao.DeletarBanco();
        }

        //Criamos um comadno de teste, pra verificar se os INSERTS estão funcionando, vamos inserir 2 sexos
        [Test]
        public void Testar_Cadastro_De_Sexo()
        {
            //Simulamos o insert de 2 sexos
            var feminino = new SexoModel();
            feminino.Descricao = "Feminino";
            var masculino = new SexoModel();
            masculino.Descricao = "Masculino";

            //Mandamos inserir
            var conexao = new Conexao();

            conexao.Sexo.Add(feminino);
            conexao.Sexo.Add(masculino);

            conexao.SaveChanges();
        }

        [Test]
        public void Testar_Cadastro_De_Estados_Civis()
        {
            var solteiro = new EstadoCivilModel();
            solteiro.Descricao = "Solteiro";

            var casado = new EstadoCivilModel();
            casado.Descricao = "Casado";

            var conexao = new Conexao();
            conexao.EstadoCivil.Add(solteiro);
            conexao.EstadoCivil.Add(casado);

            conexao.Database.Log = Console.WriteLine;

            conexao.SaveChanges();
        }

        [Test]
        public void Testar_Cadastro_De_Amigo()
        {
            //Acionamos a tabela de amigo (TB_AMIGO)
            var novoAmigo = new AmigoModel();
            novoAmigo.Nome = "Amigo1";
            novoAmigo.Email = "Amigo1@hotmail.com";
            novoAmigo.CodigoEstadoCivil = 1;
            novoAmigo.CodigoSexo = 2;
            novoAmigo.DataNascimento = DateTime.Now;
            novoAmigo.Telefone = "(11) 11111-1111";

            var conexao = new Conexao();

            conexao.Amigo.Add(novoAmigo);
            conexao.SaveChanges();
        }

        [Test]
        public void Testar_Consulta_De_Amigos()
        {
            var conexao = new Conexao();
            var amigos = conexao.Amigo.ToList();
        }

        [Test]
        public void Testar_Cadastro_De_Amigos_Com_Massa_De_Dados()
        {
            //Geramos uma massa de dados (Registro de amigos), através do NBUILDER
            var amigos = Builder<AmigoModel>.CreateListOfSize(50)
                                            .All()
                                                .TheFirst(10)
                                                    .With(x => x.CodigoSexo = 1)
                                                    .With(x => x.CodigoEstadoCivil = 1)
                                                .TheNext(20)
                                                    .With(x => x.CodigoSexo = 2)
                                                    .With(x => x.CodigoEstadoCivil = 2)
                                                .TheLast(20)
                                                    .With(x => x.CodigoSexo = 1)
                                                    .With(x => x.CodigoEstadoCivil = 2)
                                            .Build();

            //Após gerar os dados mandamos inserir
            var conexao = new Conexao();
            
            //Pra inserir 1 unico registro por vez ADD
            //Pra inserir DIVERSOS registros de uma única ves, de 2 pra cima utilizando o comando AddRange
            //É uma novidade de EF 6.0
            conexao.Amigo.AddRange(amigos);
            conexao.SaveChanges();

            //CONSIDERAÇÕES
            //Caso de erro em qualquer um dos registros, o EF automaticamente da ROLLBACK
        }
    }
}