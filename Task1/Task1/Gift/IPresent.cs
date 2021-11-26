using System;
using System.Collections.Generic;
using System.Text;
using Task1.Confection;
namespace Task1.Gift
{
    public interface IPresent
    {
        void Add(Sweets sweets);         
        IEnumerable<Sweets> Items { get; }
    }
}