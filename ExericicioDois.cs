// public class Compra
// {
//     public DateTime Data { get; set; }
//     public decimal Valor { get; set; }
//     public string Produto { get; set; }

//     public Compra(DateTime data, decimal valor, string produto)
//     {
//         Data = data;
//         Valor = valor;
//         Produto = produto;
//     }
// }

// public class RegistroDeCompras
// {
//     private List<Compra> compras = new List<Compra>();
//     public void AdicionarCompra(Produto produto)
//     {
//         compras.Add(new Compra(produto));
//     }

//     public void ListarCompras()
//     {
//         foreach (var compra in compras)
//         {
//             Console.WriteLine(compra);
//         }
//     }
// }

// public class Program
// {
//     public static void Main()    
//     {
//         Compra compra1 = new Compra(new DateTime(2024, 07, 22), 2.00m, "bexiga");
//         Compra compra2 = new Compra(new DateTime(2024, 07, 20), 2.00m, "bola");

//         RegistroDeCompras registro = new RegistroDeCompras();
//         registro.AdicionarCompra(compra1);
//         registro.AdicionarCompra(compra2);

//         Console.WriteLine("Lista de Compras:");
//         registro.ListarCompras();
//     }
// }