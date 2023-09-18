using FizzBuzz.Factories;
using FizzBuzz.RuleTypes;
using System.Data;

namespace FizzBuzz
{
    public class NumberCruncher
    {
        public string CheckNumber(int number)
        {
            RuleTypeFactory ruleTypeFactory = new RuleTypeFactory();
            List<string> rules = new List<string>
            {
                "FizzBuzz",
                "Fizz",
                "Buzz"
            };

            foreach (string rule in rules)
            {
                RuleType ruleType = ruleTypeFactory.Create(rule);
                if (ruleType != null)
                {
                    if (ruleType.CheckNumber(number)) { return ruleType.Result; }
                }
            }
            return number.ToString();
        }

        public List<string> CheckNumberRange(int min, int max)
        {
            return new List<string>();
        }
    }
}
