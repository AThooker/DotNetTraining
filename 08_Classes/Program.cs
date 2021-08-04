using System;
using Classes;

Donut doug = new Donut("dans");
// doug.donutType = "tiger tail";
doug.SetDonutType("chocolate");
System.Console.WriteLine(doug.GetDonutType());
doug.Filling = "jelly";
System.Console.WriteLine(doug.Filling);
doug.Topping = "Sprinkles";
doug.IsSpecial = false;
doug.Price = 1.4;
System.Console.WriteLine($"This donut is {doug.GetDonutType()} full of {doug.Filling} topped with {doug.Topping} for ${doug.Price}.");
namespace Classes
{
    class Donut
    {
        private string donutType;
        public Donut(string type)
        {
            donutType = type;
        }

        public string Filling { get; set; }
        public string Topping { get; set; }
        public double Price { get; set; }
        public bool IsSpecial { get; set; }
        public string GetDonutType()
        {
            return donutType;
        }
        public void SetDonutType(string type)
        {
            donutType = type;
        }
    }
}
