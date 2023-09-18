using FizzBuzz.Factories;
using FizzBuzz.RuleTypes;
using System.Data;

namespace FizzBuzz
{
    public class NumberCruncher
    {
        private List<string> _rules;
        private RuleTypeFactory _ruleTypeFactory;

        public NumberCruncher()
        {
            _ruleTypeFactory = new RuleTypeFactory();
            _rules = new List<string>
            {
                "FizzBuzz",
                "Fizz",
                "Buzz"
            };
        }

        public string CheckNumber(int number)
        {
            return ProcessNumber(number);
        }

        public List<string> CheckNumberRange(int min, int max)
        {
            List<string> result = new List<string>();
            for (int i = min; i <= max; i++)
            {
                result.Add(ProcessNumber(i));
            }
            return result;
        }

        private string ProcessNumber(int value)
        {
            foreach (string rule in _rules)
            {
                RuleType ruleType = _ruleTypeFactory.Create(rule);
                if (ruleType != null)
                {
                    if (ruleType.CheckNumber(value)) { return ruleType.Result; }
                }
            }
            return value.ToString();
        }
    }
}
