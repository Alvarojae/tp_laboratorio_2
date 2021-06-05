using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreacionDeUnProductoAlimentoExistoso()
        {
            Alimento aux = new Alimento(1, 10, 25, "Cindor", 150, 300, "Chocolate");
            Materiales alimento = new Materiales("Leche", 30, true);

            bool resultado = alimento.ConsumirMateriales(aux);

            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void CreacionDeUnProductoAlimentoError()
        {
            Alimento aux = new Alimento(1, 10, 50, "Cindor", 150, 300, "Chocolate");
            Materiales alimento = new Materiales("Leche", 30, true);

            bool resultado = alimento.ConsumirMateriales(aux);

            Assert.AreEqual(false, resultado);

        }

        [TestMethod]
        public void CreacionDeUnProductoAlimentoConMaterialHerramientaError()
        {
            Alimento aux = new Alimento(1, 10, 50, "Cindor", 150, 300, "Chocolate");
            Materiales herramienta = new Materiales("Leche", 30, false);

            bool resultado = herramienta.ConsumirMateriales(aux);

            Assert.AreEqual(false, resultado);

        }
    }
}
