using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 2.2 Inspektion og afprøvning
            // Test GetValueAtPosition med tallene 1, 4, 9 og -2
            // 9 og -2 giver IndexOutOfRangeExeption

            // Øvelse 2.3 Håndtering af exception (try-catch)
            // Øvelse 2.4 Inspektion og afprøvning af Divider og StringToInt metoden

            try {
                double divider = TotallySafe.Divider(2);
                Console.WriteLine(divider);

                // string s = null; //Test ArgumentNullException
                int stringToInt = TotallySafe.StringToInt("1350");
                Console.WriteLine(stringToInt);

                int posValue = TotallySafe.GetValueAtPosition(-1);
                Console.WriteLine(posValue);

            }
            catch(NegativeIndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex) {
                // Get the error message out the exception that has been thrown
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid number.");

            }
            catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Input string must contain numbers.");
            }

            Console.ReadLine();

        }
    }
}