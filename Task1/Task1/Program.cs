using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweets sweets1 = new Chocolates("Аленка", 90, 120, 300, 12, 16, 23,"Апельсиновая",40);
            Sweets sweets2 = new Biscuits("Слодыч", 90, 95, 300, 12, 16, 23, "Пшеничная");
            Sweets sweets3 = new Candies("Красная шапочка", 140, 120, 300, 12, 16, 23, "Банановая");
            Sweets sweets4 = new Candies("Птичье молоко", 90, 93, 300, 12, 16, 23, "Суфле");
            Sweets sweets5 = new Candies("Арахисовые", 90, 93, 300, 12, 16, 23, "Арахис");
            Present present = new Present();
            present.Add(sweets1);
            present.Add(sweets2);
            present.Add(sweets3);
            present.Add(sweets4);
            present.Add(sweets5);
            present.ShowPresent(present.Items);
            Console.WriteLine("--------Find sweets");
            present.ShowPresent(present.FindSweets(90, 100));
            Console.WriteLine("--------Find candies");
            present.ShowPresent(present.FindCandies(90, 140));
            Console.WriteLine("--------Sort sweets");
            present.ShowPresent(present.Sort(x => x.name));
            Console.WriteLine("--------Sort candies");
            present.ShowPresent(present.SortCandies());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Weigth = " + present.Weight());    
            

        }

    }
}
