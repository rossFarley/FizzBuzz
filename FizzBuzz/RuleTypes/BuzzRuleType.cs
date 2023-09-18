namespace FizzBuzz.RuleTypes
{
    public class BuzzRuleType : RuleType
    {
        private string _result = string.Empty;

        public override string Result { get { return _result; } }

        public override bool CheckNumber(int value)
        {
            if (value % 5 == 0)
            {
                _result = Constants.BUZZ;
                return true;
            }
            return false;
        }
    }
}
