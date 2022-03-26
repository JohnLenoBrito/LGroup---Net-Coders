using SondaIT.CodeFirst.FluentAPI.Model;
using SondaIT.CodeFirst.FluentAPI.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SondaIT.CodeFirst.FluentAPI.UI.Web.Modules
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtID.Text);

            var rep = new ClienteRepository();

            var registro = rep.GetAll().Where(x => x.Codigo == codigo).SingleOrDefault();

            txtNome.Text = registro.Nome;
            txtRG.Text = registro.Rg;
            txtCPF.Text = registro.Cpf;
            txtDataNascimento.Text = registro.DataNascimento.ToShortDateString();
            txtEmail.Text = registro.Email;
            txtEndereco.Text = registro.Endereco;
            txtCep.Text = registro.Cep;
            txtPis.Text = registro.Pis;
            txtSalario.Text = registro.Salario.ToString();
            ddlEstadoCivil.SelectedIndex = registro.CodigoEstadoCivil;
            ddlSexo.SelectedIndex = registro.CodigoSexo;
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            var rep = new ClienteRepository();

            var atualizarRegistro = new ClienteModel()
            {
                Codigo = Convert.ToInt32(txtID.Text),
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
                DataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                Email = txtEmail.Text,
                Endereco = txtEndereco.Text,
                Pis = txtPis.Text,
                Salario = (decimal)5435.54,
                Telefone = "(11) 98343-4933",
                CodigoEstadoCivil = ddlEstadoCivil.SelectedIndex,
                CodigoSexo = ddlSexo.SelectedIndex
            };

            rep.Update(atualizarRegistro);

            Response.Redirect("Listar.aspx");
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            //Fizemos a instancia do repositorio
            var rep = new ClienteRepository();

            //pegamos os campos do registro que será deletado
            var deletarRegistro = new ClienteModel()
            {
                Codigo = Convert.ToInt32(txtID.Text),
                Nome = txtNome.Text,
                Rg = txtRG.Text,
                Cpf = txtCPF.Text,
                DataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                Email = txtEmail.Text,
                Endereco = txtEndereco.Text,
                Pis = txtPis.Text,
                Salario = (decimal)5435.54,
                Telefone = "(11) 98343-4933",
                CodigoEstadoCivil = ddlEstadoCivil.SelectedIndex,
                CodigoSexo = ddlSexo.SelectedIndex
            };

            //Aqui enviamos os dados capturados para o metodo delete do repositorio
            rep.Delete(deletarRegistro);

            //redirecionamos para a tela de listar para ver o resultado da operação
            Response.Redirect("Listar.aspx");
        }
    }
}