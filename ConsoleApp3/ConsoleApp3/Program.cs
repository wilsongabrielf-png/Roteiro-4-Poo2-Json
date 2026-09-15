using ConsoleApp3.Models;
using ConsoleApp3.Services;

class Program
{
    static async Task Main()
    {
        Console.Write("Digite o nome do Pokémon: ");
        string nome = Console.ReadLine() ?? "";

        PokemonService service = new PokemonService();

        Pokemon pokemon = await service.BuscarPokemon(nome);

        Console.WriteLine("\nPokemon encontrado!");
        Console.WriteLine($"ID: {pokemon.Id}");
        Console.WriteLine($"Nome: {pokemon.Name}");
        Console.WriteLine($"Altura: {pokemon.Height}");
        Console.WriteLine($"Peso: {pokemon.Weight}");
        Console.WriteLine($"Base Experience: {pokemon.BaseExperience}");
    }
}
