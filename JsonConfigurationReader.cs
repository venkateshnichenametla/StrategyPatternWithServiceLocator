namespace StrategyPatternWithServiceLocator
{
    public class JsonConfigurationReader : IConfigurationReader
    {
        public string GetMessage()
        {
            return "I'm JsonConfiguration Reader";
        }
    }
}
