using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    class DisplayDaysofWeek
    {
        //public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        public bool DaysOfWeek(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine(" Today is Sunday!");
                    break;
                case 2:
                    Console.WriteLine(" Today is Monday!");
                    break;
                case 3:
                    Console.WriteLine(" Today is Tuesday!");
                    break;
                case 4:
                    Console.WriteLine(" Today is Wednesday!");
                    break;
                case 5:
                    Console.WriteLine(" Today is Thursday!");
                    break;
                case 6:
                    Console.WriteLine(" Today is Friday!");
                    break;
                case 7:
                    Console.WriteLine(" Today is Saturday!");
                    break;
                default:
                    Console.WriteLine("Please try again !");
                    return false;

            }
            return true;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Adding a do-while loop to continue to ask the 
             * customer for input until the customer enters 
             * 'exit'.*/

            bool startProgram = true;
            while (startProgram == true)
            {
                Console.WriteLine("Enter a number between 1 and 7: ");
                string userInput = (Console.ReadLine());

                //Check for exit condition
                if (userInput != "exit")
                {
                    int userNumber = Convert.ToInt32(userInput);

                    //Limit user input
                   /* if ((userNumber > 7) || (userNumber <= 0))
                    {
                        Console.WriteLine("Please try again Later");
                        break;
                    }*/

                    //Instance of the input
                    DisplayDaysofWeek number = new DisplayDaysofWeek();
                    if (number.DaysOfWeek(userNumber) != true)
                    {
                        continue;
                    }


                }
                else
                {
                    Console.Write("Thank you for using. ");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
