using System;
using Task1.Confection;
using Task1.Gift;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweets sweets1 = new Chocolates("Аленка", "Бумага", 90, 120, 300, 12, 16, 23, "Апельсиновая", 40);
            Sweets sweets2 = new Biscuits("Слодыч", "Целофан", 90, 95, 300, 15, 16, 20, "Пшеничная");
            Sweets sweets3 = new ChoclatesCandies("Красная шапочка", "Бумага", 140, 120, 300, 12, 16, 23, "Банановая", 45);
            Sweets sweets4 = new NutsCandies("Грильяж", "Фольга", 90, 150, 300, 12, 16, 23, "Ореховая", 50, "Грецкие");
            Sweets sweets5 = new AlcoholCandies("Арахисовые", "Пара­финированная бумага", 90, 93, 300, 11, 14, 23, "Арахис", 32, "Коньяк");
            Sweets sweets6 = new Biscuits("Диетическое", "Фольга", 50, 95, 300, 8, 17, 21, "Ржаная");
            Present present = new Present();
            present.Add(sweets1);
            present.Add(sweets2);
            present.Add(sweets3);
            present.Add(sweets4);
            present.Add(sweets5);
            present.Add(sweets6);
            ActionPresent actionPresent = new ActionPresent(present.Items);
            actionPresent.ShowPresent();
            Console.WriteLine("--------Find sweets");
            actionPresent.FindSweets(90, 100);
            actionPresent.ShowPresent();
            Console.WriteLine("--------Find candies");
            actionPresent.FindCandies(90, 140);
            actionPresent.ShowPresent();
            Console.WriteLine("--------Sort sweets");
            actionPresent.Sort(x => x.Name);
            actionPresent.ShowPresent();
            Console.WriteLine("--------Sort candies for name");
            actionPresent.Sort(x => x is Candies, x => x.Name);
            actionPresent.ShowPresent();
            Console.WriteLine("--------Sort biscuits for Package");
            actionPresent.Sort(x => x is Biscuits, x => x.Package);
            actionPresent.ShowPresent();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Weigth = " + actionPresent.Weight());
        }
    }
}
