using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SondaIT.SuperSisAmigos.Repository.Repositories;

namespace SondaIT.SuperSisAmigos.Test.Repository
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteRep()
        {
            var rep = new LoginRepository();
            var query = rep.GetAll();

        }
    }
}
