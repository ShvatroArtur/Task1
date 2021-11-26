using System;
using System.Collections.Generic;
using System.Text;
using Task1.Confection;
namespace Task1.Gift
{
    interface IActionPresent
    {
        double Weight();
        IEnumerable<Sweets> Sort(Func<Sweets, string> specification);
        IEnumerable<Sweets> Sort(Func<Sweets, bool> predicate, Func<Sweets, string> keySelector);
        IEnumerable<Sweets> FindSweets(double minSugarWeith, double maxSugarWeith);
        IEnumerable<Sweets> FindCandies(double minSugarWeith, double maxSugarWeith);
        void ShowPresent();
    }
}
