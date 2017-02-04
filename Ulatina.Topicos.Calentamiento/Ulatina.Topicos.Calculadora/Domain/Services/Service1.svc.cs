using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.Topicos.Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculadoraVector : ICalculadoraVector
    {
        public double Sumar(IEnumerable<double> laLista)
        {
            //Primera forma de declarar variables
            // Domain.Actions.Sumar laAccion = new Domain.Actions.Sumar();

            //Segunda forma de declarar variables
            var laAccion = new Domain.Actions.Sumar();

            //return laAccion.realizarOperacion(laLista);
            double resultado = 0;
            resultado = laAccion.realizarOperacion(laLista);
            return resultado;
        }
        public double Restar(IEnumerable<double> laLista)
        {
            //Primera forma de declarar variables
            // Domain.Actions.Sumar laAccion = new Domain.Actions.Sumar();

            //Segunda forma de declarar variables
            var laAccion = new Domain.Actions.Restar();

            //return laAccion.realizarOperacion(laLista);
            double resultado = 0;
            resultado = laAccion.realizarOperacion(laLista);
            return resultado;
        }

        public double Multiplicar(IEnumerable<double> laLista)
        {
            //Primera forma de declarar variables
            // Domain.Actions.Sumar laAccion = new Domain.Actions.Sumar();

            //Segunda forma de declarar variables
            var laAccion = new Domain.Actions.Multiplicar();

            //return laAccion.realizarOperacion(laLista);
            double resultado = 0;
            resultado = laAccion.realizarOperacion(laLista);
            return resultado;
        }

        public double Dividir(IEnumerable<double> laLista)
        {
            //Primera forma de declarar variables
            // Domain.Actions.Sumar laAccion = new Domain.Actions.Sumar();

            //Segunda forma de declarar variables
            var laAccion = new Domain.Actions.Dividir();

            //return laAccion.realizarOperacion(laLista);
            double resultado = 0;
            resultado = laAccion.realizarOperacion(laLista);
            return resultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
