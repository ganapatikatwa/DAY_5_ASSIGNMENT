using System;

namespace C_Programming
{
    public class Program
    {

        public static void Main(string[] args)
        {
            {
                Flip_Coin obj = new Flip_Coin();


                Console.WriteLine("Flip coin problem");
                obj.FlipCoin();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Leap_year leap_Year = new Leap_year();
                leap_Year.Leap_Year();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Powers of Two");
                Power_Of_2 power_Of_2 = new Power_Of_2();
                power_Of_2.Pow_2();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Harmonic Problem");

                Harmonic obj2 = new Harmonic();
                obj2.Harmonic1();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Even Or Odd");
                EvenOrOdd obj3 = new EvenOrOdd();
                obj3.Even_Or_Odd();
            }
        }
    }
}