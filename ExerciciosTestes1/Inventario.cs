using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTestes1
{
    public class Inventario
    {
        public static Produto[] AdicionarProduto(Produto produto)
        {
            Produto[] inventario = { new Produto("Leite", 2), new Produto("Farinha", 6), new Produto("Ovo", 10) };

            foreach (var item in inventario)
            {
                if (produto.Nome == item.Nome)
                {
                    item.Quantidade++;
                    return inventario;
                }     
            }

            inventario = inventario.Append<Produto>(produto).ToArray();

            return inventario;
        }

        public static int ProcurarProduto(string nome)
        {
            Produto[] inventario = { new Produto("Leite", 2), new Produto("Farinha", 6), new Produto("Ovo", 10) };

            foreach (var item in inventario)
            {
                if(nome == item.Nome)
                {
                    return item.Quantidade;
                }
            }

            return 0;
        }
    }
    public class Produto(string nome, int quantidade)
    {
        public string Nome = nome;
        public int Quantidade = quantidade;
    }

}