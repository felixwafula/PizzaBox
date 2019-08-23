using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {   //a pizza is a list of ingredients.
        public string myCrust { get; set; }
        public string mySize { get; set; }

        public decimal myPrice { get; set; }
        public List<string> myToppingsList { get; set; }


        //constructor
        public Pizza()
        {

        }
        //methods.
        public override string ToString()
        {
            return $"{myCrust}\n{mySize}\n{myPrice}\n{myToppingsList}";
        }

        public Pizza MakeMyPizza()
        {
            System.Console.WriteLine("Choose a crust: ");
            var crust = System.Console.ReadLine();
            System.Console.WriteLine("Choose a size: ");
            var size = System.Console.ReadLine();


            var toppings = new List<string>() { "sauce", "cheese" };
            System.Console.WriteLine("Choose 3 toppings please: ");

            var topping1 = System.Console.ReadLine();
            var topping2 = System.Console.ReadLine();
            var topping3 = System.Console.ReadLine();

            toppings.Add(topping1);
            toppings.Add(topping2);
            toppings.Add(topping3);



            var MyPizza = new Pizza
            {
                myCrust = crust,
                mySize = size,
                myToppingsList = toppings

            };

            System.Console.WriteLine("Your crust is {0}, your size is {1}", MyPizza.myCrust, MyPizza.mySize);
            System.Console.WriteLine("Your toppings are: ");

            // foreach (var topping in myToppingsList)
            // {
            //     System.Console.WriteLine(topping);
            // }

            return MyPizza;

        }
    }


}