using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static System.Console;

/* This code generates a forest of tree objects and allows the user to examine trees and their fruit
 * by inputting commands to the console
 * 
 * Knowing me it's probably very broken but rest assured an attempt is being made
 */

namespace Project4
{
    abstract public class Tree
    {
        public string name = "";
        public string description = "";
        public int id = 0;
        public int treeType;
        public override string ToString()
        {
            return name;
        }
    }
    public class Pine : Tree
    {
        public readonly string pineDescription = "A dense shroud of needles hide tiny pinecones containing this evergreen's seeds," +
                                              "\nThere are many species of pine tree, but you can't tell what this one is, exactly.";
        public Pine()
        {
            name = "Pine Tree";
            description = pineDescription;
            treeType = 0;
        }
    }
    public class Apple : Tree
    {
        private int numFruits = FruitCount();
        public List<Fruit> fruits = new();
        public int NumFruits
        {
            get
            {
                return numFruits;
            }
        }
        public Apple()
        {
            name = "Apple Tree";
            description = "Swaying in the branches of these mid-sized deciduous trees are a few white blossoms and " + NumFruits + " \napple(s), varying in ripeness.";
            GrowFruit(NumFruits);
            treeType = 1;
        }
        private static int FruitCount()
        {
            int numFruits = Forest.rand.Next(1,6);
            return numFruits;
        }

        private void GrowFruit(int numFruits)
        {
            for (int i = 0; i < numFruits; i++)
            {
                Fruit fruit = new();
                fruit.id = i+1;
                fruits.Add(fruit);
            }
        }
    }
    public class Fruit
    {
        public int ripeness;
        public int id;
        public Fruit()
        {
            ripeness = Forest.rand.Next(1, 11);
        }
        public string RipeDescription(int ripeness)
        {
            string ripenessDesc;
            if (ripeness < 4)
            {
                ripenessDesc = "This apple is small and has yet to ripen much at all.";
            }
            else if (ripeness < 4 && ripeness < 7)
            {
                ripenessDesc = "This apple is starting to look redder, but hasn't quite made it to full size yet.";
            }
            else
            {
                ripenessDesc = "This apple is ripe and juicy, just waiting to be picked!";
            }
            return ripenessDesc;
        }
    }
    public class Oak : Tree
    {
        public readonly string oakDescription = "Towering into the sky with a solid trunk and large leaves, " +
                                             "\nthis tree bears acorns that fall to the ground in autumn.";
        public Oak()
        {
            name = "Oak Tree";
            description = oakDescription;
            treeType = 2;
        }
    }
    public class Forest
    {
        public static Random rand = new Random();
        public List<Tree> treeList = new();
        const int NUM_TREES = 10;
        enum species
        {
            Pine = 0, //0
            Apple = 1, //1
            Oak = 2 //2
        }
        public void Populate(Random rand)
        {
            treeList.Clear();
            for(int i = 0; i < NUM_TREES; i++)
            {
                int treeType = rand.Next(3);
                switch (treeType)
                {
                    case (int)species.Pine:
                        Tree pineTree = new Pine();
                        pineTree.id = i+1;
                        treeList.Add(pineTree);
                        break;
                    case (int)species.Apple:
                        Tree appleTree = new Apple();
                        appleTree.id = i+1;
                        treeList.Add(appleTree);
                        break;
                    case (int)species.Oak:
                        Tree oakTree = new Oak();
                        oakTree.id = i+1;
                        treeList.Add(oakTree);
                        break;
                    default:
                        break;
                }
            }
        }
        public Forest()
        {
            Populate(rand);
        }
        private static void Display(Forest forest)
        {
            foreach(Tree tree in forest.treeList)
            {
                WriteLine("{0,-10} | ID: {1}", tree.name, tree.id);
            }
        }
        private static void Display(Fruit fruit)
        {
            WriteLine("Apple " + fruit.id + ": " + fruit.RipeDescription(fruit.ripeness));
        }
        private static void Display(Tree tree)
        {
            WriteLine(tree.ToString() + " | ID No. {0}: " + tree.description, tree.id);
        }
        static void Main(String[] args)
        {
            Forest forest = new Forest();
            int sentinel = 999;
            int treeIndex = 0;
            bool displayed = false;
            WriteLine("This Program Created by Rachel Owen");
            WriteLine("---------------------------------------");
            WriteLine("Before you is a forest full of trees, stretching as far as the eye can see. " +
                "\nTen of them are close enough to discern more about them.");
            WriteLine("----------------------------------------");
            Display(forest);
            WriteLine("----------------------------------------");
            Write("Enter a tree's ID to examine that tree further, or enter 999 to quit >> ");
            while (treeIndex == 0)
            {
                try
                {
                    treeIndex = int.Parse(ReadLine());
                    WriteLine("----------------------------------------");
                    Display(forest.treeList[treeIndex - 1]);
                    WriteLine("----------------------------------------");
                    if (forest.treeList[treeIndex - 1].treeType == 1)
                    {
                        Apple appleTree = (Apple)forest.treeList[treeIndex - 1];
                        Write("Would you like to examine the fruits in detail? (y/n) >> ");
                        string answer = ReadLine().ToUpper();
                        if (answer == "Y")
                        {
                            WriteLine("----------------------------------------");
                            WriteLine("You examine the apples on the apple tree:");
                            WriteLine("----------------------------------------");
                            foreach (Fruit fruit in appleTree.fruits)
                            {
                                Display(fruit);
                            }
                            treeIndex = 0;
                        }
                        else
                        {
                            treeIndex = 0;
                        }
                    }
                    else
                    {
                        treeIndex = 0;
                    }
                    WriteLine("----------------------------------------");
                    WriteLine("Before you is a forest full of trees, stretching as far as the eye can see. " +
                        "\nTen of them are close enough to discern more about them.");
                    WriteLine("----------------------------------------");
                    Display(forest);
                    Write("Enter a tree's ID to examine that tree further, or enter 999 to quit >> ");
                }
                catch (FormatException)
                {
                    Write("Invalid input. Please enter a number. >> ");
                    treeIndex = 0;
                }
                catch (ArgumentNullException)
                {
                    Write("Invalid input. Please enter a number. >> ");
                    treeIndex = 0;
                }
                catch (ArgumentOutOfRangeException)
                {
                    if (sentinel == treeIndex)
                    {
                        break;
                    }
                    Write("Invalid input. Please enter an existing ID number. >> ");
                    treeIndex = 0;
                }
            }
        }
    }
}