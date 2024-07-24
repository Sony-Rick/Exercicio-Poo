// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// ///- Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de
// // tarefas (descrição, data de vencimento). Implemente um construtor e métodos para
// // adicionar, remover e listar tarefas. Adicione um método para verificar se a tarefa deverá
// // ser executada no dia de hoje.

// public class Tarefa
// {
//     public string Descricao { get; set; }
//     public string Data { get; set; }

//     public Tarefa(string descricao, string data)
//     {
//         Descricao = descricao;
//         Data = data;
//     }
// }

// public class GerenciadorDeTarefas
// {
//     private List<Tarefa> tarefas = new List<Tarefa>();

//     public void Adicionar(Tarefa tarefa)
//     {
//         tarefas.Add(tarefa);
//         Console.WriteLine("Tarefa adicionada");
//     }

//     public void Remover(string descricao)
//     {
//         var tarefa = tarefas.Find(t => t.Descricao.Equals(descricao));
//         if (tarefa != null)
//         {
//             tarefas.Remove(tarefa);
//             Console.WriteLine("Tarefa removida com sucesso!");
//         }
//         else
//         {
//             Console.WriteLine("Tarefa não encontrada!");
//         }
//     }

//     public void Listar()
//     {
//         Console.WriteLine("Lista de Tarefas:");
//         foreach (var tarefa in tarefas)
//         {
//             Console.WriteLine($"Descrição: {tarefa.Descricao}, Data: {tarefa.Data}");
//         }
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         GerenciadorDeTarefas agenda = new GerenciadorDeTarefas();
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Adicionar Tarefa");
//             Console.WriteLine("2. Remover Tarefa");
//             Console.WriteLine("3. Listar Tarefas");
//             Console.WriteLine("4. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Descrição: ");
//                     string descricao = Console.ReadLine();
//                     Console.Write("Data: ");
//                     string data = Console.ReadLine();

//                     Tarefa novaTarefa = new Tarefa(descricao, data);
//                     agenda.Adicionar(novaTarefa);
//                     break;

//                 case "2":
//                     Console.Write("Nome da tarefa para remover: ");
//                     string descricaoRemover = Console.ReadLine();
//                     agenda.Remover(descricaoRemover);
//                     break;

//                 case "3":
//                     agenda.Listar();
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