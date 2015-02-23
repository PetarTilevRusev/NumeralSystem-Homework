using System;
                /*Problem 1. Decimal to binary
                
                    Write a program to convert decimal numbers to their binary representation.
                */

static class StringHelper
{
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
class DecimalToBinary
{
    static void Main()
    {

        Console.Write("Your number: ");
        string userNumber = Console.ReadLine();
        int number;
        string binaryNumber = string.Empty;

        if (int.TryParse(userNumber, out number) == false)
        {
            return;
        }

        while (number > 1)
        {
            if (number % 2 == 0)
            {
                binaryNumber += "0";
            }
            else
            {
                binaryNumber += "1";
            }

            number /= 2;
        }

        Console.WriteLine(StringHelper.ReverseString(binaryNumber));
        
    }
}

