using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    public class Chocolates:Sweets,ICocoa
    {
        private string filling;
        private double cocoaAmount;
        public Chocolates(string _name, string _package, double _weight, double _sugar, double _calories, double _fat, double _protein, double _carbohydrete, string _filling, double _cocoaAmount) 
        : base(_name, _package, _weight,_sugar,_calories,_fat, _protein, _carbohydrete)
        {
            filling = _filling;
            cocoaAmount = _cocoaAmount;
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),filling.ToString());
        }
        public double cocoaAmmount { get => cocoaAmmount; private set { } }
    }
}