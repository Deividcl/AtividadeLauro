using System;
using System.Collections.Generic;

namespace AtividadeFamilia
{    
    public class Estudante : Pessoa
    {
        private List<Pessoa> cursos = new List<Pessoa>();
        private Pessoa estudante;

        public void CadastrarAluno()
        {
            estudante = new Pessoa();

            Console.WriteLine("\t\tInsira o nome do Aluno: ");
            Console.Write("\t\t");
            estudante.Nome = Console.ReadLine();

            Console.WriteLine("\t\tInsira o Data de nascimento do Aluno: ");
            Console.Write("\t\t");
            estudante.DataDeNascimento = Console.ReadLine();

            Console.WriteLine("\t\tInsira o Endereço completo do Aluno: ");
            Console.Write("\t\t");
            estudante.Endereco = Console.ReadLine();

            Console.WriteLine("\t\tQual a Raça: ");
            Console.Write("\t\t");
            estudante.Raca = Console.ReadLine();

            Console.WriteLine("\t\tGênero M ou F: ");
            Console.Write("\t\t");
            estudante.Genero = Console.ReadLine();

            Console.WriteLine("\t\tEstado Civil: ");
            Console.Write("\t\t");
            estudante.EStadoCivil = Console.ReadLine();

            Console.WriteLine("\t\tInsira o CPF: ");
            Console.Write("\t\t");
            estudante.CPF = Console.ReadLine();

            Console.WriteLine("\t\tInsira o RG: ");
            Console.Write("\t\t");
            estudante.RG = Console.ReadLine();

            if (ChecandoCadastroDeCpf(estudante.CPF) == null)
            {
                cursos.Add(estudante);
                Console.WriteLine("\t\tCadastro efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("\t\tCPF digitado ja cadastro!");
            }
            Console.ReadKey();
        }

        public void MostrarInformacoesJaCadastradas()
        {
            foreach (Pessoa pessoa in cursos)
            {
                pessoa.MostrarListaDeCadastro();
            }
            Console.ReadKey();
        }
        
        public void CadastrarDisciplinaAUmAluno()
        {
            Console.WriteLine("\t\tInforme o CPF do aluno: ");
            Console.Write("\t\t");
            var cpfDeCadastro = Console.ReadLine();

            if (ChecandoCadastroDeCpf(cpfDeCadastro) != null)
            {
                Console.WriteLine("\t\tQual o nome da disciplina para este aluno? ");
                Console.Write("\t\t");
                estudante.Curso = Console.ReadLine();
                Console.WriteLine("\t\tCadastro efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("\t\tCPF digitado não cadastrado!");
            }
            Console.ReadKey();
        }

        public void DarNotaAUmAluno()
        {
            Console.WriteLine("\t\tInforme o CPF do aluno: ");
            Console.Write("\t\t");
            var CpfCadastrado = Console.ReadLine();

            Pessoa cadastro = ChecandoCadastroDeCpf(CpfCadastrado);            

            if (cadastro != null)
            {
                Console.WriteLine("\t\tInsira uma nota para o aluno: ");
                Console.Write("\t\t");
                var notaDoAluno = Convert.ToInt32(Console.ReadLine());

                bool notas = CompararNotaDoAluno(notaDoAluno);

                if (notas == true)
                {
                    estudante.Notas = notaDoAluno;
                    Console.WriteLine("\t\tAluno aprovado");
                    Console.ReadKey();
                }
                else
                {
                    estudante.Notas = notaDoAluno;
                    Console.WriteLine("\t\tAluno reprovado");
                    Console.ReadKey();
                }            
            }
        }

        private Pessoa ChecandoCadastroDeCpf(string cpf)
        {
            foreach(Pessoa estudante in cursos)
            {
                if (estudante.CPF == cpf)
                {
                    return estudante;
                }
            }
            return null;
        }

        private bool CompararAtributosDeUmaPessoa(string atributo)
        {
            if (atributo == "Curso")
            {
                return true;
            }
            return false;
        }

        private bool CompararNotaDoAluno(double Nota)
        {
            if (Nota > 69)
            {
                return true;
            }
            return false;
        }
    }
}
