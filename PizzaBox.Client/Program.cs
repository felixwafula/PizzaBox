using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new user.
            NewUser user = new NewUser();
            user.CreateNewUser();
            //User login.
            user.UserLogin();
            //User views and chooses a location.
            //user makes an order.
            //user make a custom order.
            //select a crust.
            //select  size.
            //select a set of toppings.
            //user reviews the current order.
            //user makes changes.
            //user confirms order.
            //User can view a history of past orders.
            //user signout.

        }
    }

}
