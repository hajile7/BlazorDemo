using System.Net.Http.Json;
using BlazorPractice.Models;

namespace BlazorPractice.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        private readonly string url = "https://localhost:7160/";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserDTO>> GetUsersAsync() 
        {
            return await _httpClient.GetFromJsonAsync<List<UserDTO>>($"{url}api/Users");
        }

        public async Task<bool> CreateUser(RegisterModel newUser) 
        {
            var response = await _httpClient.PostAsJsonAsync($"{url}api/Users", newUser);
            return response.IsSuccessStatusCode;
        } 

    }
}