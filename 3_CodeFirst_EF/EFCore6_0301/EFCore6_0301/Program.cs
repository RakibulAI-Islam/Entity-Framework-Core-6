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
            Console.WriteLine("Hello, World!");

        }

        static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("App_Setting.json",optional: true,reloadOnChange: true);
        }

    }
}

