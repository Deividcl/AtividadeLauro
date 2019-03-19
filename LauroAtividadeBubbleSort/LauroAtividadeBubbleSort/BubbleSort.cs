using System;

namespace LauroAtividadeBubbleSort
{
    public class BubbleSort
    {        
        public void OrdenacaoDeFormaCrescente()
        {
            int[] numbers = { 45, 81, 29, 66, 03, 52, 51, 55, 74 };
            Console.WriteLine("Ordenação de Forma Crescente: ");
            bubbleSort(numbers, numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            Console.Write(" " + numbers[i]);
            Console.ReadLine();
        }
       
        public void OrdenacaoDeFormaDecrescente()
        {
            int[] numbers = { 45, 81, 29, 66, 03, 52, 51, 55, 74 };
            Console.WriteLine("Ordenação de Forma Decrescente: ");
            bubbleSort(numbers, numbers.Length);
            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                Console.Write(" " + numbers[i]);
            }

            Console.ReadLine();
        }

        public void NumerosAleatorios()
        {
            Console.WriteLine("Aleatorios: ");
            int[] numeros = new int[10];
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 100);
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private void bubbleSort(int[] num, int length)
        {
            int comp = 0;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        comp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = comp;
                    }
                }
            }
        }
    }
}
