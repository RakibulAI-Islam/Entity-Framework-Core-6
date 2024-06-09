// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using System.Net.NetworkInformation;

public class Program
{
    private static IConfigurationRoot _configuration;
    
    static void Main(string[] args)
    {
        BuildOptions();
        //Console.WriteLine("Hello, World!");
    }

    static void BuildOptions()
    {
        _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
    }

}

