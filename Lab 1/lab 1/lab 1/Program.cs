using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Write a program to print 'Hello' on screen and then print your name on
 a separate line. */
            Console.WriteLine("Hello");
            Console.WriteLine("FAZLA IMAM DIP");


            /* 2. Write a program to print the sum of two numbers. */

            int a = 20;
            int b = 10;

            Console.WriteLine("The sum is " + (a + b));

            /*3. Write a program to divide two numbers and print on the screen.*/

             a = 20;
             b = 10;

            Console.WriteLine("The divition of two numbers " + (a / b));


            /*4. Write a program to print the result of the following operations.
Data:
a. -5 + 8 * 6
b. (55+9) % 9
c. 20 + -3*5 / 8
d. 5 + 15 / 3 * 2 - 8 % 3*/

            Convert.ToDouble(a);
            a= -5 + 8 * 6;
            Console.WriteLine(a);
            a = (55 + 9) % 9;
            Console.WriteLine(a);
            a = 20 + -3 * 8 / 5;
            Console.WriteLine(a);
            a = 5 + 15 / 3 * 2 / 8 % 3;
            Console.WriteLine(a);


            /*5. Write a program to print the sum (addition), multiply, subtract, divide
and remainder of two numbers. */


            Convert.ToInt32(a);
                a= 20;

               b = 10;

            Console.WriteLine("The addition of two numbers " + (a + b));
            Console.WriteLine("The substraction of two numbers " + (a - b));
            Console.WriteLine("The divition of two numbers " + (a / b));
            Console.WriteLine("The multiplication of two numbers " + (a * b));
            Console.WriteLine("The the reminder of two numbers " + (a % b));


            /*6. Write a program to compute the specified expressions and print the
output.
Expression:
((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)) */



            Convert.ToDouble(a);

                a = (int)(((25.5 * 3.5) - 3.5 * 3.5) / (40.5 - 4.5));

            Console.WriteLine(a);


            /*7. Write a program to print the area and perimeter of a rectangle.
Data:
Width = 5.5 Height = 8.5
Sample Output:
Area is 5.6 * 8.5 = 47.60
Perimeter is 2 * (5.6 + 8.5) = 28.20 */



            double width = 5.5;
            double height = 8.5;

            Console.WriteLine("Area is 5.6 * 8.5 = " + (width * height));
            Console.WriteLine("Perimeter is 2 * (5.6 + 8.5) = " + (2 * (width + height)));



        }
    }
}
