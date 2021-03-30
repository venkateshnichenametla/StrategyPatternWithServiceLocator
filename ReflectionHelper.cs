using System;
using System.Collections.Generic;
using System.Reflection;
namespace StrategyPatternWithServiceRegistry
{
    public class ReflectionHelper
    {
        public static List<Type> GetAllClassesThatEndsWith(string endName)
        {
            List<Type> types = new List<Type>();
            foreach (Type type in Assembly.Load(Assembly.GetExecutingAssembly().GetName()).GetTypes())
            {
                if (!type.Name.EndsWith(endName))
                    continue;
                types.Add(type);
            }
            return types;
        }
    }
}
