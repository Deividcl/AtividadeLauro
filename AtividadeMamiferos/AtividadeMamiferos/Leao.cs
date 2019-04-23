using System;

namespace AtividadeMamiferos
{
    public class Leao : Mamiferos
    {
        public Leao(string nome, int idade) : base(nome, idade, 6, "Marrom")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Roaaaaaaaar!!!");
        }
    }
}
