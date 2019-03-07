using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Interfaces
{
    public interface ICheckPrime
    {
        bool IsPrime(int number);
        bool hasZero(string number);
        int RemoveZero(string number);
        bool CheckInput(char[] result);
    }
}
