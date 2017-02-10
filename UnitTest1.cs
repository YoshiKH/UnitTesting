/// File : UnitTest1.cs
/// Project : Info2030 Software Quality II
/// Programmer : Anthony Bastos
/// First Version : 2017-01-29
/// Description : 
/// This file contains all of my unit tests and descriptions for the source file Functions and all
/// of its methods.



using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Functions;


namespace Asgnment1Testing
{
    [TestClass]
    public class UnitTestsAsgn1
    {
        string MyException = "That is a negative Number!";
        string ExceptionNumberTooBig = "Value was either too large or too small for an Int32.";


         /// TestIdentifier : 2000
         /// 
         /// Description : 
         /// This will test the Factorial function Calc() with normal input values.
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : 5
         /// 
         /// Expected Outputs : 120
         /// 
         /// Observed Outputs : The factorial succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         /// 
        [TestMethod]
        public void FactorialSuccess()
        {
            int number = 5;
            int final = 0;

            final = Factorial.Calc(number);

            Assert.AreEqual(120, final);
        }

        /// TestIdentifier : 2001
        /// 
        /// Description : 
        /// This will test the Factorial function Calc() with Boundary input values.
        /// This tests if the function can handle 1 as the incoming value.
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : 1
        /// 
        /// Expected Outputs : 1
        /// 
        /// Observed Outputs : The factorial succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        /// 
        [TestMethod]
        public void FactorialBoundaryLow()
        {
            int number = 1;
            int final = 0;

            final = Factorial.Calc(number);

            Assert.AreEqual(1, final);
        }

        /// TestIdentifier : 2002
        /// 
        /// Description : 
        /// This will test the Factorial function Calc() with Boundary input values.
        /// This tests if the function can handle 12 as the incoming value.
        /// After an input of 12, the number will exceed the size of an int.
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : 12
        /// 
        /// Expected Outputs : 479001600
        /// 
        /// Observed Outputs : The factorial succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void FactorialBoundaryHigh()
        {
            int number = 12;
            int final = 0;

            final = Factorial.Calc(number);

            Assert.AreEqual(479001600, final);
        }

        /// TestIdentifier : 2003
         /// 
         /// Description : 
         /// This will test the Factorial function Calc() with Boundary input values.
         /// This tests if the function can handle 13 as the incoming value, which it
         /// should not be able to handle, because the value of a 13 factorial is too big
         /// for an int.
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : 13
         /// 
         /// Expected Outputs : 6227020800, the correct factorial of 13
         /// 
         /// Observed Outputs : The factorial succeeds normally, the number returned is not the factorial
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void FactorialFailTooHigh()
        {
            int number = 13;
            int final = 0;

            final = Factorial.Calc(number);
            
            Assert.AreNotEqual(6227020800, final);
        }

        /// TestIdentifier : 2004
        /// 
        /// Description : 
        /// This will test the Factorial function Calc() with Excpetion input values.
        /// This will test if a negative number is accpeted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : -5
        /// 
        /// Expected Outputs : Excpetion
        /// 
        /// Observed Outputs : The factorial succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void FactorialException()
        {
            int number = -5;
            int final = 0;
            try
            {
                final = Factorial.Calc(number);
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, MyException);
            }            
        }

        /// TestIdentifier : 2005
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfDigits() with Success input values.
        ///
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : H55..el33lo2
        /// 
        /// Expected Outputs : 5
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfDigitsSuccess()
        {
            string theString = "H55..el33lo2";
            int final = 0;

            final = StringBreakout.NumberOfDigits(theString);

            Assert.AreEqual(5, final);
        }

        /// TestIdentifier : 2006
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfDigits() with Boundary input values.
        /// This tests if no numbers is inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : Hello
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfDigitsBoundaryNoNumbers()
        {
            string theString = "Hello";
            int final = 0;

            final = StringBreakout.NumberOfDigits(theString);

            Assert.AreEqual(0, final);
        }

        /// TestIdentifier : 2007
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfDigits() with Boundary input values.
        /// This tests if nothing is inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : Nothing
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfDigitsBoundaryNothing()
        {
            string theString = "";
            int final = 0;

            final = StringBreakout.NumberOfDigits(theString);

            Assert.AreEqual(0, final);
            
        }

