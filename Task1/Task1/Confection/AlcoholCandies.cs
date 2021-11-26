using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Confection
{
    class AlcoholCandies:Candies,ICocoa
    {
        private double cocoaAmount;
        private string typeaAlcohol;
        public AlcoholCandies(string name, string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrate, string filling, double cocoaAmount, string typeaAlcohol)
                       : base(name, package, weight, sugar, calories, fat, protein, carbohydrate, filling)
        {
            this.cocoaAmount = cocoaAmount;
            this.typeaAlcohol = typeaAlcohol;
        }
        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString(), typeaAlcohol.ToString());
        }
        public double cocoaAmmount { get => cocoaAmmount; private set { } }
    }
}
