using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class Present : IPresent
    {
        private List<Sweets> items;

        public Present()
        {
            items = new List<Sweets>();
        }

        public void Add(Sweets sweets) => items.Add(sweets);

        public double Weight() => items.Sum(n => n.weight);

        public IEnumerable<Sweets> Sort(Func<Sweets, string> specification) => items.OrderBy(specification);

        public IEnumerable<Sweets> SortCandies(Func<Sweets, bool> predicate, Func<Sweets, string> keySelector) => items.Where(predicate).OrderBy(keySelector);

        public IEnumerable<Sweets> FindSweets(double minSugarWeith, double maxSugarWeith) => from i in items
                                                                         where (i.sugar >= minSugarWeith) && (i.sugar <= maxSugarWeith)
                                                                         select i;
        public IEnumerable<Sweets> FindCandies(double minSugarWeith, double maxSugarWeith) => from i in items
                                                                         where (i.GetType()==typeof(Candies))&&(i.sugar >= minSugarWeith) && (i.sugar <= maxSugarWeith)
                                                                         select i;        

        public void ShowPresent(IEnumerable<Sweets> sweets)
        {
            foreach (var i in sweets)
            {
                Console.WriteLine(i.GetInfo());
            }

        }
        public IEnumerable<Sweets> Items
        {
            get {return items;}    
            private set {}
        }

            
    }
}