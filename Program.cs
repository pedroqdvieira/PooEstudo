// See https://aka.ms/new-console-template for more information
using PooEstudo.Models;

Pessoa p1 = new Pessoa();

System.Console.WriteLine("Informe o seu nome: ");
p1.Nome = Console.ReadLine();

System.Console.WriteLine("Informe o seu sobrenome: ");
p1.Sobrenome = Console.ReadLine();

System.Console.WriteLine("Informe a sua idade: ");
p1.Idade = Convert.ToInt32(Console.ReadLine());
p1.Apresentar();