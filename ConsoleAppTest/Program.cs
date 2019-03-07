using System;
using System.Linq;

namespace ConsoleAppTest
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            Program program = new Program();
            program.init();
        }

        public void init()
        {
            Console.WriteLine("Please enter a number:");          
            string number = Console.ReadLine();
            try
            {
                char[] result = number.ToCharArray();
                CheckPrime program = new CheckPrime(result);
                                            
                if (program.hasZero(number))
                {
                    this.ToConsole(program.CheckInput(result));                 
                }
                this.ToConsole(program.CheckInput(result));               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a number");
                Console.ReadKey();
                this.init();
            }
        }


        private void ToConsole(bool isprime)
        {
            if (isprime)
            {
                Console.WriteLine("The number is Robust Prime");             
            }
            else
            {
                Console.WriteLine("The number is not Robust Prime");
            }
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            this.init();
        }

    }

}
