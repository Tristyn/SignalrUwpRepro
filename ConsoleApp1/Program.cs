using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(4000);
            // Wait for the server to listen

            await new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/api/v1/myhub")
                .Build()
                .StartAsync();
            
            Console.WriteLine("Hello World!");
        }
    }
}
