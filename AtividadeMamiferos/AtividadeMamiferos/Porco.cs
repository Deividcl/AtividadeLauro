using System;

namespace AtividadeMamiferos
{
    public class Porco : Mamiferos
    {
        public Porco(string nome, int idade) : base(nome, idade, 4, "Vermelho")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Ronc rnc!!");
        }
    }
}
