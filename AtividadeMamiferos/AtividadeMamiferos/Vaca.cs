using System;

namespace AtividadeMamiferos
{
    public class Vaca : Mamiferos
    {
        public Vaca(string nome, int idade) : base(nome, idade, 7, "Vermelho")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Muuuuuuuu!!");
        }
    }
}
