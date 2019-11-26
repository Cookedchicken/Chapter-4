using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popquiz
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            int temp8AM;
            int temp12PM;
            int temp5PM;
            int temp8AMcelsious;
            int temp12PMcelsious;
            int temp5PMcelsious;
            Console.WriteLine("What's the tempature at 8:00am ");
            temp8AM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the tempature at 8:00am ");
            temp12PM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the tempature at 8:00am ");
            temp5PM = Convert.ToInt32(Console.ReadLine());

            if(temp8AM <=32 || temp12PM <=32 || temp5PM <= 32) { 
                Console.WriteLine("It's feezing ");
                {
                else if (temp8AM > -100 || temp12PM > -100 || temp5PM > -100) {
                        Console.WriteLine("It is Hot!");
                    }

 }