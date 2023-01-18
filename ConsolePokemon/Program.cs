using RestSharp;

namespace ConsolePokemon
{
    public class Program
    {
        private const string UrlPokeApi = "https://pokeapi.co/api/v2/pokemon";

        private static void Main(string[] args)
        {
            PokeApiGet();
        }

        private static void PokeApiGet()
        {
            RestClient client = new RestClient(UrlPokeApi);
            RestRequest request = new RestRequest("", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}