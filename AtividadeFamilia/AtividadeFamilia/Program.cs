using System;

namespace AtividadeFamilia
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo opcaoDoUsuario;

            Estudante estudante = new Estudante();
            Professor professor = new Professor();
            Faculdade faculdade = new Faculdade();

            do
            {
                Console.WriteLine("\n\t\t\tOpção para Alunos " +
                     "\n\n\t\t[F1] Cadastrar um Aluno " +
                     "\n\t\t[F2] Mostrar dados do aluno " +
                     "\n\t\t[F3] Cadastrar nova disciplina a um aluno" +
                     "\n\t\t[F4] Calcular Nota do aluno " +
                     "\n\n\t\t\tOpção do professor" +
                     "\n\n\t\t[F5] Cadastrar professor " +
                     "\n\t\t[F6] Mostrar dados do professor" +
                     "\n\t\t[F7] Cadastrar nova disciplina a um professor" +
                     "\n\t\t[F8] Cadastrar Nota a um aluno " +
                     "\n\t\t[F10] Universidades cadastradas " +
                     "\n\t\t[F9] Sair");
                opcaoDoUsuario = Console.ReadKey();
                Console.Clear();
                if (opcaoDoUsuario.Key == ConsoleKey.F1)
                {
                    estudante.CadastrarAluno();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F2)
                {
                    estudante.MostrarInformacoesJaCadastradas();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F3)
                {
                    estudante.CadastrarDisciplinaAUmAluno();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F5)
                {
                    professor.CadastrarProfessor();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F6)
                {
                    professor.MostrarDadosDoProfessor();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F7)
                {
                    professor.CadastrarDisciplina();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F8)
                {
                    estudante.DarNotaAUmAluno();
                    Console.Clear();
                }

                if (opcaoDoUsuario.Key == ConsoleKey.F10)
                {
                    faculdade.Universidades();
                    Console.Clear();
                }
                
            } while (opcaoDoUsuario.Key != ConsoleKey.F9);                        
        }
    }
}
