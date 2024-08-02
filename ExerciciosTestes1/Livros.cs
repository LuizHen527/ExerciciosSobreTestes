using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTestes1
{
    public static class Livros
    {
        public static string[] AdicionarLivros(string livro)
        {
            string[] livros = { "O Iluminado, Stephen King", "Diario de Anne Frank, Anne Frank", "1984, George Orwell" };

            livros = livros.Append<string>(livro).ToArray();

            return livros;
        }
    }
}
