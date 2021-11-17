using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public interface IPresent
    {
        void Add(Sweets swets);    
        double Weight();
        IEnumerable<Sweets> Sort(Func<Sweets, string> specification);
        IEnumerable<Sweets> Find(double sugar1, double sugar2);          
    }
}