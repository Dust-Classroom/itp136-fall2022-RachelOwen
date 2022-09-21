using System;
using static System.Console;

namespace Week4Project
{
    class Week4Project
    {
        static void Main(String[] args)
        {
            Food banana = new Food();
            banana.FoodID = 0;
            banana.Name = "Banana";
            banana.Description = "A soft and mushy thing. Yellow when ripe.";
            banana.Cost = 5.00;

            Food apple = new Food();
            apple.FoodID = 1;
            apple.Name = "Apple";
            apple.Description = "How do you like them apples?";
            apple.Cost = 3.00;

            WriteLine("INVENTORY: ");
            WriteLine("\nItem 1: Banana");
            WriteLine(
                "-------------------------\n" +
                "ID: {0}\n" +
                "Name: {1}\n" +
                "Description: {2}\n" +
                "Cost: ${3}", 
                banana.FoodID, banana.Name, banana.Description, banana.Cost);
            WriteLine("\nItem 2: Apple");
            WriteLine(
                "-------------------------\n" +
                "ID: {0}\n" +
                "Name: {1}\n" +
                "Description: {2}\n" +
                "Cost: ${3}", 
                apple.FoodID, apple.Name, apple.Description, apple.Cost);
        }
    }

    public class Food
    {
        public int FoodID;
        public string Name;
        public string Description;
        public double Cost;
    }
}