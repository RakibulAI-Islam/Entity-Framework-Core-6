
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace M_EFCore6_0302
{
    //2.public sealed class ConfigurationBuilderSingleton
    //1.public sealed class ConfigurationBuilderSingleton
    public sealed class ConfigurationBuilderSingleton
    {
        private static ConfigurationBuilderSingleton _instance = null;

        private static readonly object _instanceLock = new object();

        public static IConfigurationRoot _configuration;

        /*private*/

        private ConfigurationBuilderSingleton()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        /*public*/
        public static ConfigurationBuilderSingleton Instance
        {
            get
            {
                if (_instance == null)
                { _instance = new ConfigurationBuilderSingleton(); }

                return _instance;
            }
        }

        /*public*/
        public static IConfigurationRoot ConfigurationRoot
        {
            get
            {
                if( _configuration == null)
                { var x = Instance; }

                return _configuration;
            }
        }
    }
}
