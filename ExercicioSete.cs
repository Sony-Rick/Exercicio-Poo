// public class Musica
// {
//     public string Nome {get; set;}
//     public string Gravadora {get; set;}
//     public string Autor {get; set;}  

//     public Musica(string nome, string autor, string gravadora)
//     {
//         Nome = nome;
//         Autor = autor;
//         Gravadora = gravadora;
//     }

//     public override string ToString()
//     {
//         return $"Nome: {Nome}, Autor: {Autor}, Gravadora: {Gravadora}";
//     }
// }

// public class Playlist
// {
//     public List<Musica> musicas = new List<Musica>();
//     public string Dono { get; set; }
//     private Random random = new Random();

//     public Playlist(string dono)
//     {
//         Dono = dono;
//     }

//     // Método para adicionar músicas à playlist
//     public void AdicionarMusica(Musica musica)
//     {
//         musicas.Add(musica);
//         Console.WriteLine("Música adicionada com sucesso!");
//     }

//     // Método para listar todas as músicas
//     public void ListarMusicas()
//     {
//         if (musicas.Count == 0)
//         {
//             Console.WriteLine("Nenhuma música disponível.");
//             return;
//         }

//         foreach (var musica in musicas)
//         {
//             Console.WriteLine(musica);
//         }
//     }

//     // Método para tocar uma música específica
//     public void TocarMusica(int indice)
//     {
//         if (indice >= 0 && indice < musicas.Count)
//         {
//             Console.WriteLine($"Tocando: {musicas[indice].Nome}");
//         }
//         else
//         {
//             Console.WriteLine("Índice inválido. Música não encontrada.");
//         }
//     }

//     // Método para tocar uma música aleatória
//     public void TocarMusicaAleatoria()
//     {
//         if (musicas.Count == 0)
//         {
//             Console.WriteLine("Nenhuma música disponível para tocar.");
//             return;
//         }

//         int indiceAleatorio = random.Next(musicas.Count);
//         TocarMusica(indiceAleatorio);
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string autorPlaylist;
//         Console.WriteLine("Insira o nome do/a dono/a da playlist: ");
//         autorPlaylist = Console.ReadLine();

//         Playlist playlist = new Playlist(autorPlaylist);
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Adicionar Música");
//             Console.WriteLine("2. Listar Todas as Músicas");
//             Console.WriteLine("3. Tocar Música Específica");
//             Console.WriteLine("4. Tocar Música Aleatória");
//             Console.WriteLine("5. Sair");
//             Console.Write("Escolha uma opção: ");

//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.Write("Nome: ");
//                     string nome = Console.ReadLine();
//                     Console.Write("Autor: ");
//                     string autor = Console.ReadLine();
//                     Console.Write("Gravadora: ");
//                     string gravadora = Console.ReadLine();

//                     Musica novaMusica = new Musica(nome, autor, gravadora);
//                     playlist.AdicionarMusica(novaMusica);
//                     break;

//                 case "2":
//                     Console.WriteLine("Lista de Músicas:");
//                     playlist.ListarMusicas();
//                     break;

//                 case "3":
//                     Console.Write("Índice da música a tocar: ");
//                     if (int.TryParse(Console.ReadLine(), out int indice))
//                     {
//                         playlist.TocarMusica(indice - 1);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Índice inválido.");
//                     }
//                     break;

//                 case "4":
//                     playlist.TocarMusicaAleatoria();
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