using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Domain.Specification
{
    public class Multiplique
    {
        internal double CalcularResultado(IEnumerable<double> lalista)
        {
            double elresulado =1;
            var laValidacion = new Validations.RealizarValidaciones();
            
            if(laValidacion.LaListaContieneAlMenosUnElemento(lalista))                      
            foreach (var elItemDeLaLista in lalista)
            {
                elresulado *= elItemDeLaLista;
            }
            else elresulado=0;

            return elresulado;
        }
    }
}