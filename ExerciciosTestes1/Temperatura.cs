using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTestes1
{
    public static class Temperatura
    {
        public static double CelciusToFahrenheit(double tempCelcius)
        {
            double tempFahrenheit = (tempCelcius * (9d / 5d));
            tempFahrenheit += 32;

            return tempFahrenheit;
        }
    }
}
