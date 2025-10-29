using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
         // 3 propriedades
        public string nome;
        public int idade;
        public string profissao;

        // 2 métodos que exibem mensagens
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {nome}, tenho {idade} anos e trabalho como {profissao}.");
        }

        public void Falar()
        {
            Console.WriteLine($"{nome} está falando sobre programação");
        }
    }
}