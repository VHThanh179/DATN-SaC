using Newtonsoft.Json;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class AppAuthClient
    {
        private HttpClient _httpClient;
        public AppAuthClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TokenResponseModel> LoginGoogleCustomer(LoginGoogleCustomer googleCustomer)
        {
            var postData = new StringContent(JsonConvert.SerializeObject(googleCustomer), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("Access-Control-Alow-Origin", "*");
            var response = await _httpClient.PostAsync("customer/login-google-customer", postData);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TokenResponseModel>();
        }
    }
}
