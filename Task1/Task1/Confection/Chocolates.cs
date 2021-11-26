using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    public class Chocolates:Sweets,ICocoa
    {
        private string filling;
        private double cocoaAmount;
        public Chocolates(string name, string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrete, string filling, double cocoaAmount) 
        : base(name, package, weight, sugar, calories, fat, protein, carbohydrete)
        {
            this.filling = filling;
            this.cocoaAmount = cocoaAmount;
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),filling.ToString());
        }
        public double cocoaAmmount {get => cocoaAmmount; private set { }}
    }
}