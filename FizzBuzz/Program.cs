namespace FizzBuzz
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                NumberCruncher numberCruncher = new NumberCruncher();
                List<string> results = numberCruncher.CheckNumberRange(1, 100);
                results.ForEach(Console.WriteLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}