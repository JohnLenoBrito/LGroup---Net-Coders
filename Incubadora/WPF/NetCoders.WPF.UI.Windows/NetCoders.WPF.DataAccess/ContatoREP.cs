using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoders.WPF.Model;

namespace NetCoders.WPF.DataAccess
{
    public class ContatoREP
    {
        public void InserirContato(ContatoMOD dadoTela)
        {
            var conexao = new INCUBADORAEntities();

            var tabelaContato = new TB_CONTATO();

            tabelaContato.NM_CONTATO = dadoTela.Nome;
            tabelaContato.DS_EMAIL = dadoTela.Email;
            tabelaContato.NR_TELEFONE = dadoTela.Telefone;
            tabelaContato.DT_NASCIMENTO = dadoTela.DataNascimento;
            tabelaContato.ID_SEXO = dadoTela.CodigoSexo;

            conexao.TB_CONTATO.Add(tabelaContato);

            conexao.SaveChanges();
        }

        public List<ContatoMOD> ListarContato()
        {
            var colecao = new List<ContatoMOD>();
            var conexao = new INCUBADORAEntities();

            var dados = conexao.TB_CONTATO.ToList();

            foreach (var contatoCorrente in dados)
            {
                var contato = new ContatoMOD();

                contato.Codigo = contatoCorrente.ID_CONTATO;
                contato.Nome = contatoCorrente.NM_CONTATO;
                contato.Email = contatoCorrente.DS_EMAIL;
                contato.Telefone = contatoCorrente.NR_TELEFONE;
                contato.DataNascimento = contatoCorrente.DT_NASCIMENTO;
                contato.CodigoSexo = contatoCorrente.ID_SEXO;

                colecao.Add(contato);
            }
            return colecao;
        }
    }
}
