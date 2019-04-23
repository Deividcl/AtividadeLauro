using System;

namespace AtividadeMamiferos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato("Garfield", 8);
            gato.Comunicar();

            Humano humano = new Humano("Joao", 33, "Verde");
            humano.Comunicar();

            Mamiferos mamal = new Vaca("Mimosa", 4);
            mamal.Comunicar();

            mamal = new Leao("Simba", 5);
            mamal.Comunicar();
        }
    }
}
