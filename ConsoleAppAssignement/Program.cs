using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.WriteLine("---First App---\nPlease type a word:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string2 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string3 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string4 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string5 = Console.ReadLine();
            Console.WriteLine("Please type a word:\n");
            string string6 = Console.ReadLine();
            string[] words = { string1, string2, string3, string4, string5, string6 };
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            //part 2
            Console.WriteLine("\n---Second App---\nPlease type a number");
            string Number = Console.ReadLine();
            int i = Convert.ToInt32(Number);
            // I put original value value i greater than 0 the loop would ifinitly add one
            while (i < 0)
            //solved by simply swapping  the greater than 0 for lesser than 0 which will end instantly unless negative value is typed in
            {
                i++;
                Console.Write("\t, " + i);

            }
            //part 3        

            Console.WriteLine("\n---Third App---\nHow many points do you have on your driving license?");

            List<int> points = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (int point in points)

            {
                if (point <= 11)
                {
                    Console.WriteLine("you have " + point + " you can keep your license ");
                }


                else
                {
                    Console.WriteLine("you have " + point + " or more points you have lost your license please retake driving and theory test");
                }
            }

            Console.ReadLine();

            Console.WriteLine("Welcome to store, before I sell you this product I need to see your ID");


            List<int> ages = new List<int> { 14, 16, 18, 25, 32 };

            foreach (int age in ages)


            {
                if (age < 18)
                {
                    Console.WriteLine("You're " + age + " I'm sorry I can't sell you that");

                }
                else
                {
                    Console.WriteLine("You're " + age + " Thank you for your purchase");
                }

            }
            Console.ReadLine();

            //part4

            List<string> cars = new List<string> { "Ford", "Honda", "Suzuki", "Seat", "Ferarri", "Lamborghini", "Toyota", "Vauxhall", "BMW", "Mercedes-Benz", "Fiat", "Honda" };



            Console.WriteLine("\n---Fourth App---\nSelect One of the following  Ford, Honda, Suzuki, Seat, Ferarri, Lamborghini, Toyota, Vauxhall, BMW, Mercedes - Benz, Fiat, Honda ");
            Console.WriteLine("Type one of the cars above (i.e type Ford)");
            string carMake = Console.ReadLine();
            foreach (string car in cars)

            {
                if (car == carMake)
                {
                    Console.WriteLine("I have Found: " + car);
                    break;
                }

                else
                {
                    Console.WriteLine(carMake + " Doesnt match our records!");
                }
            }
            Console.ReadLine();


            string[] cities = { "Riga", "Bejing", "Sidney", "Cairo", "Moscow", "Rome", "Paris", "Rome" };
            Console.WriteLine("\n---Fifth App---\n Please choose one of the following cities: Riga, Bejing, Sidney, Cairo, Moscow, Rome, Paris ");
            Console.WriteLine("Please type one of the cities i.e. Cairo");
            string cityName = Console.ReadLine();
            for (int k = 0; k < cities.Length; k++)

            {
                if (cities[k] == cityName)
                {
                    Console.WriteLine("We have found " + cities[k] + " in our records!");
                    break;
                }
                else
                {
                    Console.WriteLine("\"" + cityName + "\"" + "does not have a match in our records!");
                }

            }
            Console.ReadLine();

            List<string> birds = new List<string>() { "Eagle", "Swallow", "Falcon", "Eagle", "Owl", "Hawk", "Crow" };
            foreach (string bird in birds)
            {
                Console.WriteLine("List of Birds: " + bird);
            }


            IEnumerable<string> duplicates = birds.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .Select(x => x.Key);
            foreach (string duplicate in duplicates)
            {
                Console.WriteLine("These items are already in the list: " + String.Join(",", duplicates) + "\n-----END-----");


            }
            Console.ReadLine();








        }
    }
}