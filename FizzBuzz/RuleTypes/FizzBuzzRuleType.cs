namespace FizzBuzz.RuleTypes
{
    public class FizzBuzzRuleType : RuleType
    {
        private string _result = string.Empty;

        public override string Result { get { return _result; } }

        public override bool CheckNumber(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                _result = Constants.FIZZBUZZ;
                return true;
            }
            return false;
        }
    }
}
