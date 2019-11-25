using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10): // creates a number between 1 and 10
            int userEnegry;
            string choice; 
            Console.WriteLine("Please enetr a number between 1 and 10");
            userEnegry = Convert.ToInt32(Console.ReadLine());
            
            if (userEnegry == rndNumber)

            {
                Console.WriteLine("How did you know it was {0}?" , userEnegry);
                Console.WriteLine("Would you like to go for double or nothing?");
                choice = Console.ReadLine();
                if (choice.Equals("Yes"))
            }
            else
            {
                Console.WriteLine("{0} that was incorrect. " , userEnegry);
            }

            
        }
    }
}
