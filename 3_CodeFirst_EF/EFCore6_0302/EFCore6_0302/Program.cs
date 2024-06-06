// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFCore6_0302;
using _1_EF_DbLibrary;

public class Program
{
    private static IConfigurationRoot _configuration;

    //private static DbContextOptionsBuilder<Inventory_2022_Context> _optionBuilder;

    static void Main(string[] args)
    {
        BuildOptions();
    }

    static void BuildOptions()
    {
        _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
        
        //_optionBuilder = new DbContextOptionsBuilder<Inventory_2022_Context>();
        //_optionBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
    }
}
