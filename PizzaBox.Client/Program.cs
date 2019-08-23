using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.authenticate();
            p.GetSomePizza();

            // user.PastUserOrders();
            // //user signout.
            // user.SignOut();

        }
        public void authenticate()
        {
            User user = new User();
            user.UserLogin();
            //user.CreateNewUser();            
        }
        public void GetSomePizza()
        {
            Location store = new Location();
            Order newOrder = new Order();
            Toppings newToppings = new Toppings();
            Pizza pizzaOrder = new Pizza();
            store.Store(4, "Likoni St.");
            store.ViewLocations();
            store.GetStoreAddress();
            //pizzaOrder.MakeMyPizza();
            //newToppings.ChooseToppings();
            store.MakeOrder();
            //newOrder.ChangeCurrentOrder();
            //newOrder.ConfirmOrder();
            //User can view a history of past orders.
        }
    }


}
