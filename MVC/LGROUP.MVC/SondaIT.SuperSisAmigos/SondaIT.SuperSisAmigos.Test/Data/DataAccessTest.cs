using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SondaIT.SuperSisAmigos.Data.Contexts;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Test.Data
{
    /// <summary>
    /// Summary description for DataAccessTest
    /// </summary>
    [TestClass]
    public class DataAccessTest
    {
    
        [TestMethod]
        public void AcessarBase()
        {
            using (var context = new AmigosContext())
            {
                var novoRegistro = new LoginModel()
                {
                    USUARIO = "Alan Siqueira",
                    SENHA = "alan123"
                };

                context.LOGIN.Add(novoRegistro);
                context.SaveChanges();
            }

        }

    }
}
