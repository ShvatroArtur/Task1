using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.SweetsNamespace
{
    public class Candies : Sweets
    {
        
        private string filling;
        public Candies(string _name,double _weight,double _sugar,double _calories,double _fat,double _protein,double _carbohydrete,string _filling) 
        :base(_name,_weight,_sugar,_calories,_fat,_protein,_carbohydrete)
        {
            filling = _filling; 
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),filling.ToString());
        }
    }
}