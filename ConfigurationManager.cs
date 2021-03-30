using StrategyPatternWithServiceRegistry;
using System;
using System.Collections.Generic;

namespace StrategyPatternWithServiceLocator
{
    class ConfigurationManager
    {
        private IConfigurationReader _reader;
        public IConfigurationReader ConfigurationReader
        {
            get { return _reader; }
            set { _reader = value; }
        }
        public List<Type> Readers
        {
            get { return ReflectionHelper.GetAllClassesThatEndsWith("Reader"); }
        }
    }
}
