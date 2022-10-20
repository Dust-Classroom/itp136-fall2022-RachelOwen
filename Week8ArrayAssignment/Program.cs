using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace ArrayAssignment
{
    class ArrayAssignment
    {
        static void Main(String[] args)
        {
            string[] carMake = new string[3];
            string[] carModel = new string[3];
            double[] carCost = new double[3];
            int index;
            string inputString;
            int highestCost = 0;
            for (index = 0; index < carMake.Length; index++)
            {
                Write("Enter the make of car number {0}: ", index+1);
                inputString = ReadLine();
                carMake[index] = inputString;
                Write("Model: ");
                inputString = ReadLine();
                carModel[index] = inputString;
                Write("Cost: ");
                inputString = ReadLine();
                carCost[index] = Convert.ToDouble(inputString);
                WriteLine("------------------------------");
            }
            for (index = 0; index < carMake.Length; index++)
            {
                WriteLine("Car {0}: {1} {2} - {3,2:C2}", index+1, carMake[index], carModel[index], carCost[index]);
            }
            WriteLine("------------------------------");
            for (index = 0; index < carCost.Length; index++)
            {
                if (carCost[index] > carCost[highestCost])
                {
                    highestCost = index;
                }
            }
            WriteLine("The car with the highest cost is the {0} {1}, priced at {2,2:C2}", carMake[highestCost], carModel[highestCost], carCost[highestCost]);
        }
    }
}