        /// TestIdentifier : 2008
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfDigits() with Success/Boundary input values.
        /// This tests if there is only 1 number
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : 1H.
        /// 
        /// Expected Outputs : 1
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfDigitsSuccessOneNumber()
        {
            string theString = "1H.";
            int final = 0;

            final = StringBreakout.NumberOfDigits(theString);

            Assert.AreEqual(1, final);
        }

        /// TestIdentifier : 2009
         /// 
         /// Description : 
         /// This will test the StringBreakOut function NumberOfDigits() with Success/Boundary input values.
         /// This tests if there is a lot of numbers
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : 124567891274596812456789127459681245678912745968
         /// 
         /// Expected Outputs : 48
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void NumberOfDigitsBoundaryLotsOfNumbers()
        {
            string theString = "124567891274596812456789127459681245678912745968";
            int final = 0;

            final = StringBreakout.NumberOfDigits(theString);

            Assert.AreEqual(48, final);
        }

        /// TestIdentifier : 2010
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfAlphas() with Success input values.
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : H55..el33lo2
        /// 
        /// Expected Outputs : 5
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfAlphasSuccess()
        {
            string theString = "H55,,el33lo2";
            int final = 0;

            final = StringBreakout.NumberOfAlphas(theString);

            Assert.AreEqual(5, final);
        }

        /// TestIdentifier : 2011
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfAlphas() with Boundary input values.
        /// This tests if no alphas are inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : 12233
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfAlphasBoundaryNoAlphas()
        {
            string theString = "12233";
            int final = 0;

            final = StringBreakout.NumberOfAlphas(theString);

            Assert.AreEqual(0, final);
        }

        /// TestIdentifier : 2012
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfAlphas() with Boundary input values.
        /// This tests if nothing is inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : Nothing
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfAlphasBoundaryNothing()
        {
            string theString = "";
            int final = 0;

            final = StringBreakout.NumberOfAlphas(theString);

            Assert.AreEqual(0, final);

        }

        /// TestIdentifier : 2013
       /// 
       /// Description : 
       /// This will test the StringBreakOut function NumberOfAlphas() with Success/Boundary input values.
       /// This tests if there is only 1 alpha
       /// 
       /// Method Of Exectution : Automatic
       /// 
       /// Input Data : 1H.
       /// 
       /// Expected Outputs : 1
       /// 
       /// Observed Outputs : The function succeeds normally
       /// 
       /// Results If Failed : If the tests fails, calculation method is incorrect.
       /// 
       ///
        [TestMethod]
        public void NumberOfAlphasSuccessOneAlpha()
        {
            string theString = "1H.";
            int final = 0;

            final = StringBreakout.NumberOfAlphas(theString);

            Assert.AreEqual(1, final);
        }


         /// TestIdentifier : 2014
         /// 
         /// Description : 
         /// This will test the StringBreakOut function NumberOfAlphas() with Success/Boundary input values.
         /// This tests if there is a lot of alphas
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ
         /// 
         /// Expected Outputs : 78
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void NumberOfAlphasBoundaryLotsOfAlphas()
        {
            string theString = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int final = 0;

            final = StringBreakout.NumberOfAlphas(theString);

            Assert.AreEqual(78, final);
        }

        /// TestIdentifier : 2015
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfOthers() with Success input values.
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : H55..el33lo2
        /// 
        /// Expected Outputs : 2
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfOthersSuccess()
        {
            string theString = "H55,,el33lo2";
            int final = 0;

            final = StringBreakout.NumberOfOthers(theString);

            Assert.AreEqual(2, final);
        }

        /// TestIdentifier : 2016
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfOthers() with Boundary input values.
        /// This tests if no "others" is inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : H55el33lo2
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfOthersBoundaryNoOthers()
        {
            string theString = "H55el33lo2";
            int final = 0;

            final = StringBreakout.NumberOfOthers(theString);

            Assert.AreEqual(0, final);
        }

        /// TestIdentifier : 2017
        /// 
        /// Description : 
        /// This will test the StringBreakOut function NumberOfOthers() with Boundary input values.
        /// This tests if nothing is inputted
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : Nothing
        /// 
        /// Expected Outputs : 0
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void NumberOfOthersBoundaryNothing()
        {
            string theString = "";
            int final = 0;

            final = StringBreakout.NumberOfOthers(theString);

            Assert.AreEqual(0, final);

        }

