namespace Exemplos
{
    public class ControleRemoto : IControle
{
    public int NivelVolume { get; private set; }
    public int VolumeMaximo { get; private set; }
    private bool Ligado;

    public ControleRemoto(int volumeMaximo)
    {
        VolumeMaximo = volumeMaximo;
        NivelVolume = 0;
        Ligado = false;
    }

    public void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine("Controle ligado.");
        }
        else
        {
            Console.WriteLine("Já está ligado.");
        }
    }

    public void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine("Controle desligado.");
        }
        else
        {
            Console.WriteLine("Já está desligado.");
        }
    }

    public void Aumentar()
    {
        if (!Ligado)
        {
            Console.WriteLine("Ligue o controle primeiro!");
            return;
        }

        if (NivelVolume < VolumeMaximo)
        {
            NivelVolume++;
            Console.WriteLine($"Volume aumentado: {NivelVolume}");
        }
        else
        {
            Console.WriteLine("Volume já está no máximo!");
        }
    }

    public void DiminuirVolume()
    {
        if (!Ligado)
        {
            Console.WriteLine("Ligue o controle primeiro!");
            return;
        }

        if (NivelVolume > 0)
        {
            NivelVolume--;
            Console.WriteLine($"Volume diminuído: {NivelVolume}");
        }
        else
        {
            Console.WriteLine("Volume já está no mínimo!");
        }
    }
}

}