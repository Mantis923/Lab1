/// Lab-Week2(Graded Assignment)	
/// File Name: HomeWork2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Aokola
///
///Modified the MYFirstProgram.cs file so that it adds three integers instead of two.
/// Then stored the three numbers in a variable. The program is compiled so that there is 
/// no compiler error message and then ran. Then the MyFirstProgram.cs is modified so that
/// it also multiplies the same three numbers and stores the result in a variable.
/// Lastly divide the sum of three numbers by the product of the same three numders.
/// Lastly the program is tested. No numbers is used 3 times nor the numbers 1,2,3 as input.
/// When the program is ran correctly, the project published to GitHub and submit the project
/// URL in canvas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Graded_Assignment_
{
    class Lab1
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.Write("Enter one number and press enter and  then repeat two more times (three times total):");

            // declare two integer variables
            int n1, n2, n3, sum, product;
            double division;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());
            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            division = (double)sum / product;
            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is: " + sum);
            Console.WriteLine("The product of the three numbers is: " + product);
            Console.WriteLine("The division of the three numbers is: " + division.ToString("0.00"));


            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}