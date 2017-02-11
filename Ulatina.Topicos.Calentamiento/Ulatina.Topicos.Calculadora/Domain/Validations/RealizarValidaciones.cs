using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Domain.Validations
{

    //esta clase valida si la lista contiene al menos un elemento
    public class RealizarValidaciones
    {
       public bool LaListaContieneAlMenosUnElemento(IEnumerable<double> lalista) {

            return (lalista.Count() > 0);
             
        }
    }
}