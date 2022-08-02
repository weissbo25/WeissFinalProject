using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeissFinalProject
{
    class Program
    {
        public static object mainDish { get; private set; }

        static void Main(string[] args)
        {
            string mainDish = "Chicken, Burger, Soups";
            Console.WriteLine($"What type of dish are you looking for to have for dinner tonight?  {mainDish}");
            Console.ReadLine();
            Console.WriteLine($"");
            Console.ReadKey();
            Console.ReadLine();
        }

        public class Ingredients //what all goes in the meal
        {
            
        }

        public class Dishes //Chicken, Burgers, Soups
        {
            public string mainDish = "Chicken, Burger, Soups";
            
            
        }

        public class TypeofMeal //Entrae, appetizer, soup etc..
        {
            public string chickenMeal = "Chicken Alfredo";
            public string burgerMeal = "Tacos";
            public string soupMeal = "Chicken Noodle Soup";
        }

        public class Instructions //also known as directions
        {

        }



    }
}