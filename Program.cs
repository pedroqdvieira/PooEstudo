// See https://aka.ms/new-console-template for more information
using PooEstudo.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Sobrenome = "Quinellato";
p1.Idade = 24;

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Parteli";
p2.Idade = 22;


Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();