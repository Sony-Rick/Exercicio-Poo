// using System;
// using System.Collections.Generic;
// using System.Globalization;

// public class Imovel
// {
//     public string Endereco { get; set; }
//     public decimal Preco { get; set; }
//     public string Tipo { get; set; }

//     public Imovel(string endereco, decimal preco, string tipo)
//     {
//         Endereco = endereco;
//         Preco = preco;
//         Tipo = tipo;
//     }

//     public override string ToString()
//     {
//         return $"Endereço: {Endereco}, Preço: R${Preco.ToString("C", new CultureInfo("pt-BR"))}, Tipo: {Tipo}";
//     }
// }

// public class CorretoraDeImoveis
// {
//     private List<Imovel> imoveis = new List<Imovel>();

//     public void InserirImovel(Imovel imovel)
//     {
//         imoveis.Add(imovel);
//     }

//     public void AlterarPrecoImovel(string endereco, decimal novoPreco)
//     {
//         foreach (var imovel in imoveis)
//         {
//             if (imovel.Endereco == endereco)
//             {
//                 imovel.Preco = novoPreco;
//                 Console.WriteLine("Preço alterado com sucesso!");
//                 return;
//             }
//         }
//         Console.WriteLine("Imóvel não encontrado.");
//     }

//     public void ListarImoveis()
//     {
//         if (imoveis.Count == 0)
//         {
//             Console.WriteLine("Nenhum imóvel disponível.");
//             return;
//         }

//         foreach (var imovel in imoveis)
//         {
//             Console.WriteLine(imovel);
//         }
//     }

//     public decimal CalcularValorMedio()
//     {
//         if (imoveis.Count == 0)
//         {
//             return 0;
//         }

//         decimal soma = 0;
//         foreach (var imovel in imoveis)
//         {
//             soma += imovel.Preco;
//         }

//         return soma / imoveis.Count;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         CorretoraDeImoveis corretora = new CorretoraDeImoveis();
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Inserir Imóvel");
//             Console.WriteLine("2. Alterar Preço do Imóvel");
//             Console.WriteLine("3. Listar Todos os Imóveis");
//             Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
//             Console.WriteLine("5. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Endereço: ");
//                     string endereco = Console.ReadLine();
//                     Console.Write("Preço: ");
//                     decimal preco = decimal.Parse(Console.ReadLine());
//                     Console.Write("Tipo: ");
//                     string tipo = Console.ReadLine();

//                     Imovel novoImovel = new Imovel(endereco, preco, tipo);
//                     corretora.InserirImovel(novoImovel);
//                     Console.WriteLine("Imóvel inserido com sucesso!");
//                     break;

//                 case "2":
//                     Console.Write("Endereço do imóvel a alterar: ");
//                     string enderecoAlterar = Console.ReadLine();
//                     Console.Write("Novo Preço: ");
//                     decimal novoPreco = decimal.Parse(Console.ReadLine());

//                     corretora.AlterarPrecoImovel(enderecoAlterar, novoPreco);
//                     break;

//                 case "3":
//                     Console.WriteLine("Lista de Imóveis:");
//                     corretora.ListarImoveis();
//                     break;

//                 case "4":
//                     decimal valorMedio = corretora.CalcularValorMedio();
//                     Console.WriteLine($"Valor médio dos imóveis: R${valorMedio}");
//                     break;

//                 case "5":
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

