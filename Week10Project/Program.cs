using System;
using Week10Project;
using static System.Console;

namespace Week10Project
{
    public class Part
    {
        public int partNum;
        public string partName, partDescription;
        public decimal partCost;
        public Part(int partNum, string partName, string partDescription, decimal partCost)
        {
            this.partNum = partNum;
            this.partName = partName;
            this.partDescription = partDescription;
            this.partCost = partCost;
        }
        public void partDisplay()
        {
            WriteLine("------------------------------------------------------------------");
            WriteLine("Part No. |\tPart Name\t|\tDescription\t| Cost (USD)");
            WriteLine("------------------------------------------------------------------");
            WriteLine("{0,-8} | {1,-20} | {2,-21} | {3,-10:C2}", partNum, partName, partDescription, partCost);
        }
    }
    class mainClass
    {
        static void Main(String[] args)
        {
            int partNum, numParts;
            string partName, partDescription;
            decimal partCost;
            List<Part> partList = new List<Part>();
            Part tempPart;
            Write("Welcome to the Parts Database, how many parts will you be adding today? ");
            numParts = Convert.ToInt32(ReadLine());
            for (int i = 0; i < numParts; i++)
            {
                Write("Enter the Part Number of part {0}: ", i + 1);
                partNum = Convert.ToInt32(ReadLine());
                Write("Enter the name of part {0}: ", i + 1);
                partName = ReadLine();
                Write("Enter the description for part {0}: ", i + 1);
                partDescription = ReadLine();
                Write("Enter the cost of part {0} in USD, without a dollar sign ($): ", i + 1);
                partCost = Convert.ToDecimal(ReadLine());
                tempPart = new Part(partNum, partName, partDescription, partCost);
                partList.Add(tempPart);
            }
            tempPart = null;
            Part[] partArray = partList.ToArray();
            WriteLine("------------------------------------------------------------------");
            WriteLine("All parts by name and part number:");
            WriteLine("------------------------------------------------------------------");
            foreach (Part part in partArray)
            {
                WriteLine("Part No. {0}: {1}", part.partNum, part.partName);
            }
            WriteLine("------------------------------------------------------------------");
            Write("Enter a part's number to view more details about that part! ");
            partNum = Convert.ToInt32(ReadLine());
            bool partFound = false;
            foreach (Part part in partArray)
            {
                if (part.partNum == partNum)
                {
                    part.partDisplay();
                    partFound = true;
                    break;
                }
            }
            if(!partFound)
            {
                WriteLine("Invalid part number.");
            }
        }
    }
}
