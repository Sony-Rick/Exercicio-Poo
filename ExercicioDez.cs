// public class Animal
// {
//     public string Nome { get; set; }
//     public string Especie { get; set; }
//     public int Idade { get; set; }

//     public Animal(string nome, string especie, int idade)
//     {
//         Nome = nome;
//         Especie = especie;
//         Idade = idade;
//     }

//     public void EmitirSom(string somDoAnimal)
//     {
//         Console.WriteLine(somDoAnimal);
//     }

//     public override string ToString()
//     {
//         return $"Nome: {Nome}, Espécie: {Especie}, Idade: {Idade}";
//     }
// }

// public class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("***** Animal *****");

//         Console.WriteLine("\nDigite as informações do Animal: ");
//         Console.Write("Nome: ");
//         string nomeDoAnimal = Console.ReadLine();
//         Console.Write("Espécie: ");
//         string especieDoAnimal = Console.ReadLine();
//         Console.Write("Idade: ");
//         int idadeDoAnimal = int.Parse(Console.ReadLine());
//         Console.Write("Som: ");
//         string somDoAnimal = Console.ReadLine();

//         Animal animal = new Animal(nomeDoAnimal, especieDoAnimal, idadeDoAnimal);
        
//         Console.WriteLine("\n----- Resultado -----");
//         Console.WriteLine($"Nome: {animal.Nome}");
//         Console.WriteLine($"Espécie: {animal.Especie}");
//         Console.WriteLine($"Idade: {animal.Idade} anos");
//         Console.Write($"O animal emite o som: ");
//         animal.EmitirSom(somDoAnimal);

//         Console.ReadKey();
//     }
// }