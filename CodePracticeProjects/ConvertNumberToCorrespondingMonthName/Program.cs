using System;
using System.Globalization;

namespace ConvertNumberToCorrespondingMonthName
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Convert Number to Corresponding Month Name");

                int input = int.Parse(Console.ReadLine());
                ConvertNumberToMonth(input);
                Console.ReadKey();
            }

            private static void ConvertNumberToMonth(int monthNumber)
            {                
                if (monthNumber < 1 || monthNumber > 12)
                {
                    Console.WriteLine($"{monthNumber} doesn't correspond to a month");
                }
                else
                {
                    string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames; // getting the list of month names

                    switch (monthNumber)
                    {
                        case 1:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[0]}");
                            break;
                        case 2:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[1]}");
                            break;
                        case 3:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[2]}");
                            break;
                        case 4:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[3]}");
                            break;
                        case 5:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[4]}");
                            break;
                        case 6:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[5]}");
                            break;
                        case 7:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[6]}");
                            break;
                        case 8:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[7]}");
                            break;
                        case 9:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[8]}");
                            break;
                        case 10:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[9]}");
                            break;
                        case 11:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[10]}");
                            break;
                        case 12:
                            Console.WriteLine($"{monthNumber} corresponds to {monthNames[11]}");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
