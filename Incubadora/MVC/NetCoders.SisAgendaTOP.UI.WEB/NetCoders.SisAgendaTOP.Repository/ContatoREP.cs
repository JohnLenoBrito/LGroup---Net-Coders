using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoders.SisAgendaTOP.DataAccess;
using NetCoders.SisAgendaTOP.Model;

namespace NetCoders.SisAgendaTOP.Repository
{
    public class ContatoREP
    {
        public void Cadastrar(ContatoMOD dadosTela)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                var novoContato = new TB_CONTATO();

                novoContato.NM_CONTATO = dadosTela.Nome;
                novoContato.DS_EMAIL = dadosTela.Email;
                novoContato.DT_NASCIMENTO = dadosTela.DataNascimento;
                novoContato.NR_TELEFONE = dadosTela.Telefone;
                novoContato.ID_SEXO = dadosTela.Sexo.Codigo;

                conexao.TB_CONTATO.Add(novoContato);
                conexao.SaveChanges();
            }
        }

        public List<ContatoMOD> Listar()
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_CONTATO.ToList()
                                         .ConvertAll(registro =>
                                         {
                                             return new ContatoMOD
                                             {
                                                 Codigo = registro.ID_CONTATO,
                                                 Nome = registro.NM_CONTATO,
                                                 Telefone = registro.NR_TELEFONE,
                                                 DataNascimento = registro.DT_NASCIMENTO,
                                                 Email = registro.DS_EMAIL,
                                                 Sexo = new SexoMOD
                                                                  {
                                                                      Codigo = registro.ID_SEXO,
                                                                      Descricao = registro.TB_SEXO.DS_SEXO
                                                                  }
                                             };
                                         });
            }
        }

        public void Atualizar(ContatoMOD dadosTela)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                var contato = conexao.TB_CONTATO.Single(x => x.ID_CONTATO == dadosTela.Codigo);

                contato.NM_CONTATO = dadosTela.Nome;
                contato.DS_EMAIL = dadosTela.Email;
                contato.DT_NASCIMENTO = dadosTela.DataNascimento;
                contato.NR_TELEFONE = dadosTela.Telefone;
                contato.ID_SEXO = dadosTela.Sexo.Codigo;

                conexao.SaveChanges();
            }
        }

        public void Deletar(Int32 codigo)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                var contato = conexao.TB_CONTATO.Single(x => x.ID_CONTATO == codigo);

                conexao.TB_CONTATO.Remove(contato);

                conexao.SaveChanges();
            }
        }

        public ContatoMOD PesquisarPorCodigo(Int32 codigo)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                var contatoTabela = conexao.TB_CONTATO.Single(x => x.ID_CONTATO == codigo);

                return new ContatoMOD
                {
                    Codigo = contatoTabela.ID_CONTATO,
                    Nome = contatoTabela.NM_CONTATO,
                    DataNascimento = contatoTabela.DT_NASCIMENTO,
                    Email = contatoTabela.DS_EMAIL,
                    Telefone = contatoTabela.NR_TELEFONE,
                    Sexo = new SexoMOD
                    {
                        Codigo = contatoTabela.ID_SEXO,
                        Descricao = contatoTabela.TB_SEXO.DS_SEXO
                    }
                };
            }
        }
    }
}