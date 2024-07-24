// using System;
// using System.Collections.Generic;

// public class Produto
// {
//     public int Codigo { get; set; }
//     public string Nome { get; set; }
//     public decimal Preco { get; set; }
//     public int QuantidadeEstoque { get; set; }

//     public Produto(int codigo, string nome, decimal preco, int quantidadeEstoque)
//     {
//         Codigo = codigo;
//         Nome = nome;
//         Preco = preco;
//         QuantidadeEstoque = quantidadeEstoque;
//     }

//     public override string ToString()
//     {
//         return $"Código: {Codigo}, Nome: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}";
//     }

//     public void AdicionarEstoque(int quantidade)
//     {
//         QuantidadeEstoque += quantidade;
//     }

//     public void RemoverEstoque(int quantidade)
//     {
//         if (quantidade <= QuantidadeEstoque)
//         {
//             QuantidadeEstoque -= quantidade;
//         }
//         else
//         {
//             Console.WriteLine("Quantidade em estoque insuficiente.");
//         }
//     }
// }

// public class GerenciadorDeProdutos
// {
//     private List<Produto> produtos = new List<Produto>();

//     // Método para adicionar um produto
//     public void AdicionarProduto(Produto produto)
//     {
//         produtos.Add(produto);
//         Console.WriteLine("Produto adicionado com sucesso!");
//     }

//     // Método para listar todos os produtos
//     public void ListarProdutos()
//     {
//         if (produtos.Count == 0)
//         {
//             Console.WriteLine("Nenhum produto disponível.");
//             return;
//         }

//         foreach (var produto in produtos)
//         {
//             Console.WriteLine(produto);
//         }
//     }

//     // Método para consultar um produto pelo código
//     public Produto ConsultarProduto(int codigo)
//     {
//         return produtos.Find(p => p.Codigo == codigo);
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Adicionar Produto");
//             Console.WriteLine("2. Listar Todos os Produtos");
//             Console.WriteLine("3. Consultar Produto pelo Código");
//             Console.WriteLine("4. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Código: ");
//                     int codigo = int.Parse(Console.ReadLine());
//                     Console.Write("Nome: ");
//                     string nome = Console.ReadLine();
//                     Console.Write("Preço: ");
//                     decimal preco = decimal.Parse(Console.ReadLine());
//                     Console.Write("Quantidade em Estoque: ");
//                     int quantidadeEstoque = int.Parse(Console.ReadLine());

//                     Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEstoque);
//                     gerenciador.AdicionarProduto(novoProduto);
//                     break;

//                 case "2":
//                     Console.WriteLine("Lista de Produtos:");
//                     gerenciador.ListarProdutos();
//                     break;

//                 case "3":
//                     Console.Write("Código do produto a consultar: ");
//                     int codigoConsultar = int.Parse(Console.ReadLine());
//                     Produto produtoEncontrado = gerenciador.ConsultarProduto(codigoConsultar);
//                     if (produtoEncontrado != null)
//                     {
//                         Console.WriteLine("Produto encontrado:");
//                         Console.WriteLine(produtoEncontrado);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Produto não encontrado.");
//                     }
//                     break;

//                 case "4":
//                     continuar = false;
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida. Tente novamente.");
//                     break;
//             }
//         }
//     }
// }