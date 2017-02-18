using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulatina.Topicos.AdventureWorks.Model
{
    public partial class Product
    {
        public string SizeInInches {
            get
            {
                string elResultado = string.Empty;
                double laConversion = 0;
                double lasPulgadas = 0;
                if (SizeUnitMeasureCode == "CM")
                {
                    if (double.TryParse(Size, out laConversion))
                    {
                        lasPulgadas = laConversion / 2.54;
                        elResultado = string.Format("{0} in.", lasPulgadas.ToString());

                    }
                    else
                        elResultado = "Error";
                }
                else
                    elResultado = "Unidad Desconocida";
                return elResultado;
            }                 
                }
    }
}
