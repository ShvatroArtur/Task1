using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.SweetsNamespace
{
    class AlcoholCandies:Candies
    {
        private double cocoaAmount;
        private string typeaAlcohol;
        public AlcoholCandies(string _name, double _weight, double _sugar, double _calories, double _fat, double _protein, double _carbohydrete, string _filling, double _cocoaAmount, string _typeaAlcohol)
                       : base(_name, _weight, _sugar, _calories, _fat, _protein, _carbohydrete, _filling)
        {
            cocoaAmount = _cocoaAmount;
            typeaAlcohol = _typeaAlcohol;
        }
        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString(), typeaAlcohol.ToString());
        }
    }
}
