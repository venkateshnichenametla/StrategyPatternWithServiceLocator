using System;
using System.Collections.Generic;
namespace StrategyPatternWithServiceLocator
{
    public class ConfigurationServiceManager
    {
        private Dictionary<string, IConfigurationReader> _services = new Dictionary<string, IConfigurationReader>();
        public IConfigurationReader GetReader(string configurationSource)
        {
            if (_services.ContainsKey(configurationSource))
                return _services[configurationSource];
            return null;
        }

        public void RegisterAllReaders(List<Type> readers)
        {
            foreach (Type item in readers)
            {
                if (item.Name.Equals("IConfigurationReader"))
                    continue;
                RegisterReaderService(item.Name.Substring(0, item.Name.IndexOf("Reader")), Activator.CreateInstance(item) as IConfigurationReader);
            }
        }

        private void RegisterReaderService(string configurationSource, IConfigurationReader configurationReader)
        {
            if (!_services.ContainsKey(configurationSource))
                _services.Add(configurationSource, configurationReader);
        }
    }
}
