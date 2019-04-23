using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeFamilia
{
    public class Professor : Pessoa
    {
        private List<Pessoa> disciplinas = new List<Pessoa>();
        private Pessoa professor;

        public void CadastrarProfessor()
        {
            professor = new Pessoa();

            Console.WriteLine("\t\tInsira o nome do Aluno: ");
            Console.Write("\t\t");
            professor.Nome = Console.ReadLine();

            Console.WriteLine("\t\tInsira o Data de nascimento do Aluno: ");
            Console.Write("\t\t");
            professor.DataDeNascimento = Console.ReadLine();

            Console.WriteLine("\t\tInsira o Endereço completo do Aluno: ");
            Console.Write("\t\t");
            professor.Endereco = Console.ReadLine();

            Console.WriteLine("\t\tQual a Raça: ");
            Console.Write("\t\t");
            professor.Raca = Console.ReadLine();

            Console.WriteLine("\t\tGênero M ou F: ");
            Console.Write("\t\t");
            professor.Genero = Console.ReadLine();

            Console.WriteLine("\t\tEstado Civil: ");
            Console.Write("\t\t");
            professor.EStadoCivil = Console.ReadLine();

            Console.WriteLine("\t\tInsira o CPF: ");
            Console.Write("\t\t");
            professor.CPF = Console.ReadLine();

            Console.WriteLine("\t\tInsira o RG: ");
            Console.Write("\t\t");
            professor.RG = Console.ReadLine();

            if (ChecandoCadastroDeCpf(professor.CPF) == null)
            {
                disciplinas.Add(professor);
                Console.WriteLine("\t\tCadastro efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("\t\tCPF digitado ja cadastro!");
            }
            Console.ReadKey();
        }

        public void CadastrarDisciplina()
        {
            Console.WriteLine("\t\tInsira Uma Disciplina: ");
            Console.Write("\t\t");
            professor.Disciplina = Console.ReadLine();

            Console.WriteLine("\t\tQual a Data de Admissão: ");
            Console.Write("\t\t");
            professor.DataDeAdmissao = Console.ReadLine();

            disciplinas.Add(professor);
            Console.ReadKey();
        }

        public void MostrarDadosDoProfessor()
        {
            Console.WriteLine("\t\tNome: " + professor.Nome + "\n\t\tData de Nascimento: " + professor.DataDeNascimento + "\n\t\tEndereço: " + professor.Endereco + 
                               "\n\t\tRaça: " + professor.Raca + "\n\t\tGenero: " + professor.Genero + "\n\t\tEstado Cívil: " + professor.EStadoCivil + 
                               "\n\t\tCPF: " + professor.CPF + "\n\t\tRG: " + professor.RG + "\n\t\tDisciplina: " + professor.Disciplina +
                               "\n\t\tData de admissão: " + professor.DataDeAdmissao);
            Console.ReadKey();
        }

        private Pessoa ChecandoCadastroDeCpf(string cpf)
        {
            foreach (Pessoa professor in disciplinas)
            {
                if (professor.CPF == cpf)
                {
                    return professor;
                }
            }
            return null;
        }

        private bool CompararNotaDoAluno(int Nota)
        {
            if (Notas > 69)
            {
                return true;
            }
            return false;
        }
    }
}
