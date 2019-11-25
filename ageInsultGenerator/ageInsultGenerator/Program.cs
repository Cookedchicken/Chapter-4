using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            String result;
            Console.WriteLine("Please enter an age so that I may fun of you!!");
            Console.WriteLine("If you call me a boomer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            //There will be under 12, between age 13 and 17
            //between age 18-25
            //age 26 - 35
            //36 - 45 
            //45 - 54
            //55 - 62
            //and 62+
            if (enterAge <= 12)
            {
                result = "You too young b.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem, actullay you're the problem.";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "Bruh actually get a job!";
            }
            else if (enterAge > 26 && enterAge <= 35)
            {
                result = "Imagine not having a job at your age, pathetic.";
            }
            else if (enterAge > 36 && enterAge <= 45)
            {
                result = "Do something with your life";
            }
            else if (enterAge > 45 && enterAge <= 54)
            {
                result = "I feel bad for you at this point";
            }
            else if (enterAge > 55 && enterAge <= 62)
            {
                result = "Hi boomer";
            }
            else if (enterAge <= 62)
            {
                result = "BOOMER";
            }
        }
    }
}
