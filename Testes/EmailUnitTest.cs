using ExerciciosTestes1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes
{
    public class EmailUnitTest
    {
        [Theory]
        [InlineData("luizhenrique@gmail.com")]
        [InlineData("senaiTec123@gmail.com")]
        [InlineData("@gmail.com")]
        [InlineData("luizhenrique@gmail")]
        [InlineData("luizhenriquegmail.com")]
        
        public void ValidarEmail(string email)
        {
            bool IsEmailValid = Email.ValidarEmail(email);

            Assert.True(IsEmailValid);
        }

    }
}
