using static System.Console;
class SwapProgram
{
    static void Main()
    {
        int first = 34, second = 712;
        Write("Before swap first is {0}", first);
        WriteLine(" and second is {0}", second);
        Swap(ref first, ref second);
        Write("After swap first is {0}", first);
        WriteLine(" and second is {0}", second);
    }
    private static void Swap(ref int one, ref int two)
    {
        int temp;
        temp = one;
        one = two;
        two = temp;
    }
}