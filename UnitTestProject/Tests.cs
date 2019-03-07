using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using ConsoleAppTest;


namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private CheckPrime program;
        [OneTimeSetUp]
        public void Init()
        {
            program = new CheckPrime();
        }

        [TestCase("50054",ExpectedResult =554)]
        [TestCase("5104", ExpectedResult = 514)]
        [TestCase("5100004", ExpectedResult = 514)]
        [TestCase("510004", ExpectedResult = 514)]
        public int TestRemoveZero(string value)
        {
            return program.RemoveZero(value);
        }

        [TestCase("50054", ExpectedResult = true)]
        [TestCase("5504", ExpectedResult = true)]
        public bool hasZero(string value)
        {
            return program.hasZero(value);
        }

        [TestCase(13, ExpectedResult = true)]
        [TestCase(17, ExpectedResult = true)]
        public bool IsPrime(int value)
        {
            return program.IsPrime(value);
        }
    }
}