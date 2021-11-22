using System;
using System.Collections.Generic;
using System.Text;
namespace SweetsNamespace
{
    public abstract class Sweets
    {
        public string name;       
        public double weight;
        public double sugar;
        public double calories;
        public double fat;
        public double protein;
        public double carbohydrate;
        public Sweets(string name, double weight,double sugar,double calories, double fat,double protein, double carbohydrete) 
        {
            this.name = name;
            this.weight = weight;
            this.sugar = sugar;
            this.calories = calories;
            this.fat = fat;
            this.protein = protein;
            this.carbohydrate = carbohydrate;
        }    
        public virtual string GetInfo()
        {
            return GetType()+" "+name.ToString();
        }
    }
}