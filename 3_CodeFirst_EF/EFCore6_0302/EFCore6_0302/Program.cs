// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFCore6_0302;

public class Program
{
    private static IConfigurationRoot _configuration;

    //private static DbContextOptionsBuilder<InventoryDbContext> _optionBuilder;

    static void Main(string[] args)
    {
        BuildOptions();
    }

    static void BuildOptions()
    {
        _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
        //_optionBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
        //_optionBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
    }
}
