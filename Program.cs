// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Xml.Serialization;
using PooEstudo.Models;
using System.Globalization;
using System.Reflection.Metadata;
using System.Diagnostics.CodeAnalysis;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


double porcentagem = .8421;
System.Console.WriteLine(porcentagem.ToString("P"));


int numero = 123456;
System.Console.WriteLine(numero.ToString("##-##-##"));


DateTime data = DateTime.Parse("16/10/2025 15:43");
DateTime data2 = DateTime.Now;
System.Console.WriteLine(data.ToString("dd-MM-yyyy HH.mm"));
System.Console.WriteLine(data.ToShortDateString());
System.Console.WriteLine(data.ToShortTimeString());

string dataString = "2022-14-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);

if (sucesso)
{
    System.Console.WriteLine($"Conversao com sucesso! data: {data3}");
}
else
{
    System.Console.WriteLine($"{dataString} não é uma data válida");
}




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





string numero1 = "10";
string numero2 = "20";

string resultado = Convert.ToString(Convert.ToInt32(numero1) + Convert.ToInt32(numero2));
System.Console.WriteLine(resultado);
