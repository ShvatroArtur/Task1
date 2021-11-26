using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    class NutsCandies:Candies,ICocoa
    {
        private double cocoaAmount;
        private string typeNuts;
        public NutsCandies(string name, string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrete, string filling, double cocoaAmount, string typeNuts)
                          : base(name, package, weight, sugar, calories, fat, protein, carbohydrete, filling)
        {
            this.cocoaAmount = cocoaAmount;
            this.typeNuts = typeNuts;
        }
        public override string GetInfo()
        {
            return String.Join(" ", base.GetInfo(), cocoaAmount.ToString(),typeNuts.ToString());
        }
        public double cocoaAmmount {get => cocoaAmmount; private set { }}
    }
}
