// using System;
// using System.Collections.Generic;

// public class Tarefa
// {
//     public string Descricao { get; set; }
//     public DateTime DataVencimento { get; set; }

//     public Tarefa(string descricao, DateTime dataVencimento)
//     {
//         Descricao = descricao;
//         DataVencimento = dataVencimento;
//     }

//     public override string ToString()
//     {
//         return $"Descrição: {Descricao}, Data de Vencimento: {DataVencimento}";
//     }
// }

// public class GerenciadorDeTarefas
// {
//     private List<Tarefa> tarefas = new List<Tarefa>();

//     // Método para adicionar uma tarefa
//     public void AdicionarTarefa(Tarefa tarefa)
//     {
//         tarefas.Add(tarefa);
//         Console.WriteLine("Tarefa adicionada com sucesso!");
//     }

//     // Método para remover uma tarefa pelo índice
//     public void RemoverTarefa(int indice)
//     {
//         if (indice >= 0 && indice < tarefas.Count)
//         {
//             tarefas.RemoveAt(indice);
//             Console.WriteLine("Tarefa removida com sucesso!");
//         }
//         else
//         {
//             Console.WriteLine("Índice inválido. Tarefa não encontrada.");
//         }
//     }

//     // Método para listar todas as tarefas
//     public void ListarTarefas()
//     {
//         if (tarefas.Count == 0)
//         {
//             Console.WriteLine("Nenhuma tarefa disponível.");
//             return;
//         }

//         for (int i = 0; i < tarefas.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {tarefas[i]}");
//         }
//     }

//     // Método para verificar se uma tarefa deve ser executada no dia de hoje
//     public List<Tarefa> VerificarTarefasHoje()
//     {
//         DateTime hoje = DateTime.Today;
//         List<Tarefa> tarefasHoje = tarefas.FindAll(t => t.DataVencimento.Date == hoje);
//         return tarefasHoje;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Adicionar Tarefa");
//             Console.WriteLine("2. Remover Tarefa");
//             Console.WriteLine("3. Listar Todas as Tarefas");
//             Console.WriteLine("4. Verificar Tarefas para Hoje");
//             Console.WriteLine("5. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Descrição: ");
//                     string descricao = Console.ReadLine();
//                     Console.Write("Data de Vencimento (dd/MM/yyyy): ");
//                     DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

//                     Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
//                     gerenciador.AdicionarTarefa(novaTarefa);
//                     break;

//                 case "2":
//                     Console.Write("Índice da tarefa a remover: ");
//                     if (int.TryParse(Console.ReadLine(), out int indice))
//                     {
//                         gerenciador.RemoverTarefa(indice - 1);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Índice inválido.");
//                     }
//                     break;

//                 case "3":
//                     Console.WriteLine("Lista de Tarefas:");
//                     gerenciador.ListarTarefas();
//                     break;

//                 case "4":
//                     Console.WriteLine("Tarefas para Hoje:");
//                     var tarefasHoje = gerenciador.VerificarTarefasHoje();
//                     if (tarefasHoje.Count == 0)
//                     {
//                         Console.WriteLine("Nenhuma tarefa para hoje.");
//                     }
//                     else
//                     {
//                         foreach (var tarefa in tarefasHoje)
//                         {
//                             Console.WriteLine(tarefa);
//                         }
//                     }
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