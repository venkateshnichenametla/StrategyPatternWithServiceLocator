namespace StrategyPatternWithServiceLocator
{
    public class XmlConfigurationReader : IConfigurationReader
    {
        public string GetMessage()
        {
            return "I'm XmlConfiguration Reader";
        }
    }
}
