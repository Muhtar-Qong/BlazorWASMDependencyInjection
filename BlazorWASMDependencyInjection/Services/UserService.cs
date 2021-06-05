using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Net.Http.Json;
using BlazorWASMDependencyInjection.Models;

namespace BlazorWASMDependencyInjection.Services
{
    public class UserService: IUserService
    {
        private static string jsonPlaceHolderApiUrl = "https://jsonplaceholder.typicode.com/users";

        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await this.httpClient.GetFromJsonAsync<IEnumerable<User>>(jsonPlaceHolderApiUrl);
        }

    }
}
