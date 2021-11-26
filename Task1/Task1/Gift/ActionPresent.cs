using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1.Confection;
namespace Task1.Gift
{
    class ActionPresent:IActionPresent
    {
        private IEnumerable<Sweets> items;       
        public ActionPresent(IEnumerable<Sweets> items)
        {
            this.items = items;
        }
        public double Weight() => items.Sum(n => n.Weight);
        public IEnumerable<Sweets> Sort(Func<Sweets, string> specification) => items.OrderBy(specification);
        public IEnumerable<Sweets> Sort(Func<Sweets, bool> predicate, Func<Sweets, string> keySelector) => items.Where(predicate).OrderBy(keySelector);
        public IEnumerable<Sweets> FindSweets(double minSugarWeith, double maxSugarWeith) => from i in items
                                                                                             where (i.Sugar >= minSugarWeith) && (i.Sugar <= maxSugarWeith)
                                                                                             select i;
        public IEnumerable<Sweets> FindCandies(double minSugarWeith, double maxSugarWeith) => from i in items
                                                                                              where (i is Candies) && (i.Sugar >= minSugarWeith) && (i.Sugar <= maxSugarWeith)
                                                                                              select i;
        public void ShowPresent()
        {
            foreach (var i in items)
            {
                Console.WriteLine(i.GetInfo());
            }
        }
    }
}
