using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleAppTest.Interfaces;

namespace ConsoleAppTest
{
    public class CheckPrime : ICheckPrime
    {
        private char[] input;
        public CheckPrime(char[] number)
        {
            input = number;
        }
        public CheckPrime()
        {

        }

       public bool CheckInput(char[] result)
        {
            List<bool> IsPrime = new List<bool>();
            char[] arr = new char[result.Length];
            for(int i = 1; i < result.Length; i++)
            {
                arr = result.ToList().GetRange(i, arr.Length - 1).ToArray();
                if (this.IsPrime(int.Parse(arr))){
                    IsPrime.Add(true);
                }
                else
                {
                    IsPrime.Add(false);
                }               
            }
            if (IsPrime.Any(x => x.Equals(false)))
            {
                return false;
            }
            return true;
                   
        }
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var limit = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= limit; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public bool hasZero(string number)
        {
            return number.Contains("0");
        }

        public int RemoveZero(string number)
        {          
            return Convert.ToInt32(string.Concat(number.Replace("0", "").Trim()));
        }
    }
}
