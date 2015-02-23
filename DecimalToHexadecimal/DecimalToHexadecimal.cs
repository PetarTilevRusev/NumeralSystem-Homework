using System;
                /*Problem 3. Decimal to hexadecimal
                
                    Write a program to convert decimal numbers to their hexadecimal representation.
                
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
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Your number: ");
        string userNumber = Console.ReadLine();
        int number;
        string hexadecimal = string.Empty;

        if (int.TryParse(userNumber, out number) == false)
        {
            return;
        }

        while (number >= 1)
        {
            int checker = number % 16;

            switch (checker)
            {
                case 0:
                    hexadecimal += "0";
                    break;
                case 1:
                    hexadecimal += "1";
                    break;
                case 2:
                    hexadecimal += "2";
                    break;
                case 3:
                    hexadecimal += "3";
                    break;
                case 4:
                    hexadecimal += "4";
                    break;
                case 5:
                    hexadecimal += "5";
                    break;
                case 6:
                    hexadecimal += "6";
                    break;
                case 7:
                    hexadecimal += "7";
                    break;
                case 8:
                    hexadecimal += "8";
                    break;
                case 9:
                    hexadecimal += "9";
                    break;
                case 10:
                    hexadecimal += "A";
                    break;
                case 11:
                    hexadecimal += "B";
                    break;
                case 12:
                    hexadecimal += "C";
                    break;
                case 13:
                    hexadecimal += "D";
                    break;
                case 14:
                    hexadecimal += "E";
                    break;
                case 15:
                    hexadecimal += "F";
                    break;
                default:
                    break;
            }

            number /= 16;
        }

        Console.WriteLine(StringHelper.ReverseString(hexadecimal));
    }
}

