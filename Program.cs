using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number ");
            int second = int.Parse(Console.ReadLine());
             Console.WriteLine("----------------------");
            for (int i = first; i <=second ; i++) 
            {
                if (i == 0 || i == 1)
                    continue;
                int c = 0;
               
                for (int j = 2; j <= i /2; j++) 
                {

                    if (i % j == 0)
                    {
                        c++; 
                        break;
                    }
                }
                if (c == 0 )
                    Console.WriteLine(i); 

              

            }
                Console.WriteLine("----------------------\nend");
                   


        }
    }
}
