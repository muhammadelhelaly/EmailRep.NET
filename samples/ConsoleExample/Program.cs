﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var settings = new EmailRep.NET.EmailRepClientSettings();
            settings.UserAgent = "consoleapp/test";

            settings.ApiKey = "**** insert api key here ****";

            var emailRepClient = new EmailRep.NET.EmailRepClient(client, settings);

            var response = await emailRepClient.QueryEmailAsync("bill@microsoft.com");

            Console.WriteLine($"Name: {response.Email} ({response.Reputation}).");
        }
    }
}
