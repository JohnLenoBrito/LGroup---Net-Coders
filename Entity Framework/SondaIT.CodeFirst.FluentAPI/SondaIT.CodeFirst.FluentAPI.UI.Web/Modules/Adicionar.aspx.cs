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
    public partial class Adicionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var rep = new ClienteRepository();

            var novoRegistro = new ClienteModel()
            {
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
            //Chamando o metodo add do repository e enviamos os dados por parametro
            rep.Add(novoRegistro);
            //Estamos redirecionando para a pagina de lista
            Response.Redirect("Listar.aspx");
        }
    }
}