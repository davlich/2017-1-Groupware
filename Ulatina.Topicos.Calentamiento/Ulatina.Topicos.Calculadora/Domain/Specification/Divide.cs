using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Domain.Specification
{
    public class Divide
    {
        internal double CalcularResultado(IEnumerable<double> lalista)
        {
            double elresulado = 0;

            var laValidacion = new Validations.RealizarValidaciones();

            if (laValidacion.LaListaContieneAlMenosUnElemento(lalista))
            {
                elresulado = lalista.First();
                var laListaParaRecorrer= lalista.Skip(1);

                foreach (var elItemDeLaLista in laListaParaRecorrer)
                {
                    if (elItemDeLaLista != 0)
                        elresulado /= elItemDeLaLista;
                    else
                        throw new Exception("Ocrrio una division por cero");
                }
            }
            
            
            return elresulado;

        }
    }
}