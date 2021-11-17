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

        public IEnumerable<Sweets> Find(double sugar1, double sugar2) => from i in items
                                                                         where (i.sugar >= sugar1) && (i.sugar <= sugar2)
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