namespace FizzBuzz.RuleTypes
{
    public class FizzRuleType : RuleType
    {
        private string _result = string.Empty;

        public override string Result { get { return _result; } }

        public override bool CheckNumber(int value)
        {
            if (value % 3 == 0)
            {
                _result = Constants.FIZZ;
                return true;
            }
            return false;
        }
    }
}