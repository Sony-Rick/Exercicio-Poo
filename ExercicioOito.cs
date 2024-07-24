// using System;

// public class Fabricante
// {
//     public string Nome { get; set; }
//     public string Endereco { get; set; }
//     public string Cidade { get; set; }

//     public Fabricante(string nome, string endereco, string cidade)
//     {
//         Nome = nome;
//         Endereco = endereco;
//         Cidade = cidade;
//     }

//     public override string ToString()
//     {
//         return $"Nome: {Nome}, Endereço: {Endereco}, Cidade: {Cidade}";
//     }
// }

// public class Produto
// {
//     private string nome;
//     private decimal preco;

//     public string Nome
//     {
//         get { return nome; }
//         set
//         {
//             if (value == null || value.Length == 0)
//             {
//                 Console.WriteLine("Erro: o nome do Produto não pode ser vazio ou nulo.");
//                 return;
//             }

//             nome = value;
//         }
//     }

//     public Fabricante Fabricante { get; set; }

//     public decimal Preco
//     {
//         get { return preco; }
//         set
//         {
//             if (preco < 0)
//             {
//                 Console.WriteLine("Erro: o preço deve ser positivo.");
//                 return;
//             }

//             preco = value;
//         }
//     }

//     public Produto(string nome, Fabricante fabricante, decimal preco)
//     {
//         Nome = nome;
//         Fabricante = fabricante;
//         Preco = preco;
//     }

//     public override string ToString()
//     {
//         return $"Nome: {Nome}, Fabricante: [{Fabricante}], Preço: {Preco:C}";
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("***** Produtos e Fabricantes *****");

//         Console.WriteLine("\nInforme os dados do Fabricante: ");

//         Console.Write("Nome: ");
//         string nomeDoFabricante = Console.ReadLine();

//         Console.Write("Endereço: ");
//         string endereco = Console.ReadLine();

//         Console.Write("Cidade: ");
//         string cidade = Console.ReadLine();

//         Console.WriteLine("Informe os dados do Produto: ");

//         Console.Write("Nome: ");
//         string nomeDoProduto = Console.ReadLine();

//         Console.Write("Preço: ");
//         decimal preco = decimal.Parse(Console.ReadLine());

//         Fabricante fabricante = new Fabricante(nomeDoFabricante, endereco, cidade);

//         Produto produto = new Produto(nomeDoProduto, fabricante, preco);

//         Console.WriteLine("\n----- Resultado -----");
//         Console.WriteLine($"Produto: {produto.Nome}");
//         Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
//         Console.WriteLine($"Preço: R${produto.Preco}");

//         Console.ReadKey();

//     }
// }