using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SondaIT.ConceitosIniciais.UI.Windows.Modulos.Amigos
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            //O Entity Framework é uma ferramenta de ACESSO e MAPEAMENTO DE BANCO DE DADOS é o que tem de mais top DESDE 2008
            //pra fazer um acesso a dados, o apelidado dele é EF. Quando instalamos o VS 2013 por padrão vem com o EF 6.0 ou EF 6.1,
            //Esquece o MODELO CONECTADO e DESCONECTADO, agora é somente EF

            //Antes de fazer qualquer coisa no banco primeiro passo temos que criar uma variavel apontando para o EF CRUD (Create, Read, Update, Delete)

            //Inicializamos o EF
            //Quando criamos o EDMX(Passo a Passo) Wizard a classo JOHNEntities
            //NOMEDOBANCOEntities
            //MICROSOFT = MICROSOFTEntities
            //NETCODERS = NETCODERSEntities
            //Sacadinha digitar entities a única palavra que aparece é a palavra que tem que pegar
            var conexao = new JOHNEntities();

            //Pra entender melhor o funcionamento do EF é sempre bacana olhar o LOG, tudo que ele faz no banco de dados
            //ele gera um LOG, vamos monitorar tudo que ele está fazendo por trás dos panos
            //Isso é uma novidade do EF 6.0
            //Capturamos o LOG (Databasa.Log) e mandamos jogar dentro da janela de OUTPUT (Console.WriteLine)
            conexao.Database.Log = Console.WriteLine;

            //Fizemos um INSERT INTO TB_AMIGO via EF
            //O EF faz o mapeamento das tabelas, pra cada tb ele cria 1 classe, sempre que quisermos manipular uma tabela temos que chamar a classe
            var novoRegistro = new TB_AMIGO();

            //Da mesma forma que nós temos um ciclo de vida nascemos, crescemos, reproduzimos e morremos
            //Os registros tbm tem um ciclo de vida ele nasceu a tela e morreu no banco(Tabela)
            var estadoInicial = conexao.Entry(novoRegistro).State;

            //Pegamos os dados dos campos da tela e levamos pra dentro da tabela
            //DATA MAPPER

            novoRegistro.NM_AMIGO = txtNome.Text;
            novoRegistro.DS_EMAIL = txtEmail.Text;
            novoRegistro.NR_TELEFONE = mskTelefone.Text;
            novoRegistro.DT_NASCIMENTO = dtpData.Value;
            novoRegistro.ID_SEXO = 1; //Deixamos fixo pq não aprendemos a dar select(migue)

            //Após fazer o mapeamento (transferencia) dos dados mandamos adicionar o registro na tabela
            conexao.TB_AMIGO.Add(novoRegistro);

            //Capturamos o estado intermedirario do registro
            var estadoIntermediario = conexao.Entry(novoRegistro).State;
            
            //Pra adicionar o registro além do ADD precisamos do comando SaveChanges (Agora vao) é nesse momento que ele vai pro banco e faz o INSERT
            //Com o EF numca mais vamos digitar NENHUMA LINHA DE TSQL, fazemos tudo com C#
            conexao.SaveChanges();

            //Capturamos o estado final do registro
            var estadoFinal = conexao.Entry(novoRegistro).State;


            //É comum no dia a dia manipularmos diversos registro ao mesmo tempo na mesma tela, o EF não se PERDE
            //Ele é inteligente, ele não se perde graças ao Estado dos Registros (Status, Fase)
            
            //FASE INICIAL
            //Quando o registro ta na tela, memória e não foi pra tabela
            //O estado é DETACHED

            //FASE INTERMEDIARIA
            //Quando damos um ADD no registro, ele não vai pra tabela a unica coisa que acontece é o que registro muda de STATUS
            //ADDED

            //FASE FINAL
            //Quando damos um SaveChanges pro banco de dados (Tabela) ele não se perde graças ao ESTADO, nesse momento ele busca todos os registros que o ESTADO é ADDED
            //E faz o INSERT e após o INSERT ele muda o estado do registro para UNCHANGED (Já foi pra tabela)

            MessageBox.Show("Amigo cadastrado com sucesso");

            //Quando inserimos um registro ele automaticamente retorna o código daquele registro, ele já da um select e traz o último ID inserido na tabela
            MessageBox.Show(novoRegistro.ID_AMIGO.ToString());

            //OBSERVAÇÕES CONSTATADAS
            //1 -> Por trás dos panos é MODELO CONECTADO (SqlConnection)
            //2 -> Ele automaticamente fecha a conexão com o banco
            //3 -> Ele automaticamente abre e fecha as transações
            //BEGIN TRANACTION, ROLLBACK TRANACTION, COMMIT TRANACTION
            //4 -> O EF é performatico, ele pensa em aproveitamento de memória, ele só abre a conexão com o banco quando chamado o SaveChanges

        }

        private void btnTSQL_Click(object sender, EventArgs e)
        {
            //O EF é uma ferramenta de mapeamento de banco ele representa o BANCO e as tabelas dentro da APP com o EF
            //Por padrão não recisamos nunca mais digitar código TSQL no C#, VB. NET, mas caso precise também tem com fazer

            //Montamos uma stringona TSQL pra fazer um INSERT
            //Não é perfomatico ficar concatenando variaveis 
            //A, B, A += C;
            //tSql; TSql += "Insert"; TSql += "Into"
            //Quando concatenamos dentro da mesma variavel por trás dos panos a máquina virtual (CLR) fica criando
            //Endereços de memória, pra cada concatenação é um endereço de memórioa
            //Sempre concatenar STRINGS dentro de uma StringBuilder
            //Quando criamos as posições dentro de uma STRING
            //{0}, {1}
            //Isso se chama String.Format
            var tSql = new StringBuilder();
            tSql.AppendLine("INSERT INTO [dbo].[TB_AMIGO]");
            tSql.AppendLine("([ID_SEXO]");
            tSql.AppendLine(",[NM_AMIGO]");
            tSql.AppendLine(",[DS_EMAIL]");
            tSql.AppendLine(",[NR_TELEFONE]");
            tSql.AppendLine(",[DT_NASCIMENTO])");
            tSql.AppendLine(" VALUES({0}, '{1}', '{2}', '{3}', '{4}')");


            //Apos montar a STRINGONA TSQL
            //Trocamos os parametros (Posições) pelas informações da tela
            //Temos 5 posições e trocamos por 5 inforações
            var tSql2 = String.Format(tSql.ToString(),
                                      2,
                                      txtNome.Text,
                                      txtEmail.Text,
                                      mskTelefone.Text,
                                      dtpData.Value);

            //Após trocar os parametros da STRINGONA mandamos
            //Executar pelo EF
            var conexao = new JOHNEntities();


            //Lembra muito a forma antiga, modelo conectado (SqlCommand)
            //Sempre que possivel use da primeira forma
            //Faça o INSERT VIA Mapeamentos (Add e SaveChanges)
            //Usar dessa forma somente em 2 situações
            //1 -> Pra comandos que não existem no EF TRUNCATE TABLE, CREATE INDEX, algum comando DDL
            //2 -> Pra comando que você não sabe fazer no EF sei la como se faz um GROUP BY, RIGHT JOIN,
            //UNION COM GROUP BY e VARIOS JOINS (FERROU)
            conexao.Database.ExecuteSqlCommand(tSql2);
            conexao.Database.Log = Console.Write;

            MessageBox.Show("Amigo cadastrado com sucesso!");
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            //Quando mapeamos TABELAS elas viram CLASSES, quando mapeamos PROCEDURES elas viram MÉTODOS
            //Os métodos não são visuais, não da pra visualizar no diagrama de EF (Parte visual) para visualizar
            //Os métodos tem que olhar a janela MODEL BROWSER (Mapeamento)

            //Melhor dos mundos é EF com PROCEDURE, temos a facilidade do EF
            //Performance do SQL Server utilizando PROCEDURES
            //Procedures são mais rapidos do que comandos AD-HOCK (ADOKE)
            //Sempre que possivel use procedure com EF
            var conexao = new JOHNEntities();
            conexao.CADASTRAR_AMIGO(1,
                                    txtNome.Text,
                                    txtEmail.Text,
                                    mskTelefone.Text,
                                    dtpData.Value);

            MessageBox.Show("Amigo cadastrado com sucesso!");
        }

        private void btnTransacional_Click(object sender, EventArgs e)
        {
            //Vimos que por padrão o EF já abre e fecha transações
            //Mas caso seja necessario podemos abrir e controlar manualmente as transações (BEGIN,  COMMIT, ROLLBACK)

            var conexao = new JOHNEntities();

            conexao.Database.Log = Console.WriteLine;

            //Abrimos manualmente a transação (BEGIN TRANSACTION)
            //Cenario de utilização dessa tecnica no dia a dia INSERTS em varias TABELAS
            var transacao = conexao.Database.BeginTransaction();
            
            var novoAmigo = new TB_AMIGO();
            novoAmigo.NM_AMIGO = txtNome.Text;
            novoAmigo.DS_EMAIL = txtEmail.Text;
            novoAmigo.NR_TELEFONE = mskTelefone.Text;
            novoAmigo.DT_NASCIMENTO = dtpData.Value;
            novoAmigo.ID_SEXO = 1;

            conexao.TB_AMIGO.Add(novoAmigo);
            conexao.SaveChanges();

            //Quando abrimos manualmente a transação mesmo tendo SaveChanges tem que CONFIRMAR ou ABORTAR manualmente
            //Commit -> Confirma
            //Rollback -> Aborta
            transacao.Rollback();

            //Observações:
            //Quando abrimos manualmente uma transação é naquele momento que ele abre a conexão com o banco
        }

        private async void CadastrarAmigo()
        {
            var conexao = new JOHNEntities();
            conexao.Database.Log = Console.WriteLine;

            var novoAmigo = new TB_AMIGO();
            novoAmigo.NM_AMIGO = txtNome.Text;
            novoAmigo.DS_EMAIL = txtEmail.Text;
            novoAmigo.NR_TELEFONE = mskTelefone.Text;
            novoAmigo.DT_NASCIMENTO = dtpData.Value;
            novoAmigo.ID_SEXO = 1;

            conexao.TB_AMIGO.Add(novoAmigo);

            //Pra não travar a tela e pro insert ficar mais rapido rodamos ele em uma THREAD SEPARA
            //Inclusivw isso é uma novidade do EF 6.0
            //O SaveChanges (Abre a Thread)
            //AWAIT é pra esperar terminar de processar (Congela)
            //Ao usar o SaveChangesAsync temos que colocar AYNC na frente do Método private async
            await conexao.SaveChangesAsync();

            MessageBox.Show("Amigo cadastrado com sucesso!");
        }

        private void btnAssincrono_Click(object sender, EventArgs e)
        {
            //Temos 2 tipos de processamento
            //PROCESSAMENTO SINCRONO (Padrão)
            //Todas as linhas de código rodam dentro da mesma THREAD
            //Trilha de execução, um local de processamento no processador
            //As linhas são execultados um de cada vez

            //PROCESSAMENTO ASSINCRONO
            //Conseguimos execultar várias linhas de código ao mesmo tempo
            //ra fazer isso internamente ele abre várias THREADS (TRILHAS)
            //1 TRILHA para cada processamento, execução
            CadastrarAmigo();
            
            var a = "Ronaldo";
        }
    }
}
