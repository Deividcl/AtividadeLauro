using System;

namespace AtividadeMamiferos 
{
    public class Cachorro : Mamiferos
    {
        public Cachorro (string nome, int idade):base(nome,idade,10, "castanho")
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine("Au au!!");
        }
    }
}
