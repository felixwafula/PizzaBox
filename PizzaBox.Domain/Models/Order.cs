using System;
using System.Collections.Generic;
using System.Linq;


namespace PizzaBox.Domain.Models
{
    public class Order
    //an order is a list of selected pizzas.
    {
        public List<Pizza> MyPizzaList { get; set; }

        //constructor
        public Order()
        {
            MyPizzaList = new List<Pizza>();
        }
        public void ViewCurrentOrder()
        {

        }

        public void ChangeCurrentOrder()
        {

        }





    }
}