// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using PooEstudo.Models;

Pessoa p1 = new Pessoa(nome: "Pedro", sobrenome: "Quinellato");
p1.Idade = 24;

Pessoa p2 = new Pessoa("Eduardo", "Parteli");
p2.Idade = 22;


Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();