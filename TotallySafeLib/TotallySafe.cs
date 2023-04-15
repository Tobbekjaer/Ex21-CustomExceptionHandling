using System;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };

            // Hvis input er negativt, throw new custom exception
            if (positionInArray < 0) {
                throw new NegativeIndexOutOfRangeException("MyCustomExceptionMessage: Parameter index cannot be negative.");
            }

            return intArray[positionInArray];
        }
    }

    // Definér din egen brugerdefinerede Exception klasse (indeholder 3 constructors)
    public class NegativeIndexOutOfRangeException : Exception
    {
        public NegativeIndexOutOfRangeException()
        { 
        }
        public NegativeIndexOutOfRangeException(string message) : base(message)
        {  
        }
        public NegativeIndexOutOfRangeException(string message, Exception inner) : base(message, inner)
        {            
        }
    }
}