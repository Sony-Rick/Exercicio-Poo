// using System;

// public class Produto
// {
//    
//     public string Nome { get; set; }
//     public decimal Preco { get; set; }
//     public int QuantidadeEmEstoque { get; set; }

//   
//     public Produto(string nome, decimal preco, int quantidadeEmEstoque)
//     {
//         Nome = nome;
//         Preco = preco;
//         QuantidadeEmEstoque = quantidadeEmEstoque;
//     }

//     // Método para adicionar itens ao estoque
//     public void AdicionarEstoque(int quantidade)
//     {
//         if (quantidade < 0)
//         {
//             Console.WriteLine("Quantidade a adicionar deve ser maior que zero.");
//             return;
//         }

//         QuantidadeEmEstoque += quantidade;
//         Console.WriteLine($"{quantidade} unidades adicionadas. Estoque atual: {QuantidadeEmEstoque}.");
//     }

//     // Método para remover itens do estoque
//     public void RemoverEstoque(int quantidade)
//     {
//         if (quantidade < 0)
//         {
//             Console.WriteLine("Quantidade a remover deve ser maior que zero.");
//             return;
//         }

//         if (QuantidadeEmEstoque >= quantidade)
//         {
//             QuantidadeEmEstoque -= quantidade;
//             Console.WriteLine($"{quantidade} unidades removidas. Estoque atual: {QuantidadeEmEstoque}.");
//         }
//         else
//         {
//             Console.WriteLine("Quantidade a remover excede o estoque disponível.");
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         string nome;
//         decimal preco;
//         int quantidadeEmEstoque = 0;

//         Console.WriteLine("Digite o nome do produto");
//         nome = Console.ReadLine();

//         Console.WriteLine("Digite o preço do produto. (Exemplo: 2,50)");
//         preco = decimal.Parse(Console.ReadLine());

//         Produto produto = new Produto(nome, preco, quantidadeEmEstoque);

//         Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:F2}");
//         Console.WriteLine("------------------------------------------------");
//         Console.WriteLine("Quantas unidades deste produto você deseja adicionar ao estoque?");
//         quantidadeEmEstoque = int.Parse(Console.ReadLine());

//         produto.AdicionarEstoque(quantidadeEmEstoque);

//         Console.WriteLine("Quantas unidades deste produto você deseja retirar do estoque?");
//         quantidadeEmEstoque = int.Parse(Console.ReadLine());

//         produto.RemoverEstoque(quantidadeEmEstoque);
//         // produto.RemoverEstoque(150); // Tentativa de remover mais do que há no estoque
//     }
// }
