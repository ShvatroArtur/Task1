using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class EatSweets
    {
      
        public void Eat(IEnumerable<Sweets> sweets)
        {
            foreach (var i in sweets)
            {
                var name = i.name;
                if (i is Biscuits)
                {
                    Console.WriteLine("Кушаем печенье "+name);
                }
                else if (i is Chocolates)
                {
                    Console.WriteLine("Кушаем шоколадку "+ name);
                }
                else if (i is Candies)
                {
                    Console.WriteLine("Кушаем конфеты "+ name);
                }
            }
               

        }
    }
}