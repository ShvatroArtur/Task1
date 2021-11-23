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
        IEnumerable<Sweets> FindSweets(double minSugarWeith, double maxSugarWeith);
        IEnumerable<Sweets> FindCandies(double minSugarWeith, double maxSugarWeith);
    }
}