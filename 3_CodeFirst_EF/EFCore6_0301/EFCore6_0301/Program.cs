// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.Extensions.Configuration;
using System;

namespace EFCore6_0301
{
    class Program
    {
        private static IConfigurationRoot _configuration;
        static void Main(string[] args)
        {
            BuildConfiguration();

            //Console.WriteLine("Hello, World!");
            Console.WriteLine($"CNSTR: { _configuration.GetConnectionString("AdventureWorks_2022")}");

        }

        static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("App_Settings.json", optional: true, reloadOnChange: true);
            
            _configuration = builder.Build();
        }

    }
}

