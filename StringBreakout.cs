//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// StringBreakout.cs
// compile with: /target:library
using System; 

// Declare the same namespace as the one in Factorial.cs. This simply 
// allows types to be added to the same namespace.
namespace Functions 
{
    public static class StringBreakout
    {
        // The NumberOfDigits static method calculates the number of
        // digit characters in the passed string:
        public static int NumberOfDigits(string theString) 
        {
            int count = 0; 
            for ( int i = 0; i < theString.Length; i++ ) 
            {
                if ( Char.IsDigit(theString[i]) ) 
                {
                    count++; 
                }
            }

            return count;
        }

        // The NumberOfAlphas static method calculates the number of
        // alphabetic characters in the passed string:
        public static int NumberOfAlphas(string theString)
        {
            int count = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsLetter(theString[i]))
                {
                    count++;
                }
            }

            return count;
        }

        // The NumberOfOthers static method calculates the number of
        // non-digit / non-alphabetic characters in the passed string:
        //
        // *********************************************************************************
        //  QUESTION : is there a better and more reliable way to determine
        //             the number of "others" ?  Does it matter which order
        //             the NumberOfDigits(), NumberOfAlphas() and NumberOfOthers()
        //             methods are called ?
        // *********************************************************************************
        public static int NumberOfOthers(string theString)
        {
            int count = theString.Length; // start with the length of the string

            int numAlphas = NumberOfAlphas(theString);
            int numDigits = NumberOfDigits(theString);

            count -= (numAlphas + numDigits);

            return count;
        }

        /*
        * FUNCTION : FindAndExtractDigits
        *
        * DESCRIPTION : This function extracts all of the digits from a string of characters.
        *
        * PARAMETERS : string  theString : the string to have numbers extracted
        *
        * RETURNS : int : the final number that is extracted.
        */
        public static int FindAndExtractDigits(string theString)
        {
            string Number = "";
            int finalNumber = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsDigit(theString[i]))
                {
                    Number += theString[i];
                }
            }

            if(Number == "")
            {
                finalNumber = -1;
            }
            else
            {
                finalNumber = Convert.ToInt32(Number);     
            }

            return finalNumber;
        }

    }
}

