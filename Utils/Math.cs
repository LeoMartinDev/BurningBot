using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Utils
{
    class Math
    {
        public static int Pourcentage(int a, int b)
        {
            double c = Double.Parse(b.ToString());

            double resultat = a / c;
            double resultatFinal = resultat * 100;


            return (int)resultatFinal;
        }
    }
}
