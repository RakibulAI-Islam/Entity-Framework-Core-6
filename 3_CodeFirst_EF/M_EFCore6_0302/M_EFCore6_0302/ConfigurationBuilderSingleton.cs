using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_EFCore6_0302
{ 
    //2.public sealed class ConfigurationBuilderSingleton
    //1.public sealed class ConfigurationBuilderSingleton
    public sealed class ConfigurationBuilderSingleton
    {
        private static ConfigurationBuilderSingleton _instance = null;
        
        private static readonly object _instanceLock = new object();

        public static IConfigurationRoot _configuration;
    }
}
