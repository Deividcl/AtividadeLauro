using System;

namespace AtividadeMamiferos
{
    public class Humano : Mamiferos
    {
        public Humano(string nome, int idade, string CorDosOlhos) : base(nome, idade, 2, " ")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Olá!");
        }
    }
}
