using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraThis {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
           // Quantidade = 10;
        }
             
        //palavra This serve também para diferenciar atributos de variáveis locais (Java)

        public Produto(string nome, double preco) : this() { //usando This para passar o construtor padrao
            Nome = nome;
            Preco = preco;
           // Quantidade = 5; //caso não declarar ou colocar nada aqui fica zero
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) { //usando This para passar o construtor de cima
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }


        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}