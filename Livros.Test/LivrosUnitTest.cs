﻿using ExerciciosTestes1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Livros.Test
{
    public class LivrosUnitTest
    {
        [Fact]
        public void TestarAdicionarLivro()
        {
            string livro = "Alice no pais das maravilhas, Lewis C.";

            var listaLivros = ExerciciosTestes1.Livros.AdicionarLivros(livro);


        }
    }
}
