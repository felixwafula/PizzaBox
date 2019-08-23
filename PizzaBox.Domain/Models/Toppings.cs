using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Toppings
    {
        public List<string> MyToppingsList { get; set; }
        //constructor.
        public Toppings()
        {

        }
        //methods
        // public List<string> ChooseToppings()
        // {
        //     MyToppingsList = new List<string>() { "sauce", "cheese" };
        //     System.Console.WriteLine("Choose 3 toppings please: ");

        //     var topping1 = System.Console.ReadLine();
        //     var topping2 = System.Console.ReadLine();
        //     var topping3 = System.Console.ReadLine();

        //     MyToppingsList.Add(topping1);
        //     MyToppingsList.Add(topping2);
        //     MyToppingsList.Add(topping3);

        //     System.Console.WriteLine("Your toppings are: ");
        //     foreach (var topping in MyToppingsList)
        //     {
        //         System.Console.WriteLine(topping);
        //     }

        //     return MyToppingsList;

        // }
    }

}