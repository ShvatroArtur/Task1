using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class Sweets
    {
        private string name;       
        private double weight;
        private double sugar;
        private double calories;
        private double fat;
        private double protein;
        private double carbohydrate;


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

       

        public abstract string GetInfo();   


    }
}