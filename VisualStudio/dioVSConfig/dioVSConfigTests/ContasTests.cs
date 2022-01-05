using Microsoft.VisualStudio.TestTools.UnitTesting;
using dioVSConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dioVSConfig.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void AdicaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Contas();
            var result = contas.Adicao(a, b);

            Assert.AreEqual(esperado, result);
             

        }

        [TestMethod()]
        public void subTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 150;
            var contas = new Contas();
            var result = contas.sub(a, b);

            Assert.AreEqual(esperado, result);

        }
    }
}