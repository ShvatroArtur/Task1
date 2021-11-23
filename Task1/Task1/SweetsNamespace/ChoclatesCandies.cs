using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.SweetsNamespace
{
    public class ChoclatesCandies : Candies
    {
        private double cocoaAmount;
        public ChoclatesCandies(string _name, double _weight, double _sugar, double _calories, double _fat, double _protein, double _carbohydrete, string _filling,double _cocoaAmount)
                       : base(_name, _weight, _sugar, _calories, _fat, _protein, _carbohydrete,_filling)
        {
            cocoaAmount = _cocoaAmount;
        }
        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString());
        }
    }
}