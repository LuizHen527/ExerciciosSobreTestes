using ExerciciosTestes1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes
{
    public class TemperaturaUnitTest
    {
        [Theory]
        [InlineData(40, 104)]
        [InlineData(50, 122)]
        [InlineData(70, 100)]
        public void VerificarTemperatura(double tempCelsius, double expected)
        {
            double result = Temperatura.CelciusToFahrenheit(tempCelsius);

            Assert.Equal(expected, result);
        }
    }
}
