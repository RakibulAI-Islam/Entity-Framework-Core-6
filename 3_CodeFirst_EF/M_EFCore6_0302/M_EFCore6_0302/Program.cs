// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Net.NetworkInformation;
using _2_EF_DBLibrary;  



namespace M_EFCore6_0302
{
    public class Program
    {
        private static IConfigurationRoot _configuration;

        private static DbContextOptionsBuilder<InventoryDbContext> _optionBuilder;


        static void Main(string[] args)
        {
            BuildOptions();
            //Console.WriteLine("Hello, World!");
        }

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;

            _optionBuilder = new DbContextOptionsBuilder<InventoryDbContext>();

            _optionBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
        }
    }
}


