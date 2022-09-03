using static System.Console;
class DemoVariables2
{
    static void Main()
    {
        int value1 = 43, value2 = 10,
            sum, diff, product, quotient, remainder;
        sum = value1 + value2;
        diff = value1 - value2;
        product = value1 * value2;
        quotient = value1 / value2;
        remainder = value1 % value2;
        WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
        WriteLine("The difference between {0} and {1}" + " is {2}", value1, value2, diff);
        WriteLine("{0} divided by {1} is {2}", value1, value2, quotient);
        WriteLine("and the remainder is {0}", remainder);
    }
}
