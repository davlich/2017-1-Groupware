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
                        lasPulgadas = Math.Round(laConversion / 2.54,2);
                        elResultado = string.Format("{0} in", lasPulgadas.ToString());

                    }
                    else
                        elResultado = "Error";
                }
                else
                    elResultado = "Unidad Desconocida";
                return elResultado;
            }                 
                }

        public string weighkilos
        {
            get
            {
                string elResultado = string.Empty;
                decimal? losKilos;
                double laConversion = 0;

                switch (WeightUnitMeasureCode) {
                    case "": elResultado = Weight.ToString();break;
                    case "G":
                        losKilos = Weight / 1000;
                        elResultado = string.Format("{0} kgs", losKilos.ToString());break;
                    case "LB":
                        losKilos = Weight / (decimal)2.20462;
                        elResultado = string.Format("{0} kgs", losKilos.ToString()); break;
                    default:
                        elResultado = "unidad desconocida";break;
                }
              
                return elResultado;
            }
        }
    }

}
