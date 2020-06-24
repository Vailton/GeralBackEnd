using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 15;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
        }
        public double ValorEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidadeEstoque(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverQuantidadeEstoque(int qtd)
        {
            Quantidade -= qtd;
        }
       
    }
}