      /// TestIdentifier : 2018
      /// 
      /// Description : 
      /// This will test the StringBreakOut function NumberOfOthers() with Success/Boundary input values.
      /// This tests if there is only 1 "other"
      /// 
      /// Method Of Exectution : Automatic
      /// 
      /// Input Data : 1H.
      /// 
      /// Expected Outputs : 1
      /// 
      /// Observed Outputs : The function succeeds normally
      /// 
      /// Results If Failed : If the tests fails, calculation method is incorrect.
      /// 
      ///
        [TestMethod]
        public void NumberOfOthersSuccessOneOther()
        {
            string theString = "1H.";
            int final = 0;

            final = StringBreakout.NumberOfOthers(theString);

            Assert.AreEqual(1, final);
        }


         /// TestIdentifier : 2019
         /// 
         /// Description : 
         /// This will test the StringBreakOut function NumberOfOthers() with Success/Boundary input values.
         ///
         /// This tests if there is many "Others"
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : .?/,!@#$%^&*.?/,!@#$%^&*.?/,!@#$%^&*
         /// 
         /// Expected Outputs : 36
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void NumberOfOthersBoundaryLotsOfOthers()
        {
            string theString = ".?/,!@#$%^&*.?/,!@#$%^&*.?/,!@#$%^&*";
            int final = 0;

            final = StringBreakout.NumberOfOthers(theString);

            Assert.AreEqual(36, final);
        }

         /// TestIdentifier : 2020
         /// 
         /// Description : 
         /// This will test the StringBreakOut function FindAndExtractDigits() with Success input values.
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : H55,,el33lo2
         /// 
         /// Expected Outputs : 55332
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void FindAndExtractDigitsSuccess()
        {
            string theString = "H55,,el33lo2";
            int final = 0;

            final = StringBreakout.FindAndExtractDigits(theString);

            Assert.AreEqual(55332, final);
        }

         /// TestIdentifier : 2021
         /// 
         /// Description : 
         /// This will test the StringBreakOut function FindAndExtractDigits() with Boundary input values.
         /// Checks if no numbers will be handled properly
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : H,,ello
         /// 
         /// Expected Outputs : -1
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void FindAndExtractDigitsBoundaryNoNumbers()
        {
            string theString = "H,,ello";
            int final = 0;

            final = StringBreakout.FindAndExtractDigits(theString);

            Assert.AreEqual(-1, final);
        }

         /// TestIdentifier : 2022
         /// 
         /// Description : 
         /// This will test the StringBreakOut function FindAndExtractDigits() with Boundary input values.
         /// Checks if Nothing inputted is handled properly
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : Nothing
         /// 
         /// Expected Outputs : -1
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void FindAndExtractDigitsBoundaryNothing()
        {
            string theString = "";
            int final = 0;

            final = StringBreakout.FindAndExtractDigits(theString);

            Assert.AreEqual(-1, final);
        }

        /// TestIdentifier : 2023
         /// 
         /// Description : 
         /// This will test the StringBreakOut function FindAndExtractDigits() with Success input values.
         /// Tests if one number can be extracted
         /// 
         /// Method Of Exectution : Automatic
         /// 
         /// Input Data : H5,
         /// 
         /// Expected Outputs : 5
         /// 
         /// Observed Outputs : The function succeeds normally
         /// 
         /// Results If Failed : If the tests fails, calculation method is incorrect.
         /// 
         ///
        [TestMethod]
        public void FindAndExtractDigitsOneNumber()
        {
            string theString = "H5,";
            int final = 0;

            final = StringBreakout.FindAndExtractDigits(theString);

            Assert.AreEqual(5, final);
        }

        /// TestIdentifier : 2024
        ///
        ///Description : 
        /// This will test the StringBreakOut function FindAndExtractDigits() with Exception input values.
        /// Tests if many numbers can be extracted and put into an int32
        /// 
        /// Method Of Exectution : Automatic
        /// 
        /// Input Data : 12456789127459
        /// 
        /// Expected Outputs : Excpeption, cannot accpet the int, too large
        /// 
        /// Observed Outputs : The function succeeds normally
        /// 
        /// Results If Failed : If the tests fails, calculation method is incorrect.
        /// 
        ///
        [TestMethod]
        public void FindAndExtractDigitsLotsOfNumbers()
        {
            string theString = "12456789127459";
            int final = 0;
            try
            {
                final = StringBreakout.FindAndExtractDigits(theString);
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, ExceptionNumberTooBig);
            }          
        }
    }
}
