using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.SweetsNamespace
{
    public class Biscuits : Sweets
    {

        private string flourGrade;
        public Biscuits(string _name,double _weight,double _sugar,double _calories,double _fat,double _protein,double _carbohydrete,string _flourGrade) : 
        base(_name,_weight,_sugar,_calories,_fat,_protein,_carbohydrete)
        {
            flourGrade = _flourGrade;
        }
        public override string GetInfo()
        {
            return String.Join(" ",base.GetInfo(),flourGrade.ToString());
        }
    }
}