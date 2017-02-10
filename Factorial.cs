//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// Factorial.cs
// compile with: /target:library
using System; 

// Declares a namespace. You need to package your libraries according
// to their namespace so the .NET runtime can correctly load the classes.
namespace Functions 
{ 
    public static class Factorial 
    {
        /*
        * FUNCTION : Calc
        *
        * DESCRIPTION : This function calculates the factorial of a given number, handles negative numbers
        *
        * PARAMETERS : int i : the number to have a factorial calculation
        *
        * RETURNS : int : the final number that is calculated
        */
        public static int Calc(int i) 
        {

            Exception MyException = new Exception("That is a negative Number!");

            //If not negative, calculate facotial
            if (i < 0)
            {
                throw (MyException);
            }
            else
            {
                i = ((i <= 1) ? 1 : (i * Calc(i - 1)));
            }
            return i;
        } 
    }
}

