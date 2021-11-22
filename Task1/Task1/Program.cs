using System;
using SweetsNamespace;
using PresentNamespace;
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
            Sweets sweets6 = new Biscuits("Диетическое", 50, 95, 300, 12, 16, 23, "Ржаная");
            Present present = new Present();
            present.Add(sweets1);
            present.Add(sweets2);
            present.Add(sweets3);
            present.Add(sweets4);
            present.Add(sweets5);
            present.Add(sweets6);
            present.ShowPresent(present.Items);
            Console.WriteLine("--------Find sweets");
            present.ShowPresent(present.FindSweets(90, 100));
            Console.WriteLine("--------Find candies");
            present.ShowPresent(present.FindCandies(90, 140));
            Console.WriteLine("--------Sort sweets");
            present.ShowPresent(present.Sort(x => x.name));             
            Console.WriteLine("--------Sort candies");
            present.ShowPresent(present.SortCandies(x => x.GetType() == typeof(Candies), x => x.name));
            Console.WriteLine("--------Sort biscuits");
            present.ShowPresent(present.SortCandies(x => x.GetType() == typeof(Biscuits), x => x.name));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Weigth = " + present.Weight());    
            

        }

    }
}
