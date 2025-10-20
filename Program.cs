// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Xml.Serialization;
using PooEstudo.Models;
using System.Globalization;
using System.Reflection.Metadata;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Data;
using System.Data.Common;



int i = 0;
Dictionary<string, string> estados = new Dictionary<string, string>();
Dictionary<int, string> idEstados = new Dictionary<int, string>();

estados.Add("ES", "Espirito Santo");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");

foreach (KeyValuePair<string, string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    idEstados.Add(i, item.Key);
    i++;
}


System.Console.WriteLine("TABELA ID - SIGLA");
foreach (KeyValuePair<int, string> item in idEstados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

System.Console.WriteLine("---REMOVENDO O RJ---");

estados.Remove("RJ");
estados["MG"] = "Minas Gerais - Valor alterado";


foreach (KeyValuePair<string, string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

System.Console.WriteLine("TABELA ID - SIGLA");

foreach (KeyValuePair<int, string> item in idEstados)
{
    if (item.Value == "RJ")
    {
        idEstados.Remove(item.Key);
    }
}
foreach (KeyValuePair<int, string> item in idEstados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine(estados["MG"]);

string chave = "ES";
System.Console.WriteLine("Verificando o elemento");
if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente: {chave}");
}
else
{
    System.Console.WriteLine($"Não existe, é seguro adicionar a chave {chave}");
}












// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(16);

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine("Removendo o elemento: " + pilha.Pop());

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }
// pilha.Push(10);
// System.Console.WriteLine("Adicionando o elemento:");

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }






// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine("Removendo o elemento " + fila.Dequeue());
// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
//     System.Console.WriteLine("Tamanho da fila: " + fila.Count);
// }
// System.Console.WriteLine("Removendo o elemento " + fila.Dequeue());
// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
//     System.Console.WriteLine("Tamanho da fila: " + fila.Count);
// }
// System.Console.WriteLine("Removendo o elemento " + fila.Dequeue());
// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
//     System.Console.WriteLine("Tamanho da fila: " + fila.Count);
// }

// System.Console.WriteLine("Removendo o elemento " + fila.Dequeue());
// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
//     System.Console.WriteLine("Tamanho da fila: " + fila.Count);
// }

















// new ExemploExcecao().Metodo1();































// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado: {ex.Message}");
// }
// catch (Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     System.Console.WriteLine("Fechando arquivo...");
// }


























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;
// System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


// double porcentagem = .8421;
// System.Console.WriteLine(porcentagem.ToString("P"));


// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));


// DateTime data = DateTime.Parse("16/10/2025 15:43");
// DateTime data2 = DateTime.Now;
// System.Console.WriteLine(data.ToString("dd-MM-yyyy HH.mm"));
// System.Console.WriteLine(data.ToShortDateString());
// System.Console.WriteLine(data.ToShortTimeString());

// string dataString = "2022-14-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);

// if (sucesso)
// {
//     System.Console.WriteLine($"Conversao com sucesso! data: {data3}");
// }
// else
// {
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }




// Pessoa p1 = new Pessoa(nome: "Pedro", sobrenome: "Quinellato");
// p1.Idade = 24;

// Pessoa p2 = new Pessoa("Eduardo", "Parteli");
// p2.Idade = 22;


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();





// string numero1 = "10";
// string numero2 = "20";

// string resultado = Convert.ToString(Convert.ToInt32(numero1) + Convert.ToInt32(numero2));
// System.Console.WriteLine(resultado);
