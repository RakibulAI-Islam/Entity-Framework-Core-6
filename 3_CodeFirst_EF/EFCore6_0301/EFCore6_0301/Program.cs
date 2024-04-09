// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using _1_EF_DbLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace EFCore6_0301
{
    class Program
    {
        private static IConfigurationRoot _configuration;
        private static DbContextOptionsBuilder<AdventureWorks_2022Context> _optionsBuilder;
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
            //_optionsBuilder.UseSqlServer();
        }

        static void BuildOptions()
        {
            _optionsBuilder = new DbContextOptionsBuilder<AdventureWorks_2022Context>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorks_2022"));
        }

        static void ListPeople()
        {
            using ( var db = new AdventureWorks_2022Context( _optionsBuilder.Options))
            {
                var people = db.People.OrderByDescending(x => x.LastName).Take(20).ToList();

                foreach ( var person in people)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                }
            }
        }

    }
}

