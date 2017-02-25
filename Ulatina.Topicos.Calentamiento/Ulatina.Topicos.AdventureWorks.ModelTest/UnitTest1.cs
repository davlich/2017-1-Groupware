using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ulatina.Topicos.AdventureWorks.ModelTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //preparacion del escenario
            var elProducto = new Model.Product();
            elProducto.SizeUnitMeasureCode = "CM";
            elProducto.Size = "25";
            var ElResultadoEsperado = "9.84 in";

            //ejecuto el metodo correspondiente
            
            var elResultadoActual= elProducto.SizeInInches;
            
            //verificar el resultado
            Assert.AreEqual(ElResultadoEsperado, elResultadoActual);
        }
    }
}
