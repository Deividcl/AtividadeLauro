using System;
namespace NotaFiscal
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo OpcaoDoUsuario;

            GerarComponentesDaNotaFiscal notaFiscal = new GerarComponentesDaNotaFiscal();

            do
            {
                Console.WriteLine("\n\t\tEscolha uma opção: " +
                    "\n\t\t[F1] Para efetuar um novo cadastro. " +
                    "\n\t\t[F2] Para visualizar lista de cadastrados" +
                    "\n\t\t[F8] Sair");
                OpcaoDoUsuario = Console.ReadKey();
                Console.Clear();
                if (OpcaoDoUsuario.Key == ConsoleKey.F1)
                {
                    notaFiscal.CadastrarNovoProduto();
                    Console.Clear();
                }
                if (OpcaoDoUsuario.Key == ConsoleKey.F2)
                {
                    notaFiscal.MostrarCadastrosEfetuados();
                    Console.Clear();
                }

            } while (OpcaoDoUsuario.Key != ConsoleKey.F8);
        }
    }
}
