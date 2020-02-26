using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");

            var animals = new string[] { "Triceratops", "Cat", "Gorilla", "Corgi", "Toucan", "Dog" };
            var vowels = new char[]{ 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var animal in animals)
            {
                var count = 0;
                var lastWasVowel = false;

                foreach (var currentChar in animal)
                {
                    if(vowels.Contains(currentChar) && lastWasVowel == false)
                    {
                        count++;
                        lastWasVowel = true;
                    }
                    else
                    {
                        lastWasVowel = false;
                    }

                    if ((animal.EndsWith("e") || (animal.EndsWith("es") || animal.EndsWith("ed"))) && !animal.EndsWith("le"))
                    {
                        count--;
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(animal);
                }
            }

            Console.ReadKey();
        }
    }
}
