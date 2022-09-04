using static System.Console;
//Week 2 Project
//Rachel C. Owen
namespace Week2Variables
{
    class Week2Variables
    {
        static void Main(String[] args)
        {
            decimal oilChange, tires, inspection, subtotal, grandTotal, tax; //Initializing all decimal values necessary for this assignment and keeping to decimal values
            const decimal TAX_RATE = 0.06M; //constant for tax rate, written in decimal form to keep consistency
            WriteLine("This application displays the service total and tax of your auto repair bill.");
            Write("Enter your oil change total: ");
            oilChange = decimal.Parse(ReadLine()); //reads the input from the user and parses it as a decimal input for all the values supplied by the user
            Write("Enter the total for tires: ");
            tires = decimal.Parse(ReadLine());
            Write("Enter your total for inspection: ");
            inspection = decimal.Parse(ReadLine());
            subtotal = oilChange + tires + inspection; //sum up oil change, tires, and inspection
            tax = subtotal * TAX_RATE; //calculating the tax deducted by multiplying the subtotal by the tax rate
            grandTotal = subtotal + tax; //grand total is the subtotal plus the tax
            WriteLine("\n" +
                "      Service Receipt\n" +
                "--------------------------\n" + //I decided to be fancy with my receipt display here.
                "Oil:\t\t{0,-9:C2}\n" +
                "Tires:\t\t{1,-9:C2}\n" +
                "Inspection:\t{2,-9:C2}\n" +
                "Subtotal:\t{3,-9:C2}\n" +
                "Tax:\t\t{4,-9:C2}\n" +
                "Grand Total:\t{5,-9:C2}", //took a lot of testing to get the spacing just right,works up to decently high dollar amounts too.
                oilChange, tires, inspection, subtotal, tax, grandTotal); //this was absolutely necessary. For sure.
            WriteLine(
                "--------------------------\n" +
                "Thank you for choosing us!");
            ReadKey(); //Visual studio does this automatically when compiling and this is bad practice, but I was told to include it, so it's here.
        }
    }
}