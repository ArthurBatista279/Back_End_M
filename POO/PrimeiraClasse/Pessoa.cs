using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public int altura;
        public int dinheiro;
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {nome}, tenho {idade} anos e tenho {altura} de altura.");
        }

        public void Serviço()
        {
            Console.WriteLine($"{nome} está trabalhando com programação");
        }
         public void Falar()
        {
            Console.WriteLine($"{nome} está falando sobre programação!");
        }
        public void Trabalhar()
        {
            int ganho = 100;
            dinheiro += ganho;
            Console.WriteLine($"{nome} trabalhou e ganhou R${ganho}!");
        }
        public void Comprar()
        {
            int preco = 80;
            if (dinheiro >= preco)
            {
                dinheiro -= preco;
                Console.WriteLine($"{nome} comprou algo por R${preco}!");
            }
            else
            {
                Console.WriteLine($"{nome}, você não tem dinheiro suficiente!");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"{nome}, seu saldo atual é de R${dinheiro}.");
        }
    }
}