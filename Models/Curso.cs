using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEstudo.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }


        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }


        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }


        public void ListarAlunos()
        {
            System.Console.WriteLine($"Alunos do curso de {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                // string texto = $"Nº " + (i + 1) + " - " + Alunos[i].NomeCompleto;
                string texto = $"Nº {i + 1} - {Alunos[i].NomeCompleto}";
                System.Console.WriteLine(texto);
            }

        }

    }
}