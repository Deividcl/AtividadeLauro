using System;
using System.Collections.Generic;
using System.Collections;


namespace AtividadeFamilia
{
    public class Faculdade : Pessoa
    {
        private List<Faculdade> Unidades = new List<Faculdade>();

        public void Universidades()
        {
            Faculdade faculdade = new Faculdade()
            {
                Nome = "UNA",
                Endereco = "Av. Afonso Vaz de Melo, 465, 4º Piso da Expansão Portaria B: Av. Barão de Coromandel.",
                Curso = "ADS," + " Administraçao &" + " Enfermagem",
            };

            Faculdade faculdade1 = new Faculdade()
            {
                Nome = "UNI",
                Endereco = "Av. Professor Mário Werneck, 1685 - Estoril, Belo Horizonte - MG, 30575-180.",
                Curso = "ADS," + " Administraçao &" + " Medicina",
            };

            Faculdade faculdade2 = new Faculdade()
            {
                Nome = "SOCIESC",
                Endereco = "R. Gothard Kaesemodel, 833 - Anita Garibaldi, Joinville - SC, 89203-400.",
                Curso ="ADS," + " Direito &" + " Biomedicina",
            };

            Unidades.Add(faculdade);
            Unidades.Add(faculdade1);
            Unidades.Add(faculdade2);

            Console.WriteLine("\t\tUniversidades ");
            Console.WriteLine("\n\n\t" + faculdade.Nome + ":\n\tCursos:" + faculdade.Curso + "\n\t|" + faculdade.Endereco  + 
                              "\n\n\t" + faculdade1.Nome + ":\n\tCursos:" + faculdade1.Curso + "\n\t|" + faculdade1.Endereco + 
                              "\n\n\t" + faculdade2.Nome + ":\n\tCursos:" + faculdade2.Curso + "\n\t|" + faculdade2.Endereco );
            Console.ReadKey();
        }
    }
}
