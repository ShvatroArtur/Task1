using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Confection
{
    public class ChoclatesCandies : Candies,ICocoa
    {
        private double cocoaAmount;
        public ChoclatesCandies(string _name, string _package, double _weight, double _sugar, double _calories, double _fat, double _protein, double _carbohydrete, string _filling,double _cocoaAmount)
                       : base(_name, _package, _weight, _sugar, _calories, _fat, _protein, _carbohydrete,_filling)
        {
            cocoaAmount = _cocoaAmount;
        }

        public double cocoaAmmount { get => cocoaAmmount; private set { } }

        //public double cocoaAmmount { get =>cocoaAmount; private set; }

        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString());
        }
    }
}