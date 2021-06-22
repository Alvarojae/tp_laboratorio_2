using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Serializadora;
namespace Test_Unitario
{
    [TestClass]
    public class TestUnitario
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
            Alimento aux = new Alimento(1, 10, 25, "Cindor", 150, 300, "Chocolate");
            Materiales herramienta = new Materiales("Leche", 30, false);

            bool resultado = herramienta.ConsumirMateriales(aux);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void GuardarSerializacionDeMaterial()
        {
            Materiales herramienta = new Materiales("Leche", 30, false);
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
         
             bool resultado = serializadora.Guardar(herramienta.Nombre, herramienta);

            Assert.AreEqual(true, resultado);
        }


        [TestMethod]
        public void GuardarSerializacionDeMaterialYcomprobarIgualdad()
        {
            Materiales herramienta = new Materiales("Leche", 30, false);
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();

            bool resultado = serializadora.Guardar(herramienta.Nombre, herramienta);

            Materiales leer = serializadora.Leer(herramienta.Nombre);

            Assert.IsTrue(herramienta.SonIguales(leer));
            
        }

        [TestMethod]
        public void GuardarSerializacionDeMaterialYcomprobarDesigualdad()
        {
            Materiales herramienta = new Materiales("Leche", 40, false);
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            bool resultado = serializadora.Guardar(herramienta.Nombre, new Materiales("Leche", 30, false));

            Materiales leer = serializadora.Leer(herramienta.Nombre);

            Assert.IsFalse(herramienta.SonIguales(leer));

        }


        [TestMethod]
        [ExpectedException(typeof(MisExcepciones))]
        public void ProbarExcepcionDelTipoCustom()
        {
            Materiales herramienta;
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
       
            herramienta = serializadora.Leer("Aca va a romper en mil pedazos");
        }


        [TestMethod]
        public void GuardarSqlDeMaterialYcomprobarDesigualdad()
        {
            Materiales herramienta = new Materiales("Leche", 40, false);
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            bool resultado = serializadora.Guardar(herramienta.Nombre, new Materiales("Leche", 30, false));

            Materiales leer = serializadora.Leer(herramienta.Nombre);

            Assert.IsFalse(herramienta.SonIguales(leer));

        }
    }
}
