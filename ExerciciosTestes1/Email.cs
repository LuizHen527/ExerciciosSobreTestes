using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExerciciosTestes1
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|org|gov)";

            return Regex.IsMatch(email, regex);
        }
    }
}
