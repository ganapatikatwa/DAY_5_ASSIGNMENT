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
            }
        }
    }
}