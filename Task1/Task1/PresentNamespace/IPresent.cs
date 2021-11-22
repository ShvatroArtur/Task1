using System;
using System.Collections.Generic;
using System.Text;
using SweetsNamespace;

namespace PresentNamespace
{
    public interface IPresent
    {
        void Add(Sweets swets);    
        double Weight();
        IEnumerable<Sweets> Sort(Func<Sweets, string> specification);
        IEnumerable<Sweets> FindSweets(double sugar1, double sugar2);
        IEnumerable<Sweets> FindCandies(double sugar1, double sugar2);
    }
}