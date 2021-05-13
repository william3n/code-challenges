/*
* OBJECTIVE: Given the month and year as numbers, return whether that month contains a Friday 13th.
*/
using System;
using System.Globalization;
using System.Linq;

namespace FridayThirteenth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the month number");

            //reading the inputs from the user
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the year");
            int year = int.Parse(Console.ReadLine());

            // calling the method that checks whether a month from a year has a Friday 13th
            ContainsFridayThirtheeth(month, year); 
            Console.ReadKey();
        }

        private static void ContainsFridayThirtheeth(int month, int year)
        {
            if (month > 0 || month < 31)//Checking if the month entered is correct
            {
                if (year > 0 || month < 12) //Checking if the year entered is correct
                {
                    //retrieving the number of days in the month that was entered
                    int result = DateTime.DaysInMonth(year, month);

                    for (int i = 1; i < result; i++)
                    {
                        //Creating a date based on the month, year, and the current counter of the loop
                        DateTime date = DateTime.Parse($"{month}/{i}/{year}");

                        //Checking if the counter equals 13 and if it corresponds to the Friday
                        if (i == 13 && date.DayOfWeek == DayOfWeek.Friday)
                        {
                            Console.WriteLine(date.ToString("MMMM dd, yyyy") + " is/was/will be the Friday 13th for the month you entered");
                        }
                    }
                }
                else
                {
                    //Print this msg when the year is incorrect
                    Console.WriteLine("The year you have entered does not exit");
                }
            }
            else
            {
                //Print this msg when the month is incorrect
                Console.WriteLine("The month you have entered does not exit, please check your spelling");
            }
        }
    }
}
