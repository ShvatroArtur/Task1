using System;
using System.Collections.Generic;
using System.Text;
using Task1.Confection;
namespace Task1.Gift
{
    public interface IPresent
    {
        void Add(Sweets sweets);            
        IEnumerable<Sweets> Sort(Func<Sweets, string> specification);
        IEnumerable<Sweets> FindSweets(double minSugarWeith, double maxSugarWeith);
        IEnumerable<Sweets> FindCandies(double minSugarWeith, double maxSugarWeith);
        double Weight();
    }
}