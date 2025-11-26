using ClassesEstáticas_Encapsulamento;

Carro meuCarro = new Carro();

meuCarro.DefinirMarca("Dodge");
meuCarro.DefinirModelo("Challenger");

meuCarro.Acelerar(130);
meuCarro.Frear(0);

Console.WriteLine("DADOS DO CARRO");
Console.WriteLine($"Marca: {meuCarro.ObterMarca()}");
Console.WriteLine($"Modelo: {meuCarro.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {meuCarro.ObterVelocidade()} km/h");