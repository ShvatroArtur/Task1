using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Chocolates:Sweets
    {
        private TypeChocolates type;
        public Chocolates(string _name, double _weight, double _sugar, double _calories, double _fat, double _protein, double _carbohydrete, TypeChocolates _type) : base(_name, _weight, _sugar, _calories, _fat, _protein, _carbohydrete)
        {
            type = _type;
        }
        public override string GetInfo()
        {
            return base.GetInfo()+" "+type.ToString();
        }
    }
}