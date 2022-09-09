using System;
using static System.Console;

namespace Week3Project
{
    class Week3Project
    {
        static void Main(String[] args)
        {
            string inputString;
            int appointmentType;
            decimal totalCost = 0;
            const decimal CHILD_COST = 50M, ADULT_COST = 75M, LABS_FEE = 25M, CHILD_COST_CHECKUP = 75M, ADULT_COST_CHECKUP = 100M;
            WriteLine("This application is for calculating the cost of your doctor's visit");
            Write("Enter appointment type | 1 for Sick Appointment | 2 for Check-up: ");
            inputString = ReadLine();
            appointmentType = Convert.ToInt32(inputString);
            switch(appointmentType)
            {
                case 1:
                    WriteLine("Sick Appointment");
                    Write("Is the patient an adult? Y/N: ");
                    inputString = ReadLine().ToLower();
                    if (inputString == "n")
                        totalCost += CHILD_COST;
                    else
                        totalCost += ADULT_COST;
                    Write("Did the patient have labs completed? Y/N: ");
                    inputString = ReadLine().ToLower();
                    if (inputString == "y")
                        totalCost += LABS_FEE;
                    WriteLine("The total cost of your appointment is {0:C2}", totalCost);
                    break;
                case 2:
                    WriteLine("Check-Up");
                    Write("Is the patient an adult? Y/N: ");
                    inputString = ReadLine().ToLower();
                    if (inputString == "n")
                        totalCost += CHILD_COST_CHECKUP;
                    else
                        totalCost += ADULT_COST_CHECKUP;
                    WriteLine("The total cost of your appointment is {0:C2}", totalCost);
                    break;
                default:
                    WriteLine("Invalid Appointment Type. Please Restart the program.");
                    break;
            }
        }
    }
}