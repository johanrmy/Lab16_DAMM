using Laboratorio16.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio16.ViewModel
{
    public class RickAndMortyApiService
    {
        private readonly HttpClient _httpClient;

        public RickAndMortyApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            try
            {
                string jsonString = await _httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");

                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonString);

                List<Character> characters = apiResponse.Results;

                return characters;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener personajes: {ex.Message}");
                return new List<Character>();
            }
        }
    }


}
