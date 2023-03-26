using TotallySafeLib;
namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int posValue = TotallySafe.GetValueAtPosition(-1);

            Console.WriteLine(posValue);

            Console.ReadLine();


        }
    }
}