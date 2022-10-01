using static System.Console;

namespace Methods_Assignment
{
    class Methods_Assignment
    {
        public static void WelcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
            return;
        }
        public static void MagicNumber(int secretNumber=64)
        {
            WriteLine("Magic Number: {0}",secretNumber);
            return;
        }
        public static void GetArea(int length, int width)
        {
            int product = length * width;
            WriteLine("The Area of this rectangle is: {0}", product);
            return;
        }
        public static decimal LocalTaxRate()
        {
            decimal taxRate;
            Write("Enter the local tax rate: ");
            taxRate = Decimal.Parse(ReadLine());
            return taxRate;
        }
        static void Main(string[] args)
        {
            WelcomeStatement();
            MagicNumber();
            GetArea(2,3);
            decimal taxRate = LocalTaxRate();
            WriteLine("The Local Tax Rate Is: {0}", taxRate);
        }
    }
}