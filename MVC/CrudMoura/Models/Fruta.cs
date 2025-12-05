using Microsoft.AspNetCore.SignalR;

namespace CrudMoura.Models
{
    public class Fruta
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}
        public int Quantidade {get; set;}
        public string Categoria {get; set;}


    }
}