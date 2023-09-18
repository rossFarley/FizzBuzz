using FizzBuzz.RuleTypes;

namespace FizzBuzz.Factories
{
    public class RuleTypeFactory
    {
        public RuleType Create(string ruleTypeEntry)
        {
            try
            {
                return (RuleType)Activator.CreateInstance(
                    Type.GetType($"FizzBuzz.RuleTypes.{ruleTypeEntry}RuleType"),
                        new object[] { });
            }
            catch
            {
                return null;
            }
        }
    }
}
