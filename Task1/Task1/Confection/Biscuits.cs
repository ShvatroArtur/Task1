using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.Confection
{
    public class Biscuits : Sweets
    {

        private string flourGrade;
        public Biscuits(string name, string package, double weight, double sugar, double calories, double fat, double protein, double carbohydrete, string flourGrade) : 
        base(name, package, weight, sugar, calories, fat, protein, carbohydrete)
        {
            this.flourGrade = flourGrade;
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),flourGrade.ToString());
        }
    }
}