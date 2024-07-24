// using System;

// public class Carro
// {
//     public string Modelo { get; set; }
//     public int Ano { get; set; }
//     private int velocidade;

//     public int Velocidade
//     {
//         get { return velocidade; }
//         private set
//         {
//             if (value < 0)
//                 velocidade = 0;
//             else
//                 velocidade = value;
//         }
//     }

//     public Carro(string modelo, int ano)
//     {
//         Modelo = modelo;
//         Ano = ano;
//         Velocidade = 0; // A velocidade inicial é 0
//     }

//     public void Acelerar()
//     {
//         Velocidade += 10;
//         Console.WriteLine($"Acelerando... Velocidade atual: {Velocidade} km/h");

//     }

//     public void Frear()
//     {
//         if (Velocidade >= 10)
//         {
//             Velocidade -= 10;
//         }
//         else
//         {
//             Velocidade = 0;
//         }
//         Console.WriteLine($"Freando... Velocidade atual: {Velocidade} km/h");

//     }

//     public override string ToString()
//     {
//         return $"Modelo: {Modelo}, Ano: {Ano}, Velocidade: {Velocidade} km/h";
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("***** Meu Carro *****");


//         Console.WriteLine("\nDigite as informações do seu carro:");
//         Console.Write("Modelo: ");
//         string modeloDoCarro = Console.ReadLine();
//         Console.Write("Ano: ");
//         int anoDeFabricacao = int.Parse(Console.ReadLine());

//         Carro carro = new Carro(modeloDoCarro, anoDeFabricacao);

//         Console.WriteLine("\n---------------- Resultado ----------------");
//         Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade: {carro.Velocidade}");

//         carro.Acelerar();
//         Console.WriteLine($"Acelerando... Velocidade: {carro.Velocidade}");

//         carro.Acelerar();
//         Console.WriteLine($"Acelerando mais uma vez... Velocidade: {carro.Velocidade}");

//         carro.Frear();
//         Console.WriteLine($"Freando uma vez... Velocidade: {carro.Velocidade}");

//         carro.Frear();
//         Console.WriteLine($"Freando... Velocidade: {carro.Velocidade}");

//         Console.ReadKey();
//     }
// }
