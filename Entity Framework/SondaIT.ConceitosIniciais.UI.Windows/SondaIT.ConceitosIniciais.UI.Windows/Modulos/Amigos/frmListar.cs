using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

//Todos os comandos que usamos lá em baixo para pesquisa, pra fazer as consultas LING TO ENTITIES
//Descem dessa namespace
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SondaIT.ConceitosIniciais.UI.Windows.Modulos.Amigos
{
    public partial class frmListar : Form
    {
        //Inicializamos a classe de conexão do EF
        JOHNEntities _conexao = new JOHNEntities();

        public frmListar()
        {
            _conexao.Database.Log = Console.WriteLine;
            InitializeComponent();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //Selecionar Registros
            //Demos um SELECT * FROM TB_AMIGO
            //O camoando ToList abre a conexao com o banco, lembra o SaveChanges, e faz executa o SELECT
            //VAI COM SAVECHANGES
            //VOLTA COM TOLIST

            //O comando AsNoTracking serve para falar por EF sempre buscar os dados da tabela, ele não pega mais memória, pega
            //sempre da tabela
            //TABELA (são os dados mais recente)
            //Só USAR ASNOTRACKING quando abrir diversas conexões no projeto
            dgvAmigos.DataSource = _conexao.TB_AMIGO.AsNoTracking().ToList();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Somente Alguns Campos
            //Dentro do EF temos todo poder do TSQL, temos diversos comandos PRONTOS (Where, Select, OrderBy)
            //Que nos auxiliam a projetar os dados na tela (GRID)
            //Pra dentro desse comando temos que passar uma expressão Lambda(x => x)
            //É uma forma rapida e pratica de manipula os campos da TB
            //Independente da complexibilidade da CONSULTA (QUERY) o disparador é ToList() é ele quem abre a conexão e dispara a consulta
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Select(x => new
                                                                   {
                                                                       x.ID_AMIGO,
                                                                       x.NM_AMIGO,
                                                                       x.DS_EMAIL
                                                                   }).ToList();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Selecionar com Alias
            //A maioria desses comandos de banco (WHERE, SELECT, UNION Entre outros) temos que passar uma Expressão Lambda pra dentro deles,
            //A lambda é uma forma rapida e pratica de manipular os campos da tabela

            //Quando damos uma ALIAS (Nome mais legal) para os capos, esse ALIAS é colocado na memoria, ele não vai pro banco
            //Ele automaticamente já da um REPLACE (DE PARA)
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Select(x => new
                                                                   {
                                                                       Codigo = x.ID_AMIGO,
                                                                       Sexo = x.ID_SEXO,
                                                                       Telefone = x.NR_TELEFONE                                                                   
                                                                   }).ToList();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Order By ASC
            //É muito comum fazermos variações de ASC e DESC no ORDER
            //Pra começar é sempre OrderBy ou OrderByDescending
            //Pra terminar é sempre ThenBy ou ThenByDescending
            dgvAmigos.DataSource = _conexao.TB_AMIGO.OrderBy(x => new
                                                                    {
                                                                        x.NM_AMIGO,
                                                                        x.NR_TELEFONE
                                                                    })
                                                    .ThenByDescending(x => new
                                                                             {
                                                                                 x.DT_NASCIMENTO,
                                                                                 x.DS_EMAIL
                                                                             }).ToList();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Order By DESC
            dgvAmigos.DataSource = _conexao.TB_AMIGO.OrderByDescending(y => new
                                                                              {
                                                                                  y.ID_AMIGO,
                                                                                  y.NM_AMIGO
                                                                              })
                                                    .ThenBy(y => new
                                                                    {
                                                                        y.DT_NASCIMENTO,
                                                                        y.NR_TELEFONE
                                                                    }).ToList();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Where simples
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(onde => onde.ID_AMIGO >= 10).ToList();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Where complexo
            //Tomar cuidado ao fazer os FILTROS (WHERE) vimos 2 formas de otimização de Queries
            //1 -> ID_SEXO pra virar um IN colocamos entre PARENTESES ( )
            //2 -> NUNCA Declarar variaveis do tipo DateTime dentro do WHERE, ele gera um CONVERT MALUCÃO e DESNECESSARIO
            //Pra ficar bunitão (CERTO) declarar a variavel FORA (EM CIMA) da CONSULTA
            var data = new DateTime(1950, 01, 01);

            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(x => x.ID_AMIGO >= 1 &&
                                                                (x.ID_SEXO == 1 || x.ID_SEXO == 2) &&
                                                                //x.DT_NASCIMENTO >= new DateTime(1950, 01, 01)).ToList();
                                                                x.DT_NASCIMENTO >= data).ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //LIKE A ESQUERDA
            //SELECT * FROM WHERE NM_AMIGO LIKE 'j%'
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(x => x.NM_AMIGO.StartsWith("j")).ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //LIKE A DIREITA
            //SELECT * FROM WHERE NM_AMIGO LIKE '%a'
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(x => x.NM_AMIGO.EndsWith("a")).ToList();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //LIKE NO MEIO
            //SELECT * FROM WHERE NM_AMIGO LIKE '%a%'
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(x => x.NM_AMIGO.Contains("a")).ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //MAX (Pegamos o Maior Numero do Campo ID_AMIGO)
            //Via EF podemos acionar as funções internas do SQL SERVER, aquelas rosa (MAX, MIN, AVG, COUNT, SUM)
            MessageBox.Show(_conexao.TB_AMIGO.Max(x => x.ID_AMIGO).ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //MIN (Pegamos o Menor Numero do Campo ID_AMIGO)
            //Via EF podemos acionar as funções internas do SQL SERVER, aquelas rosa (MAX, MIN, AVG, COUNT, SUM)
            MessageBox.Show(_conexao.TB_AMIGO.Min(x => x.ID_AMIGO).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //COUNT (Pegamos a quantidade de registros)
            //Via EF podemos acionar as funções internas do SQL SERVER, aquelas rosa (MAX, MIN, AVG, COUNT, SUM)
            MessageBox.Show(_conexao.TB_AMIGO.Count().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SUM (Somamos o Campo ID_AMIGO)
            //Via EF podemos acionar as funções internas do SQL SERVER, aquelas rosa (MAX, MIN, AVG, COUNT, SUM)
            MessageBox.Show(_conexao.TB_AMIGO.Sum(x => x.ID_AMIGO).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Fizemos um INNER JOIN
            //Como as tabelas se relacionam, quando o montamos o EF ele trouxe também o relacionamento entre as tabelas
            //RELACIONAMENTO SE CHAMA (ASSOCIATION)
            //E quando quisermos fazer um JOIN temos que acionar a PROPRIEDADE DE NAVEGAÇÃO (NAVEGATION PROPERTY)
            //E ele faz um join sozinho automaticamente
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Select(x => new
                                                                   {
                                                                       x.ID_AMIGO,
                                                                       x.NM_AMIGO,
                                                                       x.TB_SEXO.DS_SEXO
                                                                   }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BOLADÃO DE CONSULTAS
            var data = new DateTime(1950, 01, 01);
            dgvAmigos.DataSource = _conexao.TB_AMIGO.Where(x => x.ID_AMIGO >= 1 &&
                                                                (x.ID_SEXO == 1 || x.ID_SEXO == 2) &&
                                                                x.DT_NASCIMENTO >= data)
                                                    .OrderBy(x => new
                                                                    {
                                                                        x.NM_AMIGO,
                                                                        x.DS_EMAIL
                                                                    })
                                                    .ThenByDescending(x => new
                                                                             {
                                                                                 x.NR_TELEFONE,
                                                                                 x.DT_NASCIMENTO
                                                                             })
                                                    .Select(x => new
                                                                    {
                                                                        Codigo = x.ID_AMIGO,
                                                                        Email = x.DS_EMAIL,
                                                                        Sexo = x.TB_SEXO.DS_SEXO
                                                                    }).ToList();
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Procedures
            //Tabelas viram CLASSES
            //Procedures viram MÉTODOS (Só da pra ver no MODEL BROWSER)
            //Temos 2 formas de mapear as PROCEDURES
            //1 -> AUTOMATICA
            //Quando deixamos marcado aquele CHECKBOX (Import Selected Proc)
            //2-> MANUAL
            //Quando temos procedures com campos DOIDÕES (COMPUTADOS)
            //Campos que foram montados em memórioa (COUNT, SUM, MAX, AVG)
            //Temos que criar 1 TIPO COMPLEXO (CLASSE ESPECIFICA) para armazenar aqueles campos COMPUTADOS (MEMORIA)
            //Temos que mapear na unha clicar com o direito (ADD Function Import)
            dgvAmigos.DataSource = _conexao.LISTAR_AMIGOS();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Procedures com tipos complexos
            dgvAmigos.DataSource = _conexao.AMIGOS_POR_SEXO();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GRUOP BY
            //Ao fazer consultas mais complexas temos sempre que deixar o SELECT no final
            //O KEY é um nome interno que serve para pegar o campo AGRUPADO
            //ID_SEXO é uma forma mais elegante de pegar o campo que mandamos agrupar
            //KEY = ID_SEXO

            //O EF é a ferramenta de acesso a dados, quando efetuamos consultas dentro dele
            //variações de (Select, Max, Group, Order, Where) o nome bunitão é LINT TO ENTITIES

            dgvAmigos.DataSource = _conexao.TB_AMIGO.GroupBy(x => x.ID_SEXO)
                                                    .Select(x => new
                                                                   {
                                                                       Sexo = x.Key,
                                                                       Quantidade = x.Count()
                                                                   }).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Operadores de Consulta
            //Quando efetuamos CONSULTAS dentro do EF o nome bunitão é LINQ TO ENTITIES
            //Podemos fazer consultas LINQ TO ENTITIES de 2 formas

            //MÉTODOS DE EXTENSÃO
            //São comandos prontos da plataforma .NET que vem do pacote System.LING

            //OPERADORES DE CONSULTA
            //É quando montamos a consulta NA RAÇA, lembra muito TSQL
            //Se tem lambda é MÉTODO DE EXTENSÃO, se tem FROM é OPERADOR DE CONSULTA
            dgvAmigos.DataSource = (from tabelaAmigo in _conexao.TB_AMIGO
                                   where tabelaAmigo.ID_AMIGO >= 1 &&
                                         tabelaAmigo.ID_SEXO == 1
                                   orderby tabelaAmigo.NM_AMIGO,
                                           tabelaAmigo.DS_EMAIL descending
                                   select new
                                   {
                                       Codigo = tabelaAmigo.ID_AMIGO,
                                       Nome = tabelaAmigo.NM_AMIGO,
                                       Sexo = tabelaAmigo.TB_SEXO.DS_SEXO
                                   }).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Excluir
            //Fizemos um exclusão via EF
            //Capturamos a linha selecionada pelo usuario dentro do GRIDE
            //Tudo isso C# com Windows Forms
            var linha = dgvAmigos.SelectedRows[0];

            //Apos captura a LINHA (SOMENTE 1 LINHA), temos que pegar o conteudo da primeira CELULA
            var celula = linha.Cells[0];

            //Capturamos o numero que esta dentro da primeira celula, da primira linha dentro do GRID
            //OBJECT é um tipo de informação generica, podemos ter qualquer informação dentro do OBJECT
            //OBJECT (int32, string, decimal, bool, datetime)...
            //Quando formos pegar algo de uma célula do grid, temos que fazer conversão
            var codigoAmigo = Convert.ToInt32(celula.Value);

            //Fizemos a exclusão do amigo pelo ID, DELETE FROM TB_AMIGO WHERE ID_AMIGO = CelulaGrid
            //Pra não fazer um DELETE SEM WHERE selecionamos o registro primeiro
            //Através do ID capturamos o registro
            //As exclusões via EF são sempre pelo REGISTRO
            //Find ele fazuma busca na tabela pelo campo que é chave primaria ID_AMIGO
            var amigo = _conexao.TB_AMIGO.Find(codigoAmigo);

            //O Remove ele muda o status do registro para REMOVED (Em algum momento ele vai ser excluido)
            _conexao.TB_AMIGO.Remove(amigo);

            //Nesse momento ele abre a conexão e efetua o DELETE é aqui que ele exclui FISICAMENTE O REGISTRO DA TABELA
            _conexao.SaveChanges();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Extrair
            //O Usuario vai selecionar um amigo dentro do grid e vamos colocar aquele amigo no modo de edição
            //DELETES e UPDATES são sempre pelo código (Chamave Primaria)

            //Armazenamos a linha selecionada
            var linhaSelecionada = dgvAmigos.SelectedRows[0];

            //A linha possui diversas celulas, nós só queremos a informação da primeira celula(ID_AMIGO)
            var celula = linhaSelecionada.Cells[0];

            //Extraimos a informação (código, número) do amigo que vamos editar
            //Encontrou OBJECT tem que fazer CONVERSÃO
            var codigoAmigo = Convert.ToInt32(celula.Value);

            //Inicializamos a tela de edição
            var telaEditar = new frmEditar();
            
            //Fizemos a passagem de informação de uma tela pra outra, passamos pra edição do código do amigo selecionado
            telaEditar.codigoDoAmigo = codigoAmigo;

            //ShowDialog abrimos a tela em forma de MODAL ele bloqueia a tela de tráz
            telaEditar.ShowDialog();
        }
    }
}
