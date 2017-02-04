using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ulatina.Topicos.Calculadora.Tests
{
    [TestClass]
    public class BusinessLogic
    {
        [TestMethod]
        public void SumarTodosLosElementosEnCero()
        {
            //preparacion del escenario
            List<double> miLista = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0};
            double resultadoEsperado = 0.0;

            //invoque al metodo requerido
            var laAccion = new Ulatina.Topicos.Calculadora.Domain.Actions.Sumar();
            var resultadoObtenido = laAccion.realizarOperacion(miLista);

            //realiza las verificaciones de si la invocacion devolvio el resultado esperado
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
