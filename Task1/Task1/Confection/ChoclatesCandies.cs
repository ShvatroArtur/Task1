using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    public class ChoclatesCandies : Candies,ICocoa
    {
        private double cocoaAmount;
        public ChoclatesCandies(string name, string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrate, string filling, double cocoaAmount)
                               : base(name, package, weight, sugar, calories, fat, protein, carbohydrate, filling)
        {
            this.cocoaAmount = cocoaAmount;
        }
        public double cocoaAmmount {get => cocoaAmmount; private set { }}
        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString());
        }
    }
}