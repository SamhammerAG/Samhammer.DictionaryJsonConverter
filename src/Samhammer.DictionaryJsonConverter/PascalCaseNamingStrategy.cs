using Newtonsoft.Json.Serialization;

namespace Samhammer.DictionaryJsonConverter
{
    public class PascalCaseNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            var pascalName = name.Substring(0, 1).ToUpper() + name.Substring(1);

            return pascalName;
        }
    }
}
