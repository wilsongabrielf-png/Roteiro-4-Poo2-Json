using ConsoleApp3.Models;
using System.Net.Http;
using System.Text.Json;

namespace ConsoleApp3.Services
{
    public class PokemonService
    {
        public async Task<Pokemon> BuscarPokemon(string nome)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}";

                string json = await client.GetStringAsync(url);

                Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(
                    json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                )!;

                return pokemon;
            }
        }
    }
}
