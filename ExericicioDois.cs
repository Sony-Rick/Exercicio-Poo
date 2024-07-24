// using static RegistroDeComprasApp.RegistroDeCompras;

// namespace RegistroDeComprasApp;
// public class RegistroDeCompras
// {
//     // Classe para representar uma compra
//     public class Compra
//     {
//         public DateTime Data { get; set; }
//         public string Produto { get; set; }
//         public decimal Valor { get; set; }

//         public Compra(DateTime data, string produto, decimal valor)
//         {
//             Data = data;
//             Produto = produto;
//             Valor = valor;
//         }

//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Data: {Data}");
//             Console.WriteLine($"Produto: {Produto}");
//             Console.WriteLine($"Valor: {Valor:C}");
//         }
//     }

//     // Lista para armazenar as compras
//     private List<Compra> compras = new List<Compra>();
// // Método para adicionar uma compra
//     public void AdicionarCompra(Compra compra)
//     {
//         compras.Add(compra);
//         Console.WriteLine("Compra adicionada com sucesso.");
//     }

//     // Método para listar todas as compras
//     public void ListarCompras()
//     {
//         Console.WriteLine("Lista de Compras:");
//         foreach (var compra in compras)
//         {
//             compra.ExibirInformacoes();
//             Console.WriteLine("-----------------------");
//         }
//     }
// }

// public class Program
// {
//     static void Main(string[] args)
//     {
//         // Criação de um objeto Produto
//         Compra compra1 = new Compra(DateTime.Now.AddDays(-2), "Livro Clean Code", 50.00m);
//         Compra compra2 = new Compra(DateTime.Now, "Monitor Ultrawide", 1500.00m);

//         // Criação de um objeto RegistroDeCompras
//         RegistroDeCompras registroDeCompras = new RegistroDeCompras();

//         // Adição de compras ao registro
//         registroDeCompras.AdicionarCompra(compra1);
//         registroDeCompras.AdicionarCompra(compra2);

//         // Listagem das compras registradas
//         registroDeCompras.ListarCompras();
//     }
// }