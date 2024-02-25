
using PalavraThis;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace PalavraThis {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto { //sintaxe alternativa
            //    Nome = "TV",
            //    Preco = 500.00,
            //    Quantidade = 20
            };

            Console.WriteLine("Dados do produto: " + p3);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p3.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p3);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p3.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p3);

        }
    }
}