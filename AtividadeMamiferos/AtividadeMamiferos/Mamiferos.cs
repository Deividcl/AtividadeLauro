using System;

namespace AtividadeMamiferos
{
    public abstract class Mamiferos
    {
        private string _nome;
        private int _idade;
        private int _mama;
        private string _corDosOlhos;

        public Mamiferos(string nome, int idade, int mama, string corDosOlhos)
        {
            _nome = nome;
            _idade = idade;
            _mama = mama;
            _corDosOlhos = corDosOlhos;
        }

        public virtual void Aleitar()
        {
            Console.WriteLine("Amamentando com {0} mamas", _mama);
        }

        public abstract void Comunicar();
    }
}
