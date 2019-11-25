using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEntryGPA;
            int userEntryTestScore;
            Console.WriteLine("Please eneter your GPA >>>");
            userEntryGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please eneter your Test Score >>>");
            userEntryTestScore = Convert.ToInt32(Console.ReadLine());

            if (userEntryGPA > 3.0 && userEntryTestScore > 60)
            {
                Console.WriteLine("Accepted into school");
            }
            else if (userEntryGPA < 3.0 && userEntryTestScore > 80)
            {
                Console.WriteLine("Accepted into school");
            }
            else
            {
                Console.WriteLine("You have been rejected");
            }
        }
    }
}
