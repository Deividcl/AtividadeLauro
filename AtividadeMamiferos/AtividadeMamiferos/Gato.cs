using System;

namespace AtividadeMamiferos
{
    public class Gato : Mamiferos
    {
        public Gato(string nome, int idade) : base(nome, idade, 8, "Amarelos")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Miauu!!");
        }        
    }
}
