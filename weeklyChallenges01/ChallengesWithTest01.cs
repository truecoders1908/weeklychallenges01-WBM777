using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesWithTests01
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double total;
            total = minuend - subtrahend;
            return total;
            
        }

        public int Add(int number1, int number2)
        {
            int total;
            total = number1 + number2;
            return total;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public long Multiply(long factor1, long factor2)
        {
            long total;
            total = factor1 * factor2;
            return total;
        }

        public string GetGreeting(string nameOfPerson)
        {

            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return "Hello, " + nameOfPerson + "!";
            }


            
        }
        

        public string GetHey()
        {
            return "HEY!";
           
        }
    }
}