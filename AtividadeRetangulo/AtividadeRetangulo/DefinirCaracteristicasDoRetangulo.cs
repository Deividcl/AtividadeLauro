using System;

namespace AtividadeRetangulo
{
    public class DefinirCaracteristicasDoRetangulo
    {
        public void DefinirBaseEAltura()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Insira a base do Retangulo");
            retangulo.Largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a altura do Retangulo");
            retangulo.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O valor do perimetro do Retangulo é de: " + (retangulo.Altura + retangulo.Largura) * 2);
            Console.WriteLine("O valor da area do Retangulo é de: " + retangulo.Altura * retangulo.Largura);

            Console.ReadKey();
        }
        
    }
}
