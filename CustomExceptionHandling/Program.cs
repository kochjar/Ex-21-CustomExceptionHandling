using TotallySafeLib;
namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // GetValueAtPosition
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-1);
                Console.WriteLine(posValue);
            }
            catch (NegativeIndexOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // Divider
            try
            {
                double num = TotallySafe.Divider(2);
                Console.WriteLine(num);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // StringToInt
            try
            {
                int num = TotallySafe.StringToInt("ekf");
                Console.WriteLine(num);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }


            Console.ReadLine();

        }
    }
}