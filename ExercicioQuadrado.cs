// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// public class Contato
// {
//     public string Nome { get; set; }

//     public string Telefone { get; set; }  

//     public string Email { get; set; }

//     public Contato (string nome, string telefone , string email)
//     {
//         Nome = nome;
//         Telefone = telefone;
//         Email = email; 
//     }
//     public override string ToString()
//     {
//         return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
//     }
// }

// public class AgendaTelefonica
// {
//     private List<Contato> Contatos = new List<Contato>();

//     public void Adicionar(Contato contato)
//     {
//         Contatos.Add(contato);
//         Console.WriteLine("Contato adicionado com sucesso");
//     }
//     public void Remover(string nome)
//     {
//         var contato = Contatos.Find(c => c.Nome.Equals(nome));
//         if (contato != null)
//         {
//             Contatos.Remove(contato);
//             Console.WriteLine("Contato removido com sucesso!");
//         }
//     }
//     public Contato Buscar(string nome)
//     {
//         return Contatos.Find(c => c.Nome.Equals(nome));
//     }

// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         AgendaTelefonica agenda = new AgendaTelefonica();
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Adicionar Contato");
//             Console.WriteLine("2. Remover Contato");
//             Console.WriteLine("3. Buscar Contato");
//             Console.WriteLine("4. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Nome: ");
//                     string nome = Console.ReadLine();
//                     Console.Write("Telefone: ");
//                     string telefone = Console.ReadLine();
//                     Console.Write("Email: ");
//                     string email = Console.ReadLine();

//                     Contato novoContato = new Contato(nome, telefone, email);
//                     agenda.Adicionar(novoContato);
//                     break;

//                 case "2":
//                     Console.Write("Nome do contato a remover: ");
//                     string nomeRemover = Console.ReadLine();
//                     agenda.Remover(nomeRemover);
//                     break;

//                 case "3":
//                     Console.Write("Nome do contato a buscar: ");
//                     string nomeBuscar = Console.ReadLine();
//                     var contatoEncontrado = agenda.Buscar(nomeBuscar);
//                     if (contatoEncontrado != null)
//                     {
//                         Console.WriteLine("Contato encontrado:");
//                         Console.WriteLine(contatoEncontrado);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Contato não encontrado.");
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
