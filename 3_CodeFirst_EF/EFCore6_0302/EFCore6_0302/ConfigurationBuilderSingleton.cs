using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6_0302
{
    public sealed class ConfigurationBuilderSingleton
    {
        private static ConfigurationBuilderSingleton _instance = null;

        private static readonly object instanceLock = new object();

        private static IConfigurationRoot _configuration;
        
        private ConfigurationBuilderSingleton()
        {
            var builder = new ConfigurationBuilder().SetBasePath( Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static ConfigurationBuilderSingleton Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (_instance == null) { _instance = new ConfigurationBuilderSingleton(); }

                    return _instance;
                }
            }
        }

        public static IConfigurationRoot ConfigurationRoot
        {
            get
            {
                if ( _configuration == null) { var x = Instance; }

                return _configuration;
            }
        }


    }
}
