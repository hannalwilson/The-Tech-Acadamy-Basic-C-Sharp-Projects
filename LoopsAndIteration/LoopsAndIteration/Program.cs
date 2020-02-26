using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dessertFlavors = { "chocolate ", "strawberry ", "vanilla ", "rocky road ", "marionberry ", "red velvet " };

            Console.WriteLine("Hi there, I need some help. What dessert do you like the most: ice cream, pudding, or cake?");
            string dessert = Console.ReadLine();

            for (int i = 0;  i < dessertFlavors.Length; i++)
            {
                dessertFlavors[i] = dessertFlavors[i] + dessert;
            }
            Console.WriteLine("Thank you!");
            Console.WriteLine("Press enter for your dessert choices:");
            Console.ReadLine();
            
            for (int j = 0; j < dessertFlavors.Length; j++)
            {
                Console.WriteLine(dessertFlavors[j]);
            }
            Console.ReadLine();

            Console.WriteLine("You get to choose your dessert in...");

            int k = 5;
            //while (k < 6) created infinite loop
            while (0 <= k) //fixed infinite loop
            {
                Console.WriteLine(k);
                k--;
            }
            Console.WriteLine("Just kidding! No dessert for you!");
            Console.WriteLine("Muahahaha!!");
            Console.WriteLine("Moving on...");
            Console.ReadLine();

            List<string> flowers = new List<string> { "null", "roses", "tulips", "sunflowers", "jasmine", "lavender"};
            Console.WriteLine("I've ranked my top five favorite flowers. Choose one to see where it is ranked on my list:");
            Console.WriteLine("sunflowers, roses, lavender, jasmine, and tulips");
            string flowerInput = Console.ReadLine();
            bool isChoosen = false;

            while (!isChoosen)
            {
                foreach (string flower in flowers)
                {
                    if (flower == flowerInput)
                    {
                        Console.WriteLine("The flower you picked is ranked number " + flowers.IndexOf(flower) + "!");
                        isChoosen = true;

                        if (isChoosen == false)
                        {
                            Console.WriteLine("You didn't choose a flower from the list dummy!");
                            isChoosen = true;
                            break;
                        }
                    }
                 
                    
                }

            }
            Console.ReadLine();

            Console.WriteLine("Aside from dessert and flowers, another thing I love is breakfast!");
            Console.WriteLine("I've created a list of all the breakfast foods I've eaten in the last few days.");
            Console.WriteLine("Pick a common breakfast food (ie. eggs, bacon, waffles) to see where it appears on my list.");
            string foodInput = Console.ReadLine();

            List<string> foods = new List<string> { "biscuit", "bacon", "eggs", "sausage", "pancakes", "toast", "eggs", "toast", "null"};
            for (int l = 0; l < foods.Count; l++)
            {
                if (foodInput == foods[l])
                {
                    Console.WriteLine(l);
                }
                if (l == 8)
                {
                    Console.WriteLine("Sorry, I haven't eaten that for breakfast recently.");
                }
                
            }
            Console.ReadLine();

            Console.WriteLine("One last thing...");
            Console.WriteLine("I'm losing my creativity now. So this last part won't be as much fun.");

            List<string> drinks = new List<string>() { "water", "coffee", "seltzer", "coffee", "wine", "juice", "water" };
            List<string> newDrinks = new List<string>();

            foreach (string drink in drinks)
            {
                if (!newDrinks.Contains(drink))
                {
                    newDrinks.Add(drink);
                    Console.WriteLine("The beverage " + drink + " has not already appeared.");
                }
                else if (newDrinks.Contains(drink))
                {
                    Console.WriteLine("The beverage " + drink + " has appeared already.");
                }
            }
            
           


            Console.ReadLine();
        }
    }
}
