// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace HelloWorld{
    class Request{
        public string user {get; set; }
        
        public string password {get; set; }
    }
    class Program{
            static void Main(String[] args){
                var request = new Request{
                    user = "AL0217",
                    password = "Andylau0217*"
                };

                Console.WriteLine(request);

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://api.biblegateway.com/2/");

                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var requestUri = $"request_access_token?username=yunirrrsama@gmail.com&password=Andylau0217*";

                var response = client.GetAsync(requestUri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("success: " + responseContent);
                }   
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }

            }
    }
}