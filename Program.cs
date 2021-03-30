using System;
namespace StrategyPatternWithServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            ConfigurationServiceManager configurationServiceManager = new ConfigurationServiceManager();
            configurationServiceManager.RegisterAllReaders(configurationManager.Readers);
            string input = Console.ReadLine();
            configurationManager.ConfigurationReader = configurationServiceManager.GetReader(input);
            if (configurationManager.ConfigurationReader == null)
            {
                Console.WriteLine("No such reader exists");
            }
            else
            {
                Console.WriteLine(configurationManager.ConfigurationReader.GetMessage());
            }
            Console.ReadLine();
        }
    }
}
