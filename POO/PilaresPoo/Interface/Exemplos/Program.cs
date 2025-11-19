using Exemplos;

/*
Carro Dodge = new Carro("Preto", "Dodge", "Challenger", 1969);

Dodge.ExibirInfo();

Moto Honda = new Moto("Branco", "Honda", "Biz 125", 2025);

Honda.ExibirInfo();
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        ControleRemoto controle = new ControleRemoto(10); // volume máximo 10
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("MENU DO CONTROLE REMOTO");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Desligar");
            Console.WriteLine("3 - Aumentar Volume");
            Console.WriteLine("4 - Diminuir Volume");
            Console.WriteLine("5 - Ver Volume Atual");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    controle.Ligar();
                    break;

                case "2":
                    controle.Desligar();
                    break;

                case "3":
                    controle.Aumentar();
                    break;

                case "4":
                    controle.DiminuirVolume();
                    break;

                case "5":
                    Console.WriteLine($"Volume atual: {controle.NivelVolume}");
                    break;

                case "6":
                    rodando = false;
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
