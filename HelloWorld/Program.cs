using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select a dialect...");

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            string dialect = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your name...");

            string userName = Console.ReadLine();

            switch (dialect)
            {
                case "southern":
                    Console.WriteLine($"Howdy, {userName}!");
                    break;
                case "northern":
                    Console.WriteLine($"Hey, {userName}!");
                    break;
                case "turtle":
                    Console.WriteLine($"Kowabunga {userName}!");
                    break;
                default:
                    Console.WriteLine($"Howdy, {userName}!");
                    break;

            }

            Console.WriteLine("What's your favorite color?");

            string userColor = Console.ReadLine();

            var animals = new string[] { "Triceratops", "Cat", "Gorilla", "Corgi", "Toucan", "Dog" };

            var random = new Random();

            int rndNum = random.Next(animals.Length);

            Console.WriteLine($"Would you like to have a {userColor} {animals[rndNum]}?");

            string petAnswer = Console.ReadLine().ToLower();

            if (petAnswer == "yes")
            {
                Console.WriteLine("Excellent!");
            }

            //var vowels = new char[]{ 'a', 'e', 'i', 'o', 'u', 'y' };

            //foreach (var animal in animals)
            //{
            //    var count = 0;
            //    var lastWasVowel = false;

            //    foreach (var currentChar in animal)
            //    {
            //        if(vowels.Contains(currentChar) && lastWasVowel == false)
            //        {
            //            count++;
            //            lastWasVowel = true;
            //        }
            //        else
            //        {
            //            lastWasVowel = false;
            //        }

            //        if ((animal.EndsWith("e") || (animal.EndsWith("es") || animal.EndsWith("ed"))) && !animal.EndsWith("le"))
            //        {
            //            count--;
            //        }
            //    }

            //    if (count > 1)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
