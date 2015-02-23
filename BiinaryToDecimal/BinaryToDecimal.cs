using System;
                /*Problem 2. Binary to decimal
                
                    Write a program to convert binary numbers to their decimal representation.
                
                */
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Your binary number: ");
        string userBinary = Console.ReadLine();
        
        int decimalNumber = 0;
        
        for (int i = 0; i < userBinary.Length; i++)
        {
            if (userBinary[userBinary.Length - i - 1] == '0')
            {
                continue;
            }

            decimalNumber += (int)Math.Pow(2, i);
        }

        Console.WriteLine(decimalNumber);
    }
}

