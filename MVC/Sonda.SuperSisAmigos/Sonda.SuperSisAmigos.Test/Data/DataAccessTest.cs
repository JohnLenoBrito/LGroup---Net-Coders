using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sonda.SuperSisAmigos.Data.Contexts;
using Sonda.SuperSisAmigos.DomainModel.Models;

namespace Sonda.SuperSisAmigos.Test.Data
{
    /// <summary>
    /// Summary description for DataAccessTest
    /// </summary>
    [TestClass]
    public class DataAccessTest
    {
        [TestMethod]
        public void Acessar_Base()
        {
            using (var context = new AmigosContext())
            {
                var novoRegistro = new LoginModel()
                {
                    Usuario = "John Leno",
                    Senha = "john123"
                };

                context.Login.Add(novoRegistro);
                context.SaveChanges();
            }
        }
    }
}
