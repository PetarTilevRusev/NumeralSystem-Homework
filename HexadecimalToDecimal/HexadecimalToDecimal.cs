using System;
                /*Problem 4. Hexadecimal to decimal
                
                    Write a program to convert hexadecimal numbers to their decimal representation.
                
                */
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Your hexadecimal number: ");
        string userHexadecimal = Console.ReadLine();

        int decimalNumber = 0;

        for (int i = 0; i < userHexadecimal.Length; i++)
        {
            int tempNumber = 0;
            var checker = userHexadecimal[userHexadecimal.Length - i - 1];
            {
                switch (checker)
                {
                    case '0':
                        tempNumber = 0;
                        break;
                    case '1':
                        tempNumber = 1;
                        break;
                    case '2':
                        tempNumber = 2;
                        break;
                    case '3':
                        tempNumber = 3;
                        break;
                    case '4':
                        tempNumber = 4;
                        break;
                    case '5':
                        tempNumber = 5;
                        break;
                    case '6':
                        tempNumber = 6;
                        break;
                    case '7':
                        tempNumber = 7;
                        break;
                    case '8':
                        tempNumber = 8;
                        break;
                    case '9':
                        tempNumber = 9;
                        break;
                    case 'A':
                        tempNumber = 10;
                        break;
                    case 'B':
                        tempNumber = 11;
                        break;
                    case 'C':
                        tempNumber = 12;
                        break;
                    case 'D':
                        tempNumber = 13;
                        break;
                    case 'E':
                        tempNumber = 14;
                        break;
                    case 'F':
                        tempNumber = 15;
                        break;
                    default:
                        break;
                }
            }

            decimalNumber += tempNumber * (int)Math.Pow(16, i);
        }

        Console.WriteLine(decimalNumber);
    }
}

