using System;

namespace LauroAtividadeBubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BubbleSort bubbleSort = new BubbleSort();
;
            ConsoleKeyInfo opcaoDoUsuario;
            do
            {
                Console.WriteLine("Ordenação bubbleSort");
                Console.WriteLine("De quela forma você deseja fazer a ordenãção?");
                Console.WriteLine("\n[F1] Crescente" +
                                  "\n[F2] Decrescente" +
                                  "\n[F3] Aleatorio" +
                                  "\n[F8] Sair");

                opcaoDoUsuario = Console.ReadKey();
                Console.Clear();

                if (opcaoDoUsuario.Key == ConsoleKey.F1)
                {
                    bubbleSort.OrdenacaoDeFormaCrescente();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F2)
                {                    
                    bubbleSort.OrdenacaoDeFormaDecrescente();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F3)
                {                    
                    bubbleSort.NumerosAleatorios();
                    Console.Clear();
                }
            } while (opcaoDoUsuario.Key != ConsoleKey.F8) ;  
        }
    }
}
