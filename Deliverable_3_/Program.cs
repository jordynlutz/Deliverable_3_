/* 
 * Name: Jordyn Lutz
 * Date: 1/30/2023
 * Description: Deliverable 3 loops
 */

using System;
using System.Linq.Expressions;

namespace Deliverable_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            { 
          
                    Console.WriteLine("Enter an integer number between 1 and 100:");
                   int input = int.Parse(Console.ReadLine());
                    if (input >= 1 && input <= 100)
                   
            

                    Console.Write("Specify the series type: Even or Odd: ");
                   string series  = Console.ReadLine();



                if (series == "Odd")
                {
                    Console.WriteLine("You have selected" + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }


                else
                {
                    Console.WriteLine("Please enter either Even OR Odd!");
                }

                    
                }
            catch
            {
                Console.WriteLine("Please enter an integer number value for this input!");
            }







        }
    }
}

