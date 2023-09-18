namespace FizzBuzz.RuleTypes
{
    public abstract class RuleType
    {
        public abstract string Result { get; }
        public abstract bool CheckNumber(int value);
    }
}
