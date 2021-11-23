using System;
using System.Collections.Generic;
using System.Text;
namespace Task1.SweetsNamespace
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
        public Sweets(string name, double weight, double sugar, double calories, double fat, double protein, double carbohydrete)
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
            return String.Join(" ", GetType(), name.ToString());
        }
        public string Name
        {

            get { return name; }
            private set { }
        }
        public double Weight
        {

            get { return weight; }
            private set { }
        }
        public double Sugar
        {

            get { return sugar; }
            private set { }
        }
    }
}