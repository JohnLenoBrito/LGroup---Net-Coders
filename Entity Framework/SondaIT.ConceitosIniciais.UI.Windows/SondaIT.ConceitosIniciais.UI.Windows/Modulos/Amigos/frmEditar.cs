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
    public partial class frmEditar : Form
    {
        //Criamos uma variavel global para receber o código do amigo selecionado que está vindo lá da tela de listar (Anterior)
        //(Por trás) pra passar informações de 1 tela pra outra
        //criar uma variavel global
        public Int32 codigoDoAmigo;

        //Inicializamos o EF
        //Criamos uma conexao apontando para ele (EDMX)
        JOHNEntities _conexao = new JOHNEntities();
        
        public frmEditar()
        {
            InitializeComponent();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            //Qualquer coisa que está cheirando MERDA ou estranho ligue o LOG e veja se deu MERDA
            _conexao.Database.Log = Console.WriteLine;
            
            //O evento LOAD é disparado assim que a tela aparece para o usuario (fica visivel)
            //Assim que a tela ficou visivel pelo codigo do amigo buscamos o restante das informações
            //SELECT * FROM WHERE ID_AMIGO = 200

            var amigo = _conexao.TB_AMIGO.Find(codigoDoAmigo);

            //Pegamos o restante dos dados que vinheram do banco e jogamos pra dentro da tela
            //DATA MAPPER
            //É o nome gourmetizado (bunitão) de pegar infomaçãoes de 1 local e levar pro outro
            txtNome.Text = amigo.NM_AMIGO;
            txtEmail.Text = amigo.DS_EMAIL;
            mskTelefone.Text = amigo.NR_TELEFONE;
            dtpData.Value = amigo.DT_NASCIMENTO;
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            //Quando o usuario clicar nesse botão temos q fazer o UPDATE do amigo
            //Temos que pegar as novas informações da tela e levar pra tabela

            //Da mesma forma que não podemos deletar sem WHERE, tbm não podemos ATUALIZAR SEM WHERE
            
            //Antes de fazer UPDATE, temos que selecionar o registro
            var amigo = _conexao.TB_AMIGO.Find(codigoDoAmigo);

            //Fizemos o DATA MAPPER (a movimentação de dados)
            amigo.NM_AMIGO = txtNome.Text;
            amigo.DS_EMAIL = txtEmail.Text;
            amigo.NR_TELEFONE = mskTelefone.Text;
            amigo.DT_NASCIMENTO = dtpData.Value;
            amigo.ID_SEXO = 2;

            //Pra fazer update não existe comando .Update() ou .Edit()
            //Pra cadastrar (Add) e remover (Remove)
            //Colocamos somente o SaveChanges (SECO) (PELO)
            _conexao.SaveChanges();
            MessageBox.Show("Amigo atualizado com sucesso");

            //Considerações
            //1 -> Quando fazemos um UPDATE ele só leva pra tabela as informações dos campos que alteramos, se vc só alterou o campo NOME só tem update no compo NOME
            //2 -> Tomar cuidado ao abrir varias conexoes no projeto, as conexos devem sempre ser aberta em um unico local (DLL de acesso a dados)
            //Quando abrimos varias conexoes em varios locais as conexoes não se conversam e por conta disso uma não visualiza os dados da outra conexão
        }
    }
}
