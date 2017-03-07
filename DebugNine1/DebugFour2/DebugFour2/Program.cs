// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order
// in reverse order
// or in neither order
using System;
using static System.Console;

namespace DebugFour2
{
    class DebugFour2
    {
        static void Main()
        {
            //add ; to the end of num3
            int num1, num2, num3;
           string snum1, snum2, snum3;
            Write("Enter first number ");
            snum1 = ReadLine();
            num1 = Convert.ToInt32(snum1);
            Write("Enter second number ");
            snum2 = ReadLine();
            num2 = Convert.ToInt32(snum2);
            Write("Enter third number ");
            snum3 = ReadLine();
            num3 = Convert.ToInt32(snum3);
            //needs to be that num2 is greater than or equal  to num3
            //this will allow it to be in reverse order.
            if (num1 > num2 && num2 > num3)
                WriteLine("Numbers are in reverse order");
            //else if is on one line, and num3 needs to be greater then or equal num2
            //this will allow it to be in sequential order
            else if (num1 < num2 && num2 < num3)
                WriteLine("Numbers are in sequential order");
            else
                WriteLine("Numbers are in neither sequential nor reverse order");
        }
    }
}
