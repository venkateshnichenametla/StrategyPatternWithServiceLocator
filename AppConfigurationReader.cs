namespace StrategyPatternWithServiceLocator
{
    public class AppConfigurationReader : IConfigurationReader
    {
        public string GetMessage()
        {
            return "I'm AppConfiguration Reader";
        }
    }
}
