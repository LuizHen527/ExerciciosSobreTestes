using ExerciciosTestes1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes
{
    public class InventarioUnitTest
    {
        [Theory]
        [InlineData("Chocolate", 4)]
        [InlineData("Fermento", 8)]

        public void AdicionandoNovoProduto(string nome, int quantidade)
        {
            Produto novoProduto = new Produto(nome, quantidade);

            var inventario = Inventario.AdicionarProduto(novoProduto);

            Assert.Contains<Produto>(novoProduto, inventario);
        }

        [Theory]
        [InlineData("Leite", 3)]
        [InlineData("Farinha", 7)]
        public void AdicionandoProdutoExistente(string nome, int quantidadeEsperada)
        {
            Produto novoProduto = new Produto(nome, quantidadeEsperada);
            Produto produtoCadastrado;

            Produto[] inventario = Inventario.AdicionarProduto(novoProduto);

            foreach (var item in inventario)
            {
                if(novoProduto.Nome == item.Nome)
                {
                    produtoCadastrado = item;

                    Assert.Equivalent(novoProduto, produtoCadastrado);
                    
                }
            }

        }
    }
}
