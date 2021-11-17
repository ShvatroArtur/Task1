using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            EatSweets eatSweets = new EatSweets();
            Sweets sweets1 = new Chocolates("Аленка", 90, 120, 300, 12, 16, 23, TypeChocolates.Stick);
            Sweets sweets2 = new Biscuits("Слодыч", 90, 95, 300, 12, 16, 23, TypeBiscuits.Sugar);
            Sweets sweets3 = new Candies("Красная шапочка", 140, 120, 300, 12, 16, 23, TypeCandies.Chokolate);
            Sweets sweets4 = new Candies("Птичье молоко", 90, 93, 300, 12, 16, 23, TypeCandies.Souffle);

            Present present = new Present();
            present.Add(sweets1);
            present.Add(sweets2);
            present.Add(sweets3);
            present.Add(sweets4);

            present.ShowPresent(present.Items);
            Console.WriteLine("-------------------------------"); 
            eatSweets.Eat(present.Find(90, 100));
            Console.WriteLine("-------------------------------");
            present.ShowPresent(present.Sort(x => x.name));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Weigth = " + present.Weight());    
            

        }

    }
}
