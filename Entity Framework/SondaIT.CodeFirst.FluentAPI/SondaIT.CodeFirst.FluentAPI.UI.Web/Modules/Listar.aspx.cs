using SondaIT.CodeFirst.FluentAPI.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SondaIT.CodeFirst.FluentAPI.UI.Web.Modules
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var rep = new ClienteRepository();

            var consulta = rep.GetAll();

            gvLista.DataSource = consulta;
            gvLista.DataBind();
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            //Aqui estamos indo no repositoryo acionando o metodo de listagem
            var rep = new ClienteRepository();

            //Aqui passamos um filtro no campo nome, vamos filtrar apenas por um trecho do nome usando o metodo Contains (like do SQL)
            var consulta = rep.GetAll().Where(x => x.Nome.Contains(txtFiltro.Text));
            //Aqui estamos preenchendo o GridView
            gvLista.DataSource = consulta;
            //Aqui fazemos o Bind para as informações aparecerem na tela
            gvLista.DataBind();
        }
    }
}