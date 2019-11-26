using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("Please enter your message ");
            entry = Console.ReadLine();

            if(entry.Length <= 140)
            {
                Console.WriteLine("The lentgh of your message is accepatble" + entry.Length);
            }
            else
            {
                Console.WriteLine("Message to long " + entry.Length);
            }

        }
    }
}
