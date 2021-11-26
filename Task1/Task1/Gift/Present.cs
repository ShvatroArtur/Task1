using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Confection;
namespace Task1.Gift
{
    public class Present: IPresent
    {
        private List<Sweets> items;
        public Present()
        {
            items = new List<Sweets>();
        }       
        public void Add(Sweets sweets) => items.Add(sweets);        
        public IEnumerable<Sweets> Items
        {
            get { return items; }
            private set { }
        }        
    }
}