using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    public class Candies : Sweets
    { 
        private string filling;
        public Candies(string name,  string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrate, string filling) 
        :base(name, package, weight, sugar, calories, fat, protein, carbohydrate)
        {
            this.filling = filling; 
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),filling.ToString());
        }
    }
}