using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Domain.Specification
{
    public class Reste
    {
        internal double CalcularResultado(IEnumerable<double> lalista)
        {
            double elresulado = 0;
            foreach (var elItemDeLaLista in lalista)
            {
                elresulado -= elItemDeLaLista;
            }
            return elresulado;

        }
    }
}