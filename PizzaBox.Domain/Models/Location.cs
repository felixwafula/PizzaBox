using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaBox.Domain.Models
{
    public class Location
    {
        private const string path = @"C:\revature\project-0\PizzaBoxApp\TempStore\Locations.txt";
        public static string Path => path;
        public Dictionary<int, string> MyStoreInventory { get; set; }
        public List<Order> StoreOrdersList { get; set; }
        public List<Pizza> myOrderList { get; set; }

        //constructor
        public Location()
        {
            StoreOrdersList = new List<Order>();
        }
        //Instances
        Dictionary<int, string> locationsList = new Dictionary<int, string>();


        //methods
        public void Store(int storeNumber, string storeAddress)
        {

            if (!locationsList.ContainsKey(storeNumber))
            {
                locationsList.Add(storeNumber, storeAddress);
            }
            else
            {
                locationsList[storeNumber] = storeAddress;
                System.Console.WriteLine("The store number or store address already exists.");
            }

            this.SaveLocation(storeNumber, storeAddress);

        }

        public void ViewLocations()
        {
            System.Console.WriteLine("Our Store Locations are:");
            locationsList.ToList().ForEach(storeNumber => Console.WriteLine("StoreId: {0}, storeAddress: {1}", storeNumber.Key, storeNumber.Value));
            // foreach (var location in storesList.Keys)
            // {
            //     System.Console.WriteLine("Our store locations are: StoreAddress {0}", storesList[location]);
            // }
        }
        public void SaveLocation(int storeNumber, string storeAddress)
        {
            using (StreamWriter sw = new StreamWriter(File.Create(Path)))
            {

                sw.WriteLine(storeNumber);
                sw.WriteLine(storeAddress);
                sw.Close();
            }
            //System.Console.WriteLine("Store saved succesfully!");
            //Console.Read();
        }
        public void GetStoreAddress()
        {

            System.Console.WriteLine("Select a location:");
            var storeNumber = Int32.Parse(System.Console.ReadLine());


            if (!locationsList.ContainsKey(storeNumber))
            {
                System.Console.WriteLine("Store number {0} doesn't exist. Please choose a store from the provided list.", storeNumber);

                this.GetStoreAddress();
            }
            else
            {
                string storeAddress = locationsList[storeNumber];
                System.Console.WriteLine("Welcome to PizzaBox store {0} on: {1}!", storeNumber, storeAddress);
            }


        }
        public void MakeOrder()
        {
            Pizza pizza = new Pizza();

            myOrderList = new List<Pizza>
            {
                pizza.MakeMyPizza()
            };
            System.Console.WriteLine("Order another Pizza? Y/N");
            string input = System.Console.ReadLine();
            if (input.ToLower() == "y")
            {
                this.MakeOrder();
            }
            else
            {
                System.Console.WriteLine("Thank you for your order!");
            }


        }



    }
}