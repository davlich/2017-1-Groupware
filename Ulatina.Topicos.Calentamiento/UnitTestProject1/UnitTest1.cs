using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Ulatina.Topicos.AdventureWorks.ModelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertirVeinticincoCentimetrosEnPulgadas()
        {
            //Preparacion del escenario
            var elProducto = new Model.Product();
            elProducto.SizeUnitMeasureCode = "CM";
            elProducto.Size = "25";
            var elResultadoEsperado = "9.84 in";

            //ejecuto el metodo correspondiente
            var elResultadoActual = elProducto.SizeInInches;

            //verifico la rrectidul del resultado
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);

        }
    }
}
