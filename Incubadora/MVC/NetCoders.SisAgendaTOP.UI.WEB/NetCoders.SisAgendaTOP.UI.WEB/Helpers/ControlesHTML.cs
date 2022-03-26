using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCoders.SisAgendaTOP.UI.WEB.Helpers
{
    public static class ControlesHTML
    {
        public static MvcHtmlString Br(this HtmlHelper classe)
        {
            var quebra = new TagBuilder("br");

            return MvcHtmlString.Create(quebra.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString Button(this HtmlHelper classe, String tipo, String nome, String id, String texto,String ClasseCSS)
        {
            var botao = new TagBuilder("input");

            botao.Attributes.Add("type", tipo);
            botao.Attributes.Add("name", nome);
            botao.Attributes.Add("id", id);
            botao.Attributes.Add("value", texto);
            botao.AddCssClass(ClasseCSS);

            return MvcHtmlString.Create(botao.ToString(TagRenderMode.SelfClosing));
        }
    }
}