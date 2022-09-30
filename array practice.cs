using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // syntax used in all languages
            string[] names = new string[5];

            names[0] = "Tommy";
            names[1] = "Jose";
            names[2] = "Diana";
            names[3] = "Jimmy";
            names[4] = "Savanna";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //Printg an array directly in C# will show only its typing not its typing
            //Console.WriteLine(names);

           
            // I want to make a method that tells me wheather each age in the array is legally allowed to drink 21
            //only some langs allow you to fill in values ahead of time
            int[] ages = { 11, 15, 22, 17, 28, 21, 7, 20 };

            for (int i = 0; i < ages.Length; i++) 
            {
                int a = ages[i];
                bool canDrink = DrinkingAge(a);
                
                if (canDrink == true)
                {
                    Console.WriteLine($"a {a} year old can drink in the USA legally");
                } else 
                {
                    Console.WriteLine($" {a} year old cannot drink in the USA legally");
                }


            }
        }
        public static bool DrinkingAge(int age)
        {
            if (age > 21)
            {

                return true;
            } else 
            {
                return false;            
            }
        }
    }
